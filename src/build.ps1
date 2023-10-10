# Stop script execution if any command fails
$ErrorActionPreference = "Stop"

Write-Output "Restoring dotnet tools..."
dotnet tool restore

Write-Output "Running Cake script..."
dotnet cake