$ErrorActionPreference = "Stop" # stop script on error

# First remove existing reports
$PathsToRemove = `
    ".\Calculator.Tests\lcov.info", `
    ".\Calculator.Tests\\coveragereport"

foreach ($path in $PathsToRemove) {
  if (Test-Path $path) {
      Write-Output "Removing $($path)..."
      Remove-Item -Recurse $path
  }
}

# Run tests with coverlet
dotnet test `
    /p:CollectCoverage=true `
    /p:CoverletOutputFormat=lcov `
    /p:CoverletOutput=lcov.info `
    /p:Include="[Calculator]*"

if($?)
{
    # Generate  tests coverage report
    reportgenerator `
        "-reports:Calculator.Tests\\lcov.info" `
        "-targetdir:Calculator.Tests\\coveragereport" `
        -reporttypes:Html

    # Open test coverage report
    Start-Process "Calculator.Tests\\coveragereport\\index.html"
}
else
{
   "Coverage report not generated - one or more tests failed"
}
