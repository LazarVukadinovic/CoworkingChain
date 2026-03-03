-- ============================================
-- STORED PROCEDURE - Provera dostupnosti
-- ============================================
-- 004_procedures.sql

DROP PROCEDURE IF EXISTS sp_proveri_dostupnost;

DELIMITER //

CREATE PROCEDURE sp_proveri_dostupnost(
    IN p_resurs_id INT,
    IN p_pocetak DATETIME,
    IN p_kraj DATETIME
)
BEGIN
    SELECT COUNT(*) AS broj_konflikata
    FROM rezervacija
    WHERE resurs_id = p_resurs_id
      AND status IN ('Rezervisana', 'Potvrdjena')
      AND (
          (pocetak <= p_pocetak AND kraj > p_pocetak) OR
          (pocetak < p_kraj AND kraj >= p_kraj) OR
          (pocetak >= p_pocetak AND kraj <= p_kraj)
      );
END //

DELIMITER ;
