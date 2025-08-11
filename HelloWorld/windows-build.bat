@echo off
echo Building HelloWorld for Windows...
dotnet publish -c Release -r win-x64 --self-contained false -o ./windows-build
echo Build complete! Run HelloWorld.exe from the windows-build folder.
pause