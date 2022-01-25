# Initial Scaffold Commands

These are the commands that were used to create the initial scaffolded projects.

## Setup the root project

``` shell
\trucktrackrepo> dotnet new sln -o trucktrack

# makes a new folder called trucktrack
# makes a file in that folder called trucktrack.sln

\trucktrackrepo>cd trucktrack
# change into the new folder

\trucktrackrepo\trucktrack>

```

## Setup the webapp project

``` shell
\trucktrackrepo\trucktrack> dotnet new webapp -o ui -f net5.0 
# creates a new folder called ui
# creates a file in the folder called ui/csproj

\trucktrackrepo\trucktrack> dotnet sln .\trucktrack.sln add .\ui\ui.csproj
# adds a reference for this project to the solution file

\trucktrackrepo\trucktrack> cd ui
# move into project folder

\trucktrackrepo\trucktrack> dotnet add package Microsoft.EntityFrameworkCore --version 5.0.13
\trucktrackrepo\trucktrack> dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.13
\trucktrackrepo\trucktrack> dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.13
\trucktrackrepo\trucktrack> dotnet build
# last command checks to see if the whole project builds - should get "Build Succeeded" message

\trucktrackrepo\trucktrack> dotnet new classlib -o dal -f net5.0
# new class library project for the data access layer

\trucktrackrepo\trucktrack> cd dal
\trucktrackrepo\trucktrack\dal> dotnet add package Microsoft.EntityFrameworkCore --version 5.0.13
\trucktrackrepo\trucktrack\dal> dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.13
\trucktrackrepo\trucktrack\dal> dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.13
\trucktrackrepo\trucktrack\dal> dotnet build
# adds the packages to the dal project and checks for build

\trucktrackrepo\trucktrack> cd ..
# back out to the solution level

\trucktrackrepo\trucktrack> dotnet sln .\trucktrack.sln add .\dal\dal.csproj
# add the dal project to the solution

\\trucktrackrepo\trucktrack> cd ui
# move into the ui project directory
\trucktrackrepo\trucktrack>
# add a refernce to the dal project to the ui project


```
