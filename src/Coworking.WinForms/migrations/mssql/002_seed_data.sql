-- ============================================
-- DUMMY PODACI (za testiranje)
-- ============================================
-- 002_seed_data.sql

-- Admin korisnici
INSERT INTO dbo.admin_korisnik (korisnicko_ime, lozinka_hash) VALUES
('admin', 'hash123'),
('manager', 'hash456')

-- Tipovi clanstva
INSERT INTO dbo.tip_clanstva (naziv, cena, trajanje_dana, max_sati_mesecno, dozvoljena_sala, sati_sale_mesecno) VALUES
('Basic', 2000.00, 30, 40, 'Standardna sala', 5),
('Premium', 5000.00, 30, 80, 'Premium sala', 15),
('Gold', 10000.00, 30, 160, 'VIP sala', 30),
('Enterprise', 20000.00, 30, 320, 'Sve sale', 60)

-- Lokacije
INSERT INTO dbo.lokacija (naziv, adresa, grad, radno_vreme, max_kapacitet, opis) VALUES
('Centar Nis', 'Obrenoviceva 10', 'Nis', '08:00 - 22:00', 100, 'Glavna lokacija u centru grada'),
('Nova Lokacija', 'Bulevar Nemanjica 5', 'Nis', '07:00 - 23:00', 150, 'Nova moderna lokacija')

-- Clanovi
INSERT INTO dbo.clan (ime, prezime, email, telefon, datum_pocetka, datum_kraja, status_naloga, tip_clanstva_id) VALUES
('Marko', 'Markovic', 'marko@example.com', '0641234567', '2025-01-01', '2025-02-01', 'Aktivan', 1),
('Petar', 'Petrovic', 'petar@example.com', '0649876543', '2025-01-15', '2025-02-15', 'Aktivan', 2),
('Ana', 'Anic', 'ana@example.com', '0645556677', '2025-02-01', '2025-03-01', 'Aktivan', 3),
('Jovan', 'Jovanovic', 'jovan@example.com', '0641112233', '2024-12-01', '2025-01-01', 'Neaktivan', 1)

-- Resursi - Sale
INSERT INTO dbo.resurs (oznaka, tip_resursa, opis, aktivan, lokacija_id) VALUES
('Sala A', 'sala', 'Velika konferencijska sala', 1, 1),
('Sala B', 'sala', 'Srednja sala za sastanke', 1, 1),
('Sala C', 'sala', 'Mala sala za intervjue', 1, 1),
('VIP Sala', 'sala', 'Premium sala sa svom opremom', 1, 2)

-- Detalji sala
INSERT INTO dbo.sala_detalj (resurs_id, kapacitet, ima_projektor, ima_tv, ima_tablu, ima_online_opremu) VALUES
(1, 50, 1, 1, 1, 1),
(2, 20, 1, 0, 1, 1),
(3, 10, 0, 1, 1, 0),
(4, 30, 1, 1, 1, 1)

-- Resursi - Radna mesta
INSERT INTO dbo.resurs (oznaka, tip_resursa, opis, aktivan, lokacija_id) VALUES
('Hot Desk 1', 'radno_mesto', 'Fleksibilno radno mesto - zona A', 1, 1),
('Hot Desk 2', 'radno_mesto', 'Fleksibilno radno mesto - zona A', 1, 1),
('Hot Desk 3', 'radno_mesto', 'Fleksibilno radno mesto - zona B', 1, 1),
('Dedicated Desk 1', 'radno_mesto', 'Fiksno radno mesto - zona C', 1, 1),
('Dedicated Desk 2', 'radno_mesto', 'Fiksno radno mesto - zona C', 1, 1),
('Private Office 1', 'radno_mesto', 'Privatna kancelarija', 1, 2)

-- Detalji radnih mesta
INSERT INTO dbo.radno_mesto_detalj (resurs_id, podtip) VALUES
(5, 'hot_desk'),
(6, 'hot_desk'),
(7, 'hot_desk'),
(8, 'dedicated_desk'),
(9, 'dedicated_desk'),
(10, 'private_office')

-- Rezervacije
INSERT INTO dbo.rezervacija (pocetak, kraj, status, clan_id, resurs_id) VALUES
('2025-02-16 10:00:00', '2025-02-16 12:00:00', 'Rezervisana', 1, 1),
('2025-02-16 14:00:00', '2025-02-16 16:00:00', 'Rezervisana', 2, 1),
('2025-02-16 09:00:00', '2025-02-16 17:00:00', 'Rezervisana', 3, 5),
('2025-02-17 10:00:00', '2025-02-17 12:00:00', 'Rezervisana', 1, 2),
('2025-02-15 10:00:00', '2025-02-15 12:00:00', 'Zavrsena', 2, 3)
