-- reset.sql
-- RESET baze (manual only) - sve briše!

DROP PROCEDURE IF EXISTS sp_proveri_dostupnost;

DROP VIEW IF EXISTS view_aktivne_rezervacije;
DROP VIEW IF EXISTS view_radna_mesta;
DROP VIEW IF EXISTS view_sale;

DROP TABLE IF EXISTS rezervacija;
DROP TABLE IF EXISTS sala_detalj;
DROP TABLE IF EXISTS radno_mesto_detalj;
DROP TABLE IF EXISTS resurs;
DROP TABLE IF EXISTS clan;
DROP TABLE IF EXISTS tip_clanstva;
DROP TABLE IF EXISTS lokacija;
DROP TABLE IF EXISTS admin_korisnik;

DROP TABLE IF EXISTS schema_migrations;

SELECT 'RESET DONE' AS Status;
