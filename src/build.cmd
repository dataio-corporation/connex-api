@echo off
SETLOCAL

REM Ensure PowerShell script execution policies won't block the script
powershell -ExecutionPolicy Bypass -NoProfile -File "%~dp0build.ps1"

ENDLOCAL
exit /b