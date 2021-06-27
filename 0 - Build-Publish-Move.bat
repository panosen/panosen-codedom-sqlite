@echo off

dotnet restore

dotnet build --no-restore -c Release

move /Y Panosen.CodeDom.Sqlite\bin\Release\Panosen.CodeDom.Sqlite.*.nupkg D:\LocalSavoryNuget\

pause