#SCAFFOLD 
Get into the ui folder before issue the each commands

USER
dotnet aspnet-codegenerator controller -name userController -async -m dal.user -dc dal.trucktrackContext -udl --relativeFolderPath Controllers --referenceScriptLibraries


TRUCK
dotnet aspnet-codegenerator controller -name truckController -async -m dal.truck -dc dal.trucktrackContext -udl --relativeFolderPath Controllers --referenceScriptLibraries

LOCATION
dotnet aspnet-codegenerator controller -name locationController -async -m dal.location -dc dal.trucktrackContext -udl --relativeFolderPath Controllers --referenceScriptLibraries

REPORT
dotnet aspnet-codegenerator controller -name reportController -async -m dal.report -dc dal.trucktrackContext -udl --relativeFolderPath Controllers --referenceScriptLibraries

#CREATE A MIGRATION
Get into the dal folder before issue the each commands(The connection code is hard coded in the trucktrackfactory)

```shell
% cd dal
# make sure you are in the dal project folder

dotnet ef migrations add Milestone02 -c trucktrackContext -s ../ui/ui.csproj

```

The command above should create some files under the /trucktrack/dal/Migrations folder.

## Create a sql script from the migration

```shell
% cd Migrations
# make sure you are in the /trucktrack/dal/Migrations folder

dotnet ef migrations script 0  InitialMigration -o dbmigration.sql -- connectionstring
```
