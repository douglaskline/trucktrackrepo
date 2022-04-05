Apr 5 Commands to set up uitests
================================

from the trucktrack root folder where the .sln file is

```shell
dotnet new xunit -o uitests -f net5.0 
cd uitests
dotnet add reference ..\ui\ui.csproj

```
