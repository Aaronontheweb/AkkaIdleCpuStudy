@echo off
REM deploys all Kubernetes services

dotnet build -c Release
dotnet run -c Release --project src/Akka14/Akka14.csproj &
dotnet run -c Release --project src/Akka13/Akka13.csproj &