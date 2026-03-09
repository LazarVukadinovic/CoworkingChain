# Coworking Reservation System

A desktop application for managing coworking spaces, built with **C# WinForms** on **.NET 8**. Supports both **MySQL** and **MSSQL** out of the box, with a companion **Windows Service** that automatically generates CSV usage reports.

---

## Table of Contents

- [Features](#features)
- [Architecture Overview](#architecture-overview)
- [Design Patterns](#design-patterns)
- [Project Structure](#project-structure)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Configuration](#configuration)
- [Database](#database)
- [Windows Service](#windows-service)
- [Security](#security)

---

## Features

- **Member management** — full CRUD with filters by location, membership type, and account status; name search
- **Location management** — coworking locations with working hours, capacity, and real-time occupancy statistics
- **Resource management** — workstations (hot desk / dedicated desk / private office) and meeting rooms with equipment flags
- **Reservation management** — create, edit, cancel; filter by user+status or by location+date; automatic status transition to *Finished* when the end time passes
- **Membership type management** — configurable packages with monthly hour limits, meeting room access, and pricing
- **Admin account management** — change username and password (BCrypt-verified)
- **Real-time UI refresh** — all open forms update automatically when the underlying data changes, via an Observer mechanism backed by database triggers
- **Windows Service** — periodically generates UTF-8 CSV reports; interval and report period are fully configurable via a plain-text file

---

## Architecture Overview

The application is organized into strict layers that communicate top-down only. Every layer depends on an abstraction (interface), never on a concrete class from another layer.

```
┌─────────────────────────────────────────────────────┐
│                  WinForms UI Layer                  │
│  (forms subscribe to DataChanged, call IDataBase)   │
├─────────────────────────────────────────────────────┤
│               DataBaseProxy  [Proxy]                │
│  (in-memory cache + 10s timer → Observer events)   │
├─────────────────────────────────────────────────────┤
│              DataBaseFacade  [Facade]               │
│  (single IDataBase interface over 9 repositories)  │
├─────────────────────────────────────────────────────┤
│            Repository Layer  [Repository]           │
│  (one class per table, all SQL lives here)          │
├─────────────────────────────────────────────────────┤
│            DataBaseAdapter  [Adapter]               │
│  (executes queries via IDataBaseFactory)            │
├─────────────────────────────────────────────────────┤
│  Abstract Factory  +  SQL Syntax Adapter            │
│  MySqlFactory / MsSqlFactory                        │
│  MySqlSyntaxAdapter / MsSqlSyntaxAdapter            │
└─────────────────────────────────────────────────────┘
```

### Call flow example — adding a reservation

```
DodajRezervaciju (form)
  → Chain of Responsibility validators
      ZauzetostResursaValidator   (resource free in that slot?)
      LimitSatiClanValidator      (member under monthly hour limit?)
      RadnoVremeLokacijeValidator (within location working hours?)
  → DataBaseSingleton.vratiInstancu()   [Singleton]
  → DataBaseProxy.dodajRezervaciju()    [Proxy  — invalidates cache, fires DataChanged]
  → DataBaseFacade.dodajRezervaciju()   [Facade — delegates to repository]
  → RezervacijaRepository.Add()         [Repository — builds and runs SQL]
  → DataBaseAdapter.izvrsiUpitBezRezultata()
  → MySqlFactory / MsSqlFactory         [Abstract Factory — creates the right ADO.NET objects]
```

---

## Design Patterns

The project implements **10 design patterns** across all layers.

| # | Pattern | Category | Key Classes |
|---|---------|----------|-------------|
| 1 | **Abstract Factory** | Creational | `IDataBaseFactory`, `MySqlFactory`, `MsSqlFactory` |
| 2 | **Adapter** | Structural | `ISqlSyntaxAdapter`, `MySqlSyntaxAdapter`, `MsSqlSyntaxAdapter` |
| 3 | **Singleton** | Creational | `DataBaseSingleton` (Lazy\<T\>), `AdminSession` (lock) |
| 4 | **Proxy** | Structural | `DataBaseProxy` — cache + Observer timer |
| 5 | **Facade** | Structural | `DataBaseFacade` — wraps 9 repositories |
| 6 | **Repository** | Architectural | `IRepository<T>` + 9 concrete repositories |
| 7 | **Chain of Responsibility** | Behavioral | `RezervacijaHandler` + 3 validators |
| 8 | **Observer** | Behavioral | `DataChanged` event, DB triggers, `change_log` table |
| 9 | **Builder** | Creational | `ResursDirector`, `RadnoMestoBuilder`, `SalaZaSastankeBuilder` |
| 10 | **Strategy** | Behavioral | `PeriodStrategy`, `PeriodType` enum |

### Abstract Factory
`IDataBaseFactory` abstracts the creation of `IDbConnection`, `IDbCommand`, and `IDbDataAdapter`. `MySqlFactory` and `MsSqlFactory` provide provider-specific implementations. The factory also creates an `ISqlSyntaxAdapter` that translates SQL dialect differences (`NOW()` vs `SYSDATETIME()`, `LIMIT 1` vs `FETCH NEXT 1 ROWS ONLY`, etc.), so repositories contain zero provider-specific `if/else` branches.

### Adapter
`ISqlSyntaxAdapter` adapts incompatible SQL syntax between providers. `DataBaseAdapter` stores a reference to the adapter and calls `_syntax.NowExpr()` rather than hardcoding any function name. Used directly in repositories like `LokacijaRepository.GetTrenutnaStatistika()` where `NOW()` / `SYSDATETIME()` must appear inside the query.

### Singleton
`DataBaseSingleton` uses `Lazy<T>` (thread-safe, lazy-initialized) to ensure a single `IDataBase` instance — and therefore a single `DataBaseProxy` with its shared cache and timer — is used by all forms and the Windows Service. `AdminSession` uses a `lock`-based double-checked singleton to hold the currently logged-in admin globally.

### Proxy
`DataBaseProxy` implements `IDataBase` and wraps `DataBaseFacade`. It maintains:
- Simple caches for lists (`cachedClanovi`, `cachedLokacija`, `cachedRezervacije`, `cachedResursi`, `cachedTipClanstva`)
- Dictionary caches for parameterized queries (filtered members, resources by location/type, reservations by date/user)
- Boolean reset flags per entity
- A `System.Timers.Timer` that fires every **10 seconds**, queries `change_log` for new entries, invalidates the relevant cache, and fires the `DataChanged` event

### Facade
`DataBaseFacade` exposes a single `IDataBase` interface (40+ methods) backed by 9 internal repositories. Forms never reference any repository directly. The facade also centralizes cross-cutting logic such as automatically setting reservation status to `Zavrsena` when the end time has passed.

### Repository
`IRepository<T>` defines a standard CRUD contract (`GetAll`, `Add`, `Update`, `Delete`, `GetById`, `GetByName`). Each of the 9 repositories is responsible for exactly one table or entity and contains all SQL for that table. Specialized sub-interface `IRezervacijaRepository` extends the generic one with reservation-specific operations (`Cancel`, `GetByClanIdAndStatuses`, `GetReservationsByDateAndLocation`).

### Chain of Responsibility
Three validators are chained in `DodajRezervaciju` and `IzmeniRezervaciju` forms before any reservation is persisted:

1. **`ZauzetostResursaValidator`** — checks for overlapping active reservations on the same resource
2. **`LimitSatiClanValidator`** — checks whether the member's monthly hour limit would be exceeded
3. **`RadnoVremeLokacijeValidator`** — checks that the reservation falls within the location's working hours

Each handler calls `base.Handle(rezervacija)` to continue the chain, or returns `ValidationResult.Fail(message)` to stop it. Adding a new validation rule means adding a new class — no existing code changes.

### Observer
Three-level event pipeline:
1. **Database level** — 15 AFTER INSERT/UPDATE/DELETE triggers (across 5 entities) write a row to the `change_log` table
2. **Proxy level** — the timer calls `GetChangesAfter(lastCheck)`, invalidates cache for each changed entity, and fires `DataChanged` with the entity type
3. **UI level** — every form subscribes to `DataChanged` and refreshes only when its relevant entity changes; `InvokeRequired + BeginInvoke` ensures thread-safe UI updates from the background timer thread

### Builder
`ResursDirector` drives the construction of complex resource objects. Depending on which radio button the user selects in `DodajResurs`, either `RadnoMestoBuilder` or `SalaZaSastankeBuilder` is instantiated and passed to the director. The form receives the fully constructed object without knowing any construction details.

### Strategy
`PeriodStrategy` encapsulates the algorithm for computing a report start date. The Windows Service reads the desired `PeriodType` from `service_config.txt` and constructs the strategy at runtime — changing the report period requires editing one line in the config file, with no code recompilation.

---

## Project Structure

```
Coworking.sln
├── Coworking.Data/
│   ├── Adapter/            ISqlSyntaxAdapter, MySql/MsSqlSyntaxAdapter
│   ├── Chain_Of_Responsibility/  RezervacijaHandler + 3 validators
│   ├── Factories/          IDataBaseFactory, MySqlFactory, MsSqlFactory
│   ├── Migrations/         MigrationBootstrapper, MigrationRunner, MigrationHistoryRepository
│   ├── Providers/          DataBaseAdapter, DataBaseFacade, DataBaseProxy,
│   │                       DataBaseSingleton, AdminSession, DBSettings, IDataBase
│   ├── Repositories/       IRepository<T> + 9 concrete repositories
│   └── Reports/            PeriodStrategy, PeriodType, CreateReport, CsvExporter
│
├── Coworking.Domain/
│   ├── Entities/           Clan, Lokacija, Resurs, RadnoMesto, SalaZaSastanke,
│   │                       Rezervacija, TipClanstva, Admin, EntityChange, ...
│   └── Enums/              ReservationStatus, PodtipRadnogMesta, DataEntity (+ transformators)
│
├── Coworking.Services/
│   └── Builders/           ResursDirector, RadnoMestoBuilder, SalaZaSastankeBuilder
│
├── Coworking.WinForms/
│   ├── Dashboard, LoginForm
│   ├── Clanovi, Lokacije, Resursi, Rezervacije, TipoviClanstva, AdminNalog
│   └── Dialogues/          DodajClana, DodajLokaciju, DodajResurs, DodajRezervaciju,
│                           DodajTipClanstva, Izmeni*, PromeniLozinku, PromeniUsername, ...
│
└── Coworking.ReportService/
    ├── Worker.cs            BackgroundService implementation
    ├── service_config.txt   Runtime configuration
    ├── install_service.bat
    └── uninstall_service.bat
```

---

## Prerequisites

| Requirement | Version |
|-------------|---------|
| .NET SDK | 8.0+ |
| MySQL Server | 8.0+ **or** MSSQL LocalDB (ships with Visual Studio) |
| Visual Studio | 2022 (or any IDE with .NET 8 support) |
| BCrypt.Net-Next | NuGet package (restored automatically) |
| ReaLTaiizor | NuGet package (restored automatically) |

---

## Getting Started

1. **Clone the repository**
   ```bash
   git clone <repo-url>
   cd coworking
   ```

2. **Configure the database connection** — edit `config.txt` in the output directory (see [Configuration](#configuration))

3. **Build and run**
   ```bash
   dotnet build
   dotnet run --project Coworking.WinForms
   ```
   On first run, the migration system automatically creates the database and all tables.

4. **Log in** — use the credentials of the admin account seeded by the initial migration.

> **Note:** The application detects the database provider automatically from the connection string — `localhost` → MySQL, `MSSQLLocalDB` → MSSQL.

---

## Configuration

### `config.txt` — Main application

Located next to the application executable.

```
CoworkingChain
Server=localhost;Database=coworking;Uid=root;Pwd=;Allow Zero Datetime=True;
```

| Line | Content |
|------|---------|
| 1 | Chain name — displayed in the application title bar |
| 2 | Connection string — provider is auto-detected |

**MySQL connection string:**
```
Server=localhost;Database=coworking;Uid=root;Pwd=;Allow Zero Datetime=True;
```

**MSSQL connection string:**
```
Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CoworkingChain;Integrated Security=True;TrustServerCertificate=True;
```

---

## Database

### Schema

| Table | Purpose |
|-------|---------|
| `schema_migrations` | Tracks applied migration files |
| `admin_korisnik` | Admin accounts with BCrypt-hashed passwords |
| `tip_clanstva` | Membership packages (price, duration, hour limits) |
| `clan` | Members — FK to `tip_clanstva` |
| `lokacija` | Coworking locations (working hours, capacity) |
| `resurs` | Base resource table — FK to `lokacija` |
| `radno_mesto_detalj` | Workstation details (hot_desk / dedicated_desk / private_office) |
| `sala_detalj` | Meeting room details (capacity, projector, TV, whiteboard, online equipment) |
| `rezervacija` | Reservations with status — FK to `clan` and `resurs` |
| `change_log` | Change feed written by DB triggers — drives the Observer mechanism |

### Migrations

SQL migration files live in `migrations/mysql/` and `migrations/mssql/`. Files must follow the naming convention `NNN_description.sql` (e.g. `001_initial.sql`). On startup, `MigrationBootstrapper` applies only migrations not yet recorded in `schema_migrations`, in numeric order.

MySQL files use `DELIMITER //` blocks for triggers; MSSQL files use `GO` batch separators. The `MigrationRunner` handles both automatically.

### Triggers and Observer

Every INSERT, UPDATE, and DELETE on the five tracked entities (`Clan`, `Lokacija`, `Resurs`, `Rezervacija`, `TipClanstva`) fires an AFTER trigger that inserts a row into `change_log`. `DataBaseProxy` polls this table every 10 seconds and notifies all subscribed forms.

### Key SQL dialect differences

| Operation | MySQL | MSSQL |
|-----------|-------|-------|
| Current timestamp | `NOW()` | `SYSDATETIME()` |
| Add days | `DATE_ADD(col, INTERVAL N DAY)` | `DATEADD(day, N, col)` |
| First row | `ORDER BY col DESC LIMIT 1` | `ORDER BY col DESC OFFSET 0 ROWS FETCH NEXT 1 ROWS ONLY` |
| Auto-increment | `AUTO_INCREMENT` | `IDENTITY(1,1)` |

All differences are handled transparently by `ISqlSyntaxAdapter` — no provider checks anywhere in the repository layer.

---

## Windows Service

`Coworking.ReportService` is a .NET Worker Service that runs as a Windows Service and generates CSV reservation reports on a configurable schedule.

### `service_config.txt`

```
Min5
Year1
C:\Reports
```

| Line | Parameter | Available values |
|------|-----------|-----------------|
| 1 | **Interval** — how often a report is generated | `Min5`, `Hour1`, `Hour5`, `Day1`, `Week1`, `Month1`, `Month3`, `Month6`, `Year1` |
| 2 | **PeriodType** — how far back the report covers | same values as above |
| 3 | **OutputFolder** — where CSV files are saved | any valid Windows path |

The service re-reads this file at the start of every cycle, so changes take effect immediately without restarting.

### Installation

Run as **Administrator**:

```bat
install_service.bat
```

This registers `CoworkingReportService` with `start=auto` (starts on Windows boot) and starts it immediately.

### Uninstallation

```bat
uninstall_service.bat
```

Stops and removes the service.

### CSV output format

Files are named `report_YYYY_MM_DD_HH_mm.csv` and written as **UTF-8 with BOM** (Excel-compatible).

```
ClanId,Ime,Prezime,TipClanstva,NazivTipaClanstva,SatiKorisnik,ResursId,NazivResursa,TipResursa
42,"Marko","Petrović",2,"Premium",12.5,7,"Sala A","sala"
```

### Log file

`service.log` is written next to the executable:

```
[INFO]  2025-03-08 14:30:00 - Report generated: C:\Reports\report_2025_03_08_14_30.csv
[ERROR] 2025-03-08 15:00:00 - Could not connect to database: ...
```

---

## Security

### Password hashing

All admin passwords are hashed with **BCrypt** (work factor 11) before being stored. Plain-text passwords are never persisted.

```csharp
// Storing
admin.LozinkaHash = BCrypt.Net.BCrypt.HashPassword(plainText, 11);

// Verifying
bool valid = BCrypt.Net.BCrypt.Verify(plainText, admin.LozinkaHash);
```

### Session management

`AdminSession` (Singleton) holds the currently authenticated admin in memory. It is set on successful login and cleared on logout. Forms read `AdminSession.Instance.TrenutniAdmin` directly — no session tokens or cookies are involved (desktop app).

### Enum-based status values

Reservation statuses and resource subtypes are stored as controlled strings in the database and mapped to/from enums via static transformer classes (`ReservationStatusTransformator`, `PodtipRadnogMestaTransformator`). This eliminates typo-based bugs and makes invalid values a compile-time error rather than a runtime one.
