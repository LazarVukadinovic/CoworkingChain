IF OBJECT_ID('clan_change_trigger', 'TR') IS NOT NULL
    DROP TRIGGER clan_change_trigger;

CREATE TRIGGER clan_change_trigger
ON clan
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO change_log(entity_name, change_time)
    VALUES ('Clan', GETDATE())
END

IF OBJECT_ID('lokacija_change_trigger', 'TR') IS NOT NULL
    DROP TRIGGER lokacija_change_trigger;

CREATE TRIGGER lokacija_change_trigger
ON lokacija
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO change_log(entity_name, change_time)
    VALUES ('Lokacija', GETDATE())
END

IF OBJECT_ID('resurs_change_trigger', 'TR') IS NOT NULL
    DROP TRIGGER resurs_change_trigger;

CREATE TRIGGER resurs_change_trigger
ON resurs
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO change_log(entity_name, change_time)
    VALUES ('Resurs', GETDATE())
END

IF OBJECT_ID('radno_mesto_change_trigger', 'TR') IS NOT NULL
    DROP TRIGGER radno_mesto_change_trigger;

CREATE TRIGGER radno_mesto_change_trigger
ON radno_mesto_detalj
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO change_log(entity_name, change_time)
    VALUES ('Resurs', GETDATE())
END

IF OBJECT_ID('sala_change_trigger', 'TR') IS NOT NULL
    DROP TRIGGER sala_change_trigger;

CREATE TRIGGER sala_change_trigger
ON sala_detalj
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO change_log(entity_name, change_time)
    VALUES ('Resurs', GETDATE())
END

IF OBJECT_ID('rezervacija_change_trigger', 'TR') IS NOT NULL
    DROP TRIGGER rezervacija_change_trigger;

CREATE TRIGGER rezervacija_change_trigger
ON rezervacija
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO change_log(entity_name, change_time)
    VALUES ('Rezervacija', GETDATE())
END

IF OBJECT_ID('tip_clanstva_change_trigger', 'TR') IS NOT NULL
    DROP TRIGGER tip_clanstva_change_trigger;

CREATE TRIGGER tip_clanstva_change_trigger
ON tip_clanstva
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    INSERT INTO change_log(entity_name, change_time)
    VALUES ('TipClanstva', GETDATE())
END