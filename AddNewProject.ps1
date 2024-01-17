$projectName = "XXXXX"

dotnet new sln -n $($projectName)    
Set-Location source
dotnet new console -n $($projectName) 
dotnet new console -n $($projectName)Example
Set-Location..
Set-Location tests
dotnet new xunit -n $($projectName)Example.Tests
Set-Location..
dotnet sln add source/$($projectName)/$($projectName).csproj
dotnet sln add source/$($projectName)Example/$($projectName)Example.csproj
dotnet sln add tests/$($projectName)Example.Tests/$($projectName)Example.Tests.csproj