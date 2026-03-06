-- ============================================
-- STORED PROCEDURE - Provera dostupnosti
-- ============================================
-- 004_procedures.sql

IF OBJECT_ID(N'dbo.sp_proveri_dostupnost', N'P') IS NOT NULL
    DROP PROCEDURE dbo.sp_proveri_dostupnost
GO

CREATE PROCEDURE dbo.sp_proveri_dostupnost
    @p_resurs_id INT,
    @p_pocetak DATETIME,
    @p_kraj DATETIME
AS
BEGIN
    SET NOCOUNT ON

    SELECT COUNT(*) AS broj_konflikata
    FROM dbo.rezervacija
    WHERE resurs_id = @p_resurs_id
      AND status IN ('Rezervisana', 'Potvrdjena')
      AND (
          (pocetak <= @p_pocetak AND kraj > @p_pocetak) OR
          (pocetak < @p_kraj AND kraj >= @p_kraj) OR
          (pocetak >= @p_pocetak AND kraj <= @p_kraj)
      )
END
