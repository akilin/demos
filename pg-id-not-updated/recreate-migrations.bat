@echo off
RMDIR "Migrations" /S /Q
dotnet ef migrations add Initial -o Migrations