@echo on

set CONFIG=Release
set RUNTIME=win-x64
set OUTPUT=%~dp0publish_output

dotnet publish -c %CONFIG% -r %RUNTIME% --self-contained false -o "%OUTPUT%"

IF ERRORLEVEL 1 (
    echo Publish failed.
    pause
    exit /b 1
)

echo Opening output folder:
echo %OUTPUT%

explorer "%OUTPUT%"

pause
