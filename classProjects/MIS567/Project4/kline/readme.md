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

