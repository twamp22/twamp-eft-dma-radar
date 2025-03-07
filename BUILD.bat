@ECHO OFF
ECHO - Cleaning Publish Dirs...
CD "%lone_publish_path%"
if %ERRORLEVEL% NEQ 0 (goto ERROR)
DEL *.* /F /Q

ECHO - Publishing Lone EFT Solution...
dotnet publish "%lone_eft_solution%" ^
    --configuration Release ^
    --framework net9.0-windows ^
    --runtime win-x64 ^
    --no-self-contained ^
    /p:DebugSymbols=false ^
    /p:DebugType=none ^
    --output "%lone_publish_path%"
if %ERRORLEVEL% NEQ 0 (goto ERROR)

ECHO - Done
PAUSE
EXIT 0

:ERROR
ECHO - ERROR!
PAUSE
EXIT 1