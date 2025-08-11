@echo off
echo Building HelloWorld for Windows...
dotnet publish -c Release -r win-x64 --self-contained false -o ./windows-exe
echo Build complete! Run HelloWorld.exe from the windows-exe folder.
pause