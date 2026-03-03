-- ============================================
-- SISTEM ZA REZERVACIJU SALA I RADNIH MESTA
-- Optimizovano za C# Migracije (Bez GO)
-- ============================================

-------------------------------------------------
-- 0) MIGRACIJE
-------------------------------------------------
IF OBJECT_ID(N'dbo.schema_migrations', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.schema_migrations (
        id INT IDENTITY(1,1) PRIMARY KEY,
        filename NVARCHAR(255) NOT NULL UNIQUE,
        applied_at DATETIME NOT NULL DEFAULT GETDATE()
    )
END

-------------------------------------------------
-- 1) ADMIN
-------------------------------------------------
IF OBJECT_ID(N'dbo.admin_korisnik', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.admin_korisnik (
        admin_id INT IDENTITY(1,1) PRIMARY KEY,
        korisnicko_ime NVARCHAR(100) NOT NULL UNIQUE,
        lozinka_hash NVARCHAR(255) NOT NULL,
        lozinka_salt NVARCHAR(255) NOT NULL,
        aktivan BIT NOT NULL DEFAULT 1,
        kreiran_u DATETIME NOT NULL DEFAULT GETDATE()
    )
END

-------------------------------------------------
-- 2) TIP CLANSTVA
-------------------------------------------------
IF OBJECT_ID(N'dbo.tip_clanstva', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tip_clanstva (
        tip_clanstva_id INT IDENTITY(1,1) PRIMARY KEY,
        naziv NVARCHAR(100) NOT NULL UNIQUE,
        cena DECIMAL(10,2) NOT NULL,
        trajanje_dana INT NOT NULL,
        max_sati_mesecno INT NOT NULL,
        dozvoljena_sala NVARCHAR(255),
        sati_sale_mesecno INT NOT NULL DEFAULT 0
    )
END

-------------------------------------------------
-- 3) CLAN
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
        FOREIGN KEY (tip_clanstva_id) REFERENCES dbo.tip_clanstva(tip_clanstva_id)
    )
END

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
END

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
        FOREIGN KEY (lokacija_id) REFERENCES dbo.lokacija(lokacija_id)
    )
END

-------------------------------------------------
-- 6) SALA DETALJ
-------------------------------------------------
IF OBJECT_ID(N'dbo.sala_detalj', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.sala_detalj (
        sala_detalj_id INT IDENTITY(1,1) PRIMARY KEY,
        resurs_id INT UNIQUE NOT NULL,
        kapacitet INT NOT NULL,
        ima_projektor BIT NOT NULL DEFAULT 0,
        ima_tv BIT NOT NULL DEFAULT 0,
        ima_tablu BIT NOT NULL DEFAULT 0,
        ima_online_opremu BIT NOT NULL DEFAULT 0,
        FOREIGN KEY (resurs_id) REFERENCES dbo.resurs(resurs_id) ON DELETE CASCADE
    )
END

-------------------------------------------------
-- 7) RADNO MESTO DETALJ
-------------------------------------------------
IF OBJECT_ID(N'dbo.radno_mesto_detalj', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.radno_mesto_detalj (
        radno_mesto_id INT IDENTITY(1,1) PRIMARY KEY,
        resurs_id INT UNIQUE NOT NULL,
        podtip NVARCHAR(20) NOT NULL,
        FOREIGN KEY (resurs_id) REFERENCES dbo.resurs(resurs_id) ON DELETE CASCADE
    )
END

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
        FOREIGN KEY (resurs_id) REFERENCES dbo.resurs(resurs_id)
    )
END
