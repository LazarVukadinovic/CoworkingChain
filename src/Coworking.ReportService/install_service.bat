@echo off
echo ============================================
echo  Coworking Report Service - Instalacija
echo ============================================

set SERVICE_NAME=CoworkingReportService
set EXE_PATH=%~dp0Coworking.ReportService.exe

echo Instaliram servis...
sc create %SERVICE_NAME% binPath="%EXE_PATH%" start=auto DisplayName="Coworking Report Service"

echo Pokrecem servis...
sc start %SERVICE_NAME%

echo.
echo Servis je instaliran i pokrenut.
echo Da biste promenili interval, editujte service_config.txt
pause
