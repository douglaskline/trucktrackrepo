Commands I used to create the utiltests project
==================================================

from the trucktrack root folder where the .sln file is
```shell
dotnet new xunit -o utiltests -f net5.0 
cd utiltests
dotnet add reference ..\util\util.csproj

```