-- ============================================
-- SISTEM ZA REZERVACIJU SALA I RADNIH MESTA
-- MSSQL Database Script
-- ============================================

-------------------------------------------------
-- 0) ISTORIJA MIGRACIJA
-------------------------------------------------
IF OBJECT_ID(N'dbo.schema_migrations', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.schema_migrations (
        id INT IDENTITY(1,1) PRIMARY KEY,
        filename NVARCHAR(255) NOT NULL UNIQUE,
        applied_at DATETIME NOT NULL DEFAULT GETDATE()
    )
END
GO

-------------------------------------------------
-- 1) ADMIN KORISNIK
-------------------------------------------------
IF OBJECT_ID(N'dbo.admin_korisnik', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.admin_korisnik (
        admin_id INT IDENTITY(1,1) PRIMARY KEY,
        korisnicko_ime NVARCHAR(100) NOT NULL UNIQUE,
        lozinka_hash NVARCHAR(255) NOT NULL,
        kreiran_u DATETIME NOT NULL DEFAULT GETDATE()
    )
    CREATE INDEX idx_korisnicko_ime ON dbo.admin_korisnik(korisnicko_ime)
END
GO

-------------------------------------------------
-- 2) TIP ČLANSTVA
-------------------------------------------------
IF OBJECT_ID(N'dbo.tip_clanstva', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tip_clanstva (
        tip_clanstva_id INT IDENTITY(1,1) PRIMARY KEY,
        naziv NVARCHAR(100) NOT NULL UNIQUE,
        cena DECIMAL(10, 2) NOT NULL CHECK (cena >= 0),
        trajanje_dana INT NOT NULL CHECK (trajanje_dana > 0),
        max_sati_mesecno INT NOT NULL CHECK (max_sati_mesecno > 0),
        dozvoljena_sala TINYINT, -- TINYINT odgovara MySQL TINYINT(1)
        sati_sale_mesecno INT NOT NULL DEFAULT 0
    )
    CREATE INDEX idx_naziv_tip ON dbo.tip_clanstva(naziv)
END
GO

-------------------------------------------------
-- 3) ČLAN
-------------------------------------------------
IF OBJECT_ID(N'dbo.clan', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.clan (
        clan_id INT IDENTITY(1,1) PRIMARY KEY,
        ime NVARCHAR(100) NOT NULL,
        prezime NVARCHAR(100) NOT NULL,
        email NVARCHAR(255) NOT NULL UNIQUE,
        telefon NVARCHAR(20),
        datum_pocetka DATE NOT NULL,
        datum_kraja DATE NOT NULL,
        status_naloga NVARCHAR(20) NOT NULL DEFAULT 'Aktivan',
        tip_clanstva_id INT NOT NULL,
        kreiran_u DATETIME NOT NULL DEFAULT GETDATE(),
        FOREIGN KEY (tip_clanstva_id) REFERENCES dbo.tip_clanstva(tip_clanstva_id),
        CONSTRAINT chk_datum CHECK (datum_kraja >= datum_pocetka),
        CONSTRAINT chk_status_clan CHECK (status_naloga IN ('Aktivan', 'Neaktivan', 'Suspendovan'))
    )
    CREATE INDEX idx_email ON dbo.clan(email)
    CREATE INDEX idx_status ON dbo.clan(status_naloga)
    CREATE INDEX idx_tip_clanstva ON dbo.clan(tip_clanstva_id)
    CREATE INDEX idx_ime_prezime ON dbo.clan(ime, prezime)
END
GO

-------------------------------------------------
-- 4) LOKACIJA
-------------------------------------------------
IF OBJECT_ID(N'dbo.lokacija', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.lokacija (
        lokacija_id INT IDENTITY(1,1) PRIMARY KEY,
        naziv NVARCHAR(255) NOT NULL,
        adresa NVARCHAR(500) NOT NULL,
        grad NVARCHAR(100) NOT NULL,
        radno_vreme NVARCHAR(100),
        max_kapacitet INT NOT NULL DEFAULT 0,
        opis NVARCHAR(MAX)
    )
    CREATE INDEX idx_grad ON dbo.lokacija(grad)
    CREATE INDEX idx_naziv_lok ON dbo.lokacija(naziv)
END
GO

-------------------------------------------------
-- 5) RESURS
-------------------------------------------------
IF OBJECT_ID(N'dbo.resurs', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.resurs (
        resurs_id INT IDENTITY(1,1) PRIMARY KEY,
        oznaka NVARCHAR(100) NOT NULL,
        tip_resursa NVARCHAR(20) NOT NULL,
        opis NVARCHAR(MAX),
        aktivan BIT NOT NULL DEFAULT 1,
        lokacija_id INT NOT NULL,
        kreiran_u DATETIME NOT NULL DEFAULT GETDATE(),
        FOREIGN KEY (lokacija_id) REFERENCES dbo.lokacija(lokacija_id),
        CONSTRAINT chk_tip_resursa CHECK (tip_resursa IN ('sala', 'radno_mesto'))
    )
    CREATE INDEX idx_tip_resursa ON dbo.resurs(tip_resursa)
    CREATE INDEX idx_lokacija ON dbo.resurs(lokacija_id)
    CREATE INDEX idx_oznaka ON dbo.resurs(oznaka)
    CREATE INDEX idx_aktivan ON dbo.resurs(aktivan)
END
GO

-------------------------------------------------
-- 6) SALA DETALJ
-------------------------------------------------
IF OBJECT_ID(N'dbo.sala_detalj', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.sala_detalj (
        sala_detalj_id INT IDENTITY(1,1) PRIMARY KEY,
        resurs_id INT UNIQUE NOT NULL,
        kapacitet INT NOT NULL CHECK (kapacitet > 0),
        ima_projektor BIT NOT NULL DEFAULT 0,
        ima_tv BIT NOT NULL DEFAULT 0,
        ima_tablu BIT NOT NULL DEFAULT 0,
        ima_online_opremu BIT NOT NULL DEFAULT 0,
        FOREIGN KEY (resurs_id) REFERENCES dbo.resurs(resurs_id) ON DELETE CASCADE
    )
    CREATE INDEX idx_kapacitet ON dbo.sala_detalj(kapacitet)
END
GO

-------------------------------------------------
-- 7) RADNO MESTO DETALJ
-------------------------------------------------
IF OBJECT_ID(N'dbo.radno_mesto_detalj', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.radno_mesto_detalj (
        radno_mesto_id INT IDENTITY(1,1) PRIMARY KEY,
        resurs_id INT UNIQUE NOT NULL,
        podtip NVARCHAR(20) NOT NULL,
        FOREIGN KEY (resurs_id) REFERENCES dbo.resurs(resurs_id) ON DELETE CASCADE,
        CONSTRAINT chk_podtip CHECK (podtip IN ('hot_desk', 'dedicated_desk', 'private_office'))
    )
    CREATE INDEX idx_podtip ON dbo.radno_mesto_detalj(podtip)
END
GO

-------------------------------------------------
-- 8) REZERVACIJA
-------------------------------------------------
IF OBJECT_ID(N'dbo.rezervacija', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.rezervacija (
        rezervacija_id INT IDENTITY(1,1) PRIMARY KEY,
        pocetak DATETIME NOT NULL,
        kraj DATETIME NOT NULL,
        status NVARCHAR(20) NOT NULL DEFAULT 'Rezervisana',
        kreirano_u DATETIME NOT NULL DEFAULT GETDATE(),
        otkazano_u DATETIME NULL,
        clan_id INT NOT NULL,
        resurs_id INT NOT NULL,
        FOREIGN KEY (clan_id) REFERENCES dbo.clan(clan_id),
        FOREIGN KEY (resurs_id) REFERENCES dbo.resurs(resurs_id),
        CONSTRAINT chk_kraj_pocetak CHECK (kraj > pocetak),
        CONSTRAINT chk_status_rez CHECK (status IN ('Rezervisana', 'Potvrdjena', 'Otkazana', 'Zavrsena'))
    )
    CREATE INDEX idx_clan ON dbo.rezervacija(clan_id)
    CREATE INDEX idx_resurs ON dbo.rezervacija(resurs_id)
    CREATE INDEX idx_status_rez ON dbo.rezervacija(status)
    CREATE INDEX idx_datum_range ON dbo.rezervacija(pocetak, kraj)
    CREATE INDEX idx_pocetak ON dbo.rezervacija(pocetak)
    CREATE INDEX idx_kraj ON dbo.rezervacija(kraj)
END
GO
-------------------------------------------------
-- 9)Tabela za observer
-------------------------------------------------
IF OBJECT_ID(N'dbo.change_log', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.change_log (
    id INT IDENTITY(1,1) PRIMARY KEY,
    entity_name VARCHAR(50),
    change_time DATETIME
);
END
GO

