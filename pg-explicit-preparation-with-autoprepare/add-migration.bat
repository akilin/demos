@echo off
set /p id="Enter migration name: "
dotnet ef migrations add %id% -o Migrations
pause