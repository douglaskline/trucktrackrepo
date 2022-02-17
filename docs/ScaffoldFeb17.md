Scaffold Commands from Feb 17
=============================

FYI
----

I'm doing this on my desktop machine at UNCW, which had not been set up fully yet. So I had to issue some commands to get the right tools and packages, etc.

Truck
-----

Scaffold the controller

```cmd
dotnet aspnet-codegenerator controller -name truckController -async -m dal.truck -dc dal.trucktrackContext -udl --relativeFolderPath Controllers --referenceScriptLibraries
```

The above command created a truckController.cs in the Controllers folder.
It also created a truck folder under views with Create, Delete, Details, Etic, and Index views.

Location
-----

```cmd
dotnet aspnet-codegenerator controller -name locationController -async -m dal.location -dc dal.trucktrackContext -udl --relativeFolderPath Controllers --referenceScriptLibraries
```

Report
------

```cmd
dotnet aspnet-codegenerator controller -name reportController -async -m dal.report -dc dal.trucktrackContext -udl --relativeFolderPath Controllers --referenceScriptLibraries
```
