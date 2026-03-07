-- Insert

DROP TRIGGER IF EXISTS clan_change_trigger;

CREATE TRIGGER clan_change_trigger
AFTER INSERT ON clan
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('Clan', NOW());

DROP TRIGGER IF EXISTS lokacije_change_trigger;

CREATE TRIGGER lokacije_change_trigger
AFTER INSERT ON lokacija
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('Lokacija', NOW());

DROP TRIGGER IF EXISTS resurs_change_trigger;

CREATE TRIGGER resurs_change_trigger
AFTER INSERT ON resurs
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('Resurs', NOW());

DROP TRIGGER IF EXISTS radno_mesto_change_trigger;

CREATE TRIGGER radno_mesto_change_trigger
AFTER INSERT ON radno_mesto_detalj
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('Resurs', NOW());

DROP TRIGGER IF EXISTS sala_za_sastanke_change_trigger;

CREATE TRIGGER sala_za_sastanke_change_trigger
AFTER INSERT ON sala_detalj
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('Resurs', NOW());

DROP TRIGGER IF EXISTS rezervacija_change_trigger;

CREATE TRIGGER rezervacija_change_trigger
AFTER INSERT ON rezervacija
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('Rezervacija', NOW());

DROP TRIGGER IF EXISTS tip_clanstva_change_trigger;

CREATE TRIGGER tip_clanstva_change_trigger
AFTER INSERT ON tip_clanstva
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('TipClanstva', NOW());

-- update

DROP TRIGGER IF EXISTS clan_change_trigger;

CREATE TRIGGER clan_change_trigger
AFTER UPDATE ON clan
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('Clan', NOW());

DROP TRIGGER IF EXISTS lokacije_change_trigger;

CREATE TRIGGER lokacije_change_trigger
AFTER UPDATE ON lokacija
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('Lokacija', NOW());

DROP TRIGGER IF EXISTS resurs_change_trigger;

CREATE TRIGGER resurs_change_trigger
AFTER UPDATE ON resurs
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('Resurs', NOW());

DROP TRIGGER IF EXISTS radno_mesto_change_trigger;

CREATE TRIGGER radno_mesto_change_trigger
AFTER UPDATE ON radno_mesto_detalj
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('Resurs', NOW());

DROP TRIGGER IF EXISTS sala_za_sastanke_change_trigger;

CREATE TRIGGER sala_za_sastanke_change_trigger
AFTER UPDATE ON sala_detalj
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('Resurs', NOW());

DROP TRIGGER IF EXISTS rezervacija_change_trigger;

CREATE TRIGGER rezervacija_change_trigger
AFTER UPDATE ON rezervacija
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('Rezervacija', NOW());

DROP TRIGGER IF EXISTS tip_clanstva_change_trigger;

CREATE TRIGGER tip_clanstva_change_trigger
AFTER UPDATE ON tip_clanstva
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('TipClanstva', NOW());

-- delete

DROP TRIGGER IF EXISTS clan_change_trigger;

CREATE TRIGGER clan_change_trigger
AFTER DELETE ON clan
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('Clan', NOW());

DROP TRIGGER IF EXISTS lokacije_change_trigger;

CREATE TRIGGER lokacije_change_trigger
AFTER DELETE ON lokacija
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('Lokacija', NOW());

DROP TRIGGER IF EXISTS resurs_change_trigger;

CREATE TRIGGER resurs_change_trigger
AFTER DELETE ON resurs
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('Resurs', NOW());

DROP TRIGGER IF EXISTS radno_mesto_change_trigger;

CREATE TRIGGER radno_mesto_change_trigger
AFTER DELETE ON radno_mesto_detalj
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('Resurs', NOW());

DROP TRIGGER IF EXISTS sala_za_sastanke_change_trigger;

CREATE TRIGGER sala_za_sastanke_change_trigger
AFTER DELETE ON sala_detalj
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('Resurs', NOW());

DROP TRIGGER IF EXISTS rezervacija_change_trigger;

CREATE TRIGGER rezervacija_change_trigger
AFTER DELETE ON rezervacija
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('Rezervacija', NOW());

DROP TRIGGER IF EXISTS tip_clanstva_change_trigger;

CREATE TRIGGER tip_clanstva_change_trigger
AFTER DELETE ON tip_clanstva
FOR EACH ROW
INSERT INTO change_log(entity_name, change_time)
VALUES ('TipClanstva', NOW());