@ECHO OFF
ECHO - Cleaning publish dir...
CD "%lone_publish_path%"
DEL *.* /F /Q
ECHO - Publishing EFT...
dotnet publish "%lone_eft_project%" ^
    --configuration Release ^
    --framework net9.0-windows ^
    --runtime win-x64 ^
    --self-contained false ^
    /p:DebugSymbols=false ^
    /p:DebugType=none ^
    --output "%lone_publish_path%"
ECHO - Publishing Arena...
dotnet publish "%lone_arena_project%" ^
    --configuration Release ^
    --framework net9.0-windows ^
    --runtime win-x64 ^
    --self-contained false ^
    /p:DebugSymbols=false ^
    /p:DebugType=none ^
    --output "%lone_publish_path%"

ECHO - Done
PAUSE
EXIT 0