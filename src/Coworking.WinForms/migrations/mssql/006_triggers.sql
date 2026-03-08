-------------------------------------------------
-- 006_triggers.sql
-------------------------------------------------

IF OBJECT_ID('clan_change_trigger', 'TR') IS NOT NULL
    DROP TRIGGER clan_change_trigger
GO
CREATE TRIGGER clan_change_trigger
ON dbo.clan
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO dbo.change_log(entity_name, change_time)
    VALUES ('Clan', GETDATE())
END
GO

IF OBJECT_ID('lokacija_change_trigger', 'TR') IS NOT NULL
    DROP TRIGGER lokacija_change_trigger
GO
CREATE TRIGGER lokacija_change_trigger
ON dbo.lokacija
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO dbo.change_log(entity_name, change_time)
    VALUES ('Lokacija', GETDATE())
END
GO

IF OBJECT_ID('resurs_change_trigger', 'TR') IS NOT NULL
    DROP TRIGGER resurs_change_trigger
GO
CREATE TRIGGER resurs_change_trigger
ON dbo.resurs
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO dbo.change_log(entity_name, change_time)
    VALUES ('Resurs', GETDATE())
END
GO

IF OBJECT_ID('radno_mesto_change_trigger', 'TR') IS NOT NULL
    DROP TRIGGER radno_mesto_change_trigger
GO
CREATE TRIGGER radno_mesto_change_trigger
ON dbo.radno_mesto_detalj
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO dbo.change_log(entity_name, change_time)
    VALUES ('Resurs', GETDATE())
END
GO

IF OBJECT_ID('sala_change_trigger', 'TR') IS NOT NULL
    DROP TRIGGER sala_change_trigger
GO
CREATE TRIGGER sala_change_trigger
ON dbo.sala_detalj
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO dbo.change_log(entity_name, change_time)
    VALUES ('Resurs', GETDATE())
END
GO

IF OBJECT_ID('rezervacija_change_trigger', 'TR') IS NOT NULL
    DROP TRIGGER rezervacija_change_trigger
GO
CREATE TRIGGER rezervacija_change_trigger
ON dbo.rezervacija
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO dbo.change_log(entity_name, change_time)
    VALUES ('Rezervacija', GETDATE())
END
GO

IF OBJECT_ID('tip_clanstva_change_trigger', 'TR') IS NOT NULL
    DROP TRIGGER tip_clanstva_change_trigger
GO
CREATE TRIGGER tip_clanstva_change_trigger
ON dbo.tip_clanstva
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO dbo.change_log(entity_name, change_time)
    VALUES ('TipClanstva', GETDATE())
END
GO