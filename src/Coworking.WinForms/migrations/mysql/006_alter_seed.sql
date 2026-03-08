-- ============================================
-- 006_alter_seed.sql
-- Cleanup pokvarenih datuma
-- ============================================

UPDATE rezervacija SET kreirano_u = NOW()  WHERE kreirano_u = '0000-00-00 00:00:00';
UPDATE rezervacija SET otkazano_u = NULL   WHERE otkazano_u = '0000-00-00 00:00:00';
