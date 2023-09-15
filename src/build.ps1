# Stop script execution if any command fails
$ErrorActionPreference = "Stop"

Write-Output "Restoring NuGet packages..."
dotnet restore

Write-Output "Building the solution..."
dotnet build --configuration Release

Write-Output "Running tests..."
dotnet test --configuration Release --no-build

# Write-Output "Build completed successfully."

