$scriptName = $MyInvocation.MyCommand.Name
$artifacts = "./artifacts"

Get-ChildItem $artifacts -Filter "*.nupkg" | ForEach-Object {
    Write-Host "$($scriptName): Pushing $($_.Name)"
    dotnet nuget push $_ --source $Env:NUGET_URL --api-key $Env:NUGET_API_KEY
    if ($lastexitcode -ne 0) {
        throw ("Exec: " + $errorMessage)
    }
}