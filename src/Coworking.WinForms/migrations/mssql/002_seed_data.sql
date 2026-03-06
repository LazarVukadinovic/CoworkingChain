-- ============================================
-- DUMMY PODACI (za testiranje)
-- ============================================
-- 002_seed_data.sql

-- Tipovi članstva
INSERT INTO tip_clanstva (naziv, cena, trajanje_dana, max_sati_mesecno, dozvoljena_sala, sati_sale_mesecno) VALUES
('Basic',      2000.00, 30,  40,  0, 5),
('Premium',    5000.00, 30,  80,  0, 15),
('Gold',      10000.00, 30, 160,  0, 30),
('Enterprise',20000.00, 30, 320,  1, 60)
GO

-- Lokacije
INSERT INTO lokacija (naziv, adresa, grad, radno_vreme, max_kapacitet, opis) VALUES
('Centar Niš',    'Obrenovićeva 10',      'Niš', '08:00 - 22:00', 100, 'Glavna lokacija u centru grada'),
('Nova Lokacija', 'Bulevar Nemanjića 5',  'Niš', '07:00 - 23:00', 150, 'Nova moderna lokacija')
GO

-- Članovi
INSERT INTO clan (ime, prezime, email, telefon, datum_pocetka, datum_kraja, status_naloga, tip_clanstva_id) VALUES
('Marko', 'Marković',  'marko@example.com', '0641234567', '2025-01-01', '2025-02-01', 'Aktivan',   1),
('Petar', 'Petrović',  'petar@example.com', '0649876543', '2025-01-15', '2025-02-15', 'Aktivan',   2),
('Ana',   'Anić',      'ana@example.com',   '0645556677', '2025-02-01', '2025-03-01', 'Aktivan',   3),
('Jovan', 'Jovanović', 'jovan@example.com', '0641112233', '2024-12-01', '2025-01-01', 'Neaktivan', 1)
GO

-- Resursi - Sale (dobijaju resurs_id 1-4)
INSERT INTO resurs (oznaka, tip_resursa, opis, aktivan, lokacija_id) VALUES
('Sala A',   'sala', 'Velika konferencijska sala', 1, 1),
('Sala B',   'sala', 'Srednja sala za sastanke',   1, 1),
('Sala C',   'sala', 'Mala sala za intervjue',     1, 1),
('VIP Sala', 'sala', 'Premium sala sa svom opremom', 1, 2)
GO

-- Detalji sala
INSERT INTO sala_detalj (resurs_id, kapacitet, ima_projektor, ima_tv, ima_tablu, ima_online_opremu) VALUES
(1, 50, 1, 1, 1, 1),
(2, 20, 1, 0, 1, 1),
(3, 10, 0, 1, 1, 0),
(4, 30, 1, 1, 1, 1)
GO

-- Resursi - Radna mesta (dobijaju resurs_id 5-10)
INSERT INTO resurs (oznaka, tip_resursa, opis, aktivan, lokacija_id) VALUES
('Hot Desk 1',       'radno_mesto', 'Fleksibilno radno mesto - zona A', 1, 1),
('Hot Desk 2',       'radno_mesto', 'Fleksibilno radno mesto - zona A', 1, 1),
('Hot Desk 3',       'radno_mesto', 'Fleksibilno radno mesto - zona B', 1, 1),
('Dedicated Desk 1', 'radno_mesto', 'Fiksno radno mesto - zona C',      1, 1),
('Dedicated Desk 2', 'radno_mesto', 'Fiksno radno mesto - zona C',      1, 1),
('Private Office 1', 'radno_mesto', 'Privatna kancelarija',             1, 2)
GO

-- Detalji radnih mesta
INSERT INTO radno_mesto_detalj (resurs_id, podtip) VALUES
(5,  'hot_desk'),
(6,  'hot_desk'),
(7,  'hot_desk'),
(8,  'dedicated_desk'),
(9,  'dedicated_desk'),
(10, 'private_office')
GO

-- Rezervacije
INSERT INTO rezervacija (pocetak, kraj, status, clan_id, resurs_id) VALUES
('2026-03-16 10:00:00', '2026-03-18 12:00:00', 'Rezervisana', 1, 1),
('2025-02-16 14:00:00', '2025-02-16 16:00:00', 'Rezervisana', 2, 1),
('2025-02-16 09:00:00', '2025-02-16 17:00:00', 'Rezervisana', 3, 5),
('2026-03-29 10:00:00', '2026-04-01 12:00:00', 'Rezervisana', 1, 2),
('2025-02-15 10:00:00', '2025-02-15 12:00:00', 'Zavrsena',    2, 3)
GO