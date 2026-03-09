-- reset.sql
-- RESET baze (manual only) - sve brise!

IF OBJECT_ID(N'dbo.sp_proveri_dostupnost', N'P') IS NOT NULL DROP PROCEDURE dbo.sp_proveri_dostupnost

IF OBJECT_ID(N'dbo.view_aktivne_rezervacije', N'V') IS NOT NULL DROP VIEW dbo.view_aktivne_rezervacije
IF OBJECT_ID(N'dbo.view_radna_mesta', N'V') IS NOT NULL DROP VIEW dbo.view_radna_mesta
IF OBJECT_ID(N'dbo.view_sale', N'V') IS NOT NULL DROP VIEW dbo.view_sale

IF OBJECT_ID(N'dbo.rezervacija', N'U') IS NOT NULL DROP TABLE dbo.rezervacija
IF OBJECT_ID(N'dbo.sala_detalj', N'U') IS NOT NULL DROP TABLE dbo.sala_detalj
IF OBJECT_ID(N'dbo.radno_mesto_detalj', N'U') IS NOT NULL DROP TABLE dbo.radno_mesto_detalj
IF OBJECT_ID(N'dbo.resurs', N'U') IS NOT NULL DROP TABLE dbo.resurs
IF OBJECT_ID(N'dbo.clan', N'U') IS NOT NULL DROP TABLE dbo.clan
IF OBJECT_ID(N'dbo.tip_clanstva', N'U') IS NOT NULL DROP TABLE dbo.tip_clanstva
IF OBJECT_ID(N'dbo.lokacija', N'U') IS NOT NULL DROP TABLE dbo.lokacija
IF OBJECT_ID(N'dbo.admin_korisnik', N'U') IS NOT NULL DROP TABLE dbo.admin_korisnik
IF OBJECT_ID(N'dbo.schema_migrations', N'U') IS NOT NULL DROP TABLE dbo.schema_migrations

SELECT 'RESET DONE' AS Status
