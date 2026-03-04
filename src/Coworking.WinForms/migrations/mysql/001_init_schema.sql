-- ============================================
-- SISTEM ZA REZERVACIJU SALA I RADNIH MESTA
-- MySQL Database Script
-- ============================================
-- 001_init_schema.sql

-- 0) Istorija migracija
CREATE TABLE IF NOT EXISTS schema_migrations (
  id INT AUTO_INCREMENT PRIMARY KEY,
  filename VARCHAR(255) NOT NULL UNIQUE,
  applied_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
);

-- 1. ADMIN KORISNIK
CREATE TABLE IF NOT EXISTS admin_korisnik (
    admin_id INT PRIMARY KEY AUTO_INCREMENT,
    korisnicko_ime VARCHAR(100) NOT NULL UNIQUE,
    lozinka_hash VARCHAR(255) NOT NULL,
    kreiran_u DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    INDEX idx_korisnicko_ime (korisnicko_ime) -- Uklonjen zarez ovde
);

-- 2. TIP ČLANSTVA
CREATE TABLE IF NOT EXISTS tip_clanstva (
    tip_clanstva_id INT PRIMARY KEY AUTO_INCREMENT,
    naziv VARCHAR(100) NOT NULL UNIQUE,
    cena DECIMAL(10, 2) NOT NULL CHECK (cena >= 0),
    trajanje_dana INT NOT NULL CHECK (trajanje_dana > 0),
    max_sati_mesecno INT NOT NULL CHECK (max_sati_mesecno > 0),
    dozvoljena_sala TINYINT(1),
    sati_sale_mesecno INT NOT NULL DEFAULT 0,
    INDEX idx_naziv (naziv)
);

-- 3. ČLAN
CREATE TABLE IF NOT EXISTS clan (
    clan_id INT PRIMARY KEY AUTO_INCREMENT,
    ime VARCHAR(100) NOT NULL,
    prezime VARCHAR(100) NOT NULL,
    email VARCHAR(255) NOT NULL UNIQUE,
    telefon VARCHAR(20),
    datum_pocetka DATE NOT NULL,
    datum_kraja DATE NOT NULL,
    status_naloga ENUM('Aktivan', 'Neaktivan', 'Suspendovan') NOT NULL DEFAULT 'Aktivan',
    tip_clanstva_id INT NOT NULL,
    kreiran_u DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (tip_clanstva_id) REFERENCES tip_clanstva(tip_clanstva_id),
    INDEX idx_email (email),
    INDEX idx_status (status_naloga),
    INDEX idx_tip_clanstva (tip_clanstva_id),
    INDEX idx_ime_prezime (ime, prezime),
    CONSTRAINT chk_datum CHECK (datum_kraja >= datum_pocetka)
);

-- 4. LOKACIJA
CREATE TABLE IF NOT EXISTS lokacija (
    lokacija_id INT PRIMARY KEY AUTO_INCREMENT,
    naziv VARCHAR(255) NOT NULL,
    adresa VARCHAR(500) NOT NULL,
    grad VARCHAR(100) NOT NULL,
    radno_vreme VARCHAR(100),
    max_kapacitet INT NOT NULL DEFAULT 0,
    opis TEXT,
    INDEX idx_grad (grad),
    INDEX idx_naziv (naziv)
);

-- 5. RESURS
CREATE TABLE IF NOT EXISTS resurs (
    resurs_id INT PRIMARY KEY AUTO_INCREMENT,
    oznaka VARCHAR(100) NOT NULL,
    tip_resursa ENUM('sala', 'radno_mesto') NOT NULL,
    opis TEXT,
    aktivan BIT NOT NULL DEFAULT 1,
    lokacija_id INT NOT NULL,
    kreiran_u DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (lokacija_id) REFERENCES lokacija(lokacija_id),
    INDEX idx_tip_resursa (tip_resursa),
    INDEX idx_lokacija (lokacija_id),
    INDEX idx_aktivan (aktivan),
    INDEX idx_oznaka (oznaka)
);

-- 6. SALA DETALJ
CREATE TABLE IF NOT EXISTS sala_detalj (
    sala_detalj_id INT PRIMARY KEY AUTO_INCREMENT,
    resurs_id INT UNIQUE NOT NULL,
    kapacitet INT NOT NULL CHECK (kapacitet > 0),
    ima_projektor BIT NOT NULL DEFAULT 0,
    ima_tv BIT NOT NULL DEFAULT 0,
    ima_tablu BIT NOT NULL DEFAULT 0,
    ima_online_opremu BIT NOT NULL DEFAULT 0,
    FOREIGN KEY (resurs_id) REFERENCES resurs(resurs_id) ON DELETE CASCADE,
    INDEX idx_kapacitet (kapacitet)
);

-- 7. RADNO MESTO DETALJ
CREATE TABLE IF NOT EXISTS radno_mesto_detalj (
    radno_mesto_id INT PRIMARY KEY AUTO_INCREMENT,
    resurs_id INT UNIQUE NOT NULL,
    podtip ENUM('hot_desk', 'dedicated_desk', 'private_office') NOT NULL,
    FOREIGN KEY (resurs_id) REFERENCES resurs(resurs_id) ON DELETE CASCADE,
    INDEX idx_podtip (podtip)
);

-- 8. REZERVACIJA
CREATE TABLE IF NOT EXISTS rezervacija (
    rezervacija_id INT PRIMARY KEY AUTO_INCREMENT,
    pocetak DATETIME NOT NULL,
    kraj DATETIME NOT NULL,
    status ENUM('Rezervisana', 'Potvrdjena', 'Otkazana', 'Zavrsena') NOT NULL DEFAULT 'Rezervisana',
    kreirano_u DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    otkazano_u DATETIME NULL,
    clan_id INT NOT NULL,
    resurs_id INT NOT NULL,
    FOREIGN KEY (clan_id) REFERENCES clan(clan_id),
    FOREIGN KEY (resurs_id) REFERENCES resurs(resurs_id),
    INDEX idx_clan (clan_id),
    INDEX idx_resurs (resurs_id),
    INDEX idx_status (status),
    INDEX idx_pocetak (pocetak),
    INDEX idx_kraj (kraj),
    INDEX idx_datum_range (pocetak, kraj),
    CONSTRAINT chk_kraj_pocetak CHECK (kraj > pocetak)
);
