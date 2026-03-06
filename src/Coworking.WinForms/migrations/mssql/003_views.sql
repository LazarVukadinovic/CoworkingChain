-- ============================================
-- KORISNI VIEW-ovi
-- ============================================
-- 003_views.sql

IF OBJECT_ID(N'dbo.view_sale', N'V') IS NOT NULL
    DROP VIEW dbo.view_sale
GO

IF OBJECT_ID(N'dbo.view_radna_mesta', N'V') IS NOT NULL
    DROP VIEW dbo.view_radna_mesta
GO

IF OBJECT_ID(N'dbo.view_aktivne_rezervacije', N'V') IS NOT NULL
    DROP VIEW dbo.view_aktivne_rezervacije
GO

-- View za sve sale sa detaljima
CREATE VIEW view_sale AS
SELECT 
    r.resurs_id,
    r.oznaka,
    r.opis,
    r.aktivan,
    l.naziv AS lokacija_naziv,
    l.adresa,
    l.grad,
    sd.kapacitet,
    sd.ima_projektor,
    sd.ima_tv,
    sd.ima_tablu,
    sd.ima_online_opremu
FROM resurs r
JOIN lokacija l ON r.lokacija_id = l.lokacija_id
JOIN sala_detalj sd ON r.resurs_id = sd.resurs_id
WHERE r.tip_resursa = 'sala'
GO

-- View za sva radna mesta sa detaljima
CREATE VIEW view_radna_mesta AS
SELECT 
    r.resurs_id,
    r.oznaka,
    r.opis,
    r.aktivan,
    l.naziv AS lokacija_naziv,
    l.adresa,
    l.grad,
    rmd.podtip
FROM resurs r
JOIN lokacija l ON r.lokacija_id = l.lokacija_id
JOIN radno_mesto_detalj rmd ON r.resurs_id = rmd.resurs_id
WHERE r.tip_resursa = 'radno_mesto'
GO

-- View za aktivne rezervacije sa detaljima
CREATE VIEW view_aktivne_rezervacije AS
SELECT 
    rez.rezervacija_id,
    rez.pocetak,
    rez.kraj,
    rez.status,
    CONCAT(c.ime, ' ', c.prezime) AS clan_ime,
    c.email AS clan_email,
    r.oznaka AS resurs_oznaka,
    r.tip_resursa,
    l.naziv AS lokacija_naziv,
    tc.naziv AS tip_clanstva
FROM rezervacija rez
JOIN clan c ON rez.clan_id = c.clan_id
JOIN resurs r ON rez.resurs_id = r.resurs_id
JOIN lokacija l ON r.lokacija_id = l.lokacija_id
JOIN tip_clanstva tc ON c.tip_clanstva_id = tc.tip_clanstva_id
WHERE rez.status IN ('Rezervisana', 'Potvrdjena')
GO