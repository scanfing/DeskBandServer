@echo OFF
title Install DeskBand
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

if exist "%PROGRAMFILES(x86)%" goto regx else goto reg
goto reg

:exitPos
echo Exit
exit

:reg
echo Reg _x86
%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\regasm.exe /nologo /codebase "DeskBandServer.Grpc.dll"
goto exitPos

:regx
echo Reg _x64
%SystemRoot%\Microsoft.NET\Framework64\v4.0.30319\regasm.exe /nologo /codebase "DeskBandServer.Grpc.dll"
goto exitPos