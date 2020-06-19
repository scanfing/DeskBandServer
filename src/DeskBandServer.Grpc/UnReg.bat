@echo OFF
title UnInstall DeskBand
@setlocal enableextensions
@cd /d "%~dp0"

rem Check permissions
net session >nul 2>&1
if %errorLevel% == 0 (
    echo Administrative permissions confirmed.
) else (
    echo Please run this script with administrator permissions.
	pause
    goto EXIT
)

if exist "%PROGRAMFILES(x86)%" (goto UnRegx64) else (goto UnRegx86)

:UnRegx86
echo UnReg _x86
%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\regasm.exe /nologo /unregister "DeskBandServer.Grpc.dll"
goto exitPos

:UnRegx64
echo UnReg _x64
%SystemRoot%\Microsoft.NET\Framework64\v4.0.30319\regasm.exe /nologo /unregister "DeskBandServer.Grpc.dll"
goto exitPos

:exitPos
taskkill /f /im explorer.exe & start explorer.exe
explorer %cd%
echo Exit
exit

