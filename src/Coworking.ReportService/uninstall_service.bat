@echo off
echo ============================================
echo  Coworking Report Service - Deinstalacija
echo ============================================

set SERVICE_NAME=CoworkingReportService

echo Zaustavljam servis...
sc stop %SERVICE_NAME%

timeout /t 2 /nobreak > nul

echo Brišem servis...
sc delete %SERVICE_NAME%

echo.
echo Servis je uklonjen.
pause
