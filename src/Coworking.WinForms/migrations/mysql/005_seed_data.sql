-- ============================================
-- 005_seed_mesec.sql
-- Rezervacije - poslednjih mesec dana
-- Period: 2026-02-06 do 2026-03-08
-- ============================================

-- Marko (clan_id=1) - Sale
INSERT INTO rezervacija (pocetak, kraj, status, clan_id, resurs_id) VALUES
('2026-02-06 10:00:00', '2026-02-06 12:00:00', 'Zavrsena',    1, 1),
('2026-02-10 09:00:00', '2026-02-10 13:00:00', 'Zavrsena',    1, 2),
('2026-02-14 14:00:00', '2026-02-14 16:00:00', 'Zavrsena',    1, 1),
('2026-02-18 10:00:00', '2026-02-18 14:00:00', 'Zavrsena',    1, 3),
('2026-02-22 09:00:00', '2026-02-22 17:00:00', 'Zavrsena',    1, 4),
('2026-02-26 10:00:00', '2026-02-26 12:00:00', 'Zavrsena',    1, 2),
('2026-03-02 09:00:00', '2026-03-02 11:00:00', 'Zavrsena',    1, 1),
('2026-03-05 14:00:00', '2026-03-05 16:00:00', 'Rezervisana', 1, 3);

-- Marko (clan_id=1) - Radna mesta
INSERT INTO rezervacija (pocetak, kraj, status, clan_id, resurs_id) VALUES
('2026-02-08 08:00:00', '2026-02-08 17:00:00', 'Zavrsena', 1, 5),
('2026-02-20 08:00:00', '2026-02-20 17:00:00', 'Zavrsena', 1, 8),
('2026-03-04 08:00:00', '2026-03-04 17:00:00', 'Zavrsena', 1, 5);

-- Petar (clan_id=2) - Sale
INSERT INTO rezervacija (pocetak, kraj, status, clan_id, resurs_id) VALUES
('2026-02-07 10:00:00', '2026-02-07 12:00:00', 'Zavrsena',    2, 2),
('2026-02-13 09:00:00', '2026-02-13 11:00:00', 'Zavrsena',    2, 1),
('2026-02-19 14:00:00', '2026-02-19 18:00:00', 'Zavrsena',    2, 3),
('2026-02-25 10:00:00', '2026-02-25 12:00:00', 'Zavrsena',    2, 2),
('2026-03-03 09:00:00', '2026-03-03 13:00:00', 'Zavrsena',    2, 4),
('2026-03-06 10:00:00', '2026-03-06 12:00:00', 'Rezervisana', 2, 1);

-- Petar (clan_id=2) - Radna mesta
INSERT INTO rezervacija (pocetak, kraj, status, clan_id, resurs_id) VALUES
('2026-02-09 08:00:00', '2026-02-09 17:00:00', 'Zavrsena', 2, 6),
('2026-02-23 08:00:00', '2026-02-23 17:00:00', 'Zavrsena', 2, 9);

-- Ana (clan_id=3) - Sale
INSERT INTO rezervacija (pocetak, kraj, status, clan_id, resurs_id) VALUES
('2026-02-11 10:00:00', '2026-02-11 14:00:00', 'Zavrsena',    3, 3),
('2026-02-17 09:00:00', '2026-02-17 11:00:00', 'Zavrsena',    3, 1),
('2026-02-24 14:00:00', '2026-02-24 16:00:00', 'Zavrsena',    3, 2),
('2026-03-01 10:00:00', '2026-03-01 12:00:00', 'Zavrsena',    3, 3),
('2026-03-05 09:00:00', '2026-03-05 11:00:00', 'Rezervisana', 3, 4);

-- Ana (clan_id=3) - Radna mesta
INSERT INTO rezervacija (pocetak, kraj, status, clan_id, resurs_id) VALUES
('2026-02-12 08:00:00', '2026-02-12 17:00:00', 'Zavrsena', 3,  7),
('2026-02-28 08:00:00', '2026-02-28 17:00:00', 'Zavrsena', 3, 10);

-- Jovan (clan_id=4) - Sale (Neaktivan, ali ima starih rezervacija)
INSERT INTO rezervacija (pocetak, kraj, status, clan_id, resurs_id) VALUES
('2026-02-09 10:00:00', '2026-02-09 12:00:00', 'Otkazana', 4, 1),
('2026-02-15 14:00:00', '2026-02-15 16:00:00', 'Zavrsena', 4, 2);