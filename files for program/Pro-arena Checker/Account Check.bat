@echo off
Set ProcessName=Steam.exe
rem ------------------------------------------------------------------------------
:start
color 70
TaskList /FI "ImageName EQ %ProcessName%" 2>nul|Find /I "%ProcessName%">nul||(
    goto Failed
)

for /f "tokens=1* delims==" %%i in ('
 wmic process where "Name='%ProcessName%'" get ExecutablePath /value^| findstr :
') do set ExecutablePath=%%j
rem ------------------------------------------------------------------------------
cls
::if defined ExecutablePath
    set "str1=%ExecutablePath:~0,-10%"
    set "str2=config"
    set "str3=.vdf"
    set "str4=\loginusers"
    set "Path2=%str1%%str2%%str4%%str3%"
cls

:continue
copy "%Path2%" "%systemdrive%\Program Files\Pro-Arena Checker\acc.txt"
exit