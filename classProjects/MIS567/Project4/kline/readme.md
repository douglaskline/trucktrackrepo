Project 4 for MIS567
====================

I'm going to document everything I did to make this work.

* change to the correct folder first: trucktrackrepo\classProjects\MIS5 
    67\Project4\kline

Add a Controller
----------------

On the Add A Controller step here: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-controller?view=aspnetcore-5.0&tabs=visual-studio-code

I couldn't use the VSCode run command. I had to go to the terminal, change to the correct directory and issue a dotnet run command.

```shell
trucktrackrepo\classProjects\MIS567\Project4\kline\MvcMovie> dotnet run
```

The last few paragraphs of Add a Controller didn't initially make sense to me. I think they are just pointing out that the mapping over in startup.cs is what determines the route.

Add a View
----------

almost missed this step: Create a Welcome view template named Views/HelloWorld/Welcome.cshtml.

Add a Model
-----------

Now for this part:
```shell
dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

On my macbook, I ran this statement to see what global tools I had installed:
```shell
dougkline@Douglass-MacBook-Pro MvcMovie % dotnet tool list -g
Package Id                       Version      Commands                   
-------------------------------------------------------------------------
dotnet-aspnet-codegenerator      5.0.2        dotnet-aspnet-codegenerator
dotnet-ef                        6.0.1        dotnet-ef 
```

I also looked in my MvcMovie.csproj file, which showed that my target framework was 5.0:
```shell
<Project Sdk="Microsoft.NET.Sdk.Web">
  <PropertyGroup>
    <TargetFramework>net5.0</TargetFramework>
  </PropertyGroup>
</Project>
```

Knowing that, here are the commands I ran:
```shell
dotnet tool install --global dotnet-ef --version 5.0.14
# this gave me a message that it was already installed, which is a little weird (the list above says 6.0)
# I did not run the dotnet-aspnet-codegenerator, since it was already listed as installed
# note that tools are not part of our source - they are just used to perhaps create source code

dotnet list package #will show the packages installed for this project

dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.14
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 5.0.14
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.14
```

Something interesting I found from the above commands. Packages that don't match the target framework don't get installed in the project. So if I don't specify the --version, then the package doesn't get added to MvdMovie.csproj

Scaffold Movie Pages
--------------------
I was able to run the dotnet-aspnet-codegenerator command without doing the export command. But I've set this machine up previously. I think you will need to do the export command to add the tools to your path.

I don't think there's anything to be done in this section: Use SQLite for development, SQL Server for production

Initial Migration
-----------------
did the commands
ran without problems

Part 5 Work with a Database
---------------------------
For me to get this to work, I had to make a couple of changes.
In Program.cs, I changed the statement at the top `using MvcMovie.Data;` to `using MvcMovie;`
In SeedData.cs, I changed the statement at the top `using MvcMovie.Data;` to `using MvcMovie;`

I think this is because the `MvcMovieContext.cs` code doesn't declare a namespace.

Part 6, controller methods and views in ASP.NET Core
----------------------------------------------------

this worked fine

Part 7, add search to an ASP.NET Core MVC app
---------------------------------------------

this worked fine

Part 8, add a new field to an ASP.NET Core MVC app
--------------------------------------------------

I see there is no code for the modification for the delete view.
Here's what I added.
```html
        <dt class = "col-sm-10">
            @Html.DisplayNameFor(model=>model.Rating)
        </dt>
        <dd>
            @Html.DisplayFor(model => model.Rating)
        </dd>
```

Same with the create view
```html
            <div class="form-group">
                <label asp-for="Rating" class="control-label"></label>
                <input asp-for="Rating" class="form-control" />
                <span asp-validation-for="Rating" class="text-danger"></span>
            </div>
```

I was doing a build after each change to make sure I didn't have a build error.

Ah, I just saw the "Update the other templates". That means to fix all the views for movies: create, delete, details, edit, index.

It looks like you have to follow the link to reset all the migrations and start over:
https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/managing?tabs=dotnet-core-cli#resetting-all-migrations

Basically, you just have to delete the migrations folder, and delete the .db file.

