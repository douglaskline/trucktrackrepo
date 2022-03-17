Get into the ui folder before issue the each commands
USER
dotnet aspnet-codegenerator controller -name userController -async -m dal.user -dc dal.trucktrackContext -udl --relativeFolderPath Controllers --referenceScriptLibraries


TRUCK
dotnet aspnet-codegenerator controller -name truckController -async -m dal.truck -dc dal.trucktrackContext -udl --relativeFolderPath Controllers --referenceScriptLibraries

LOCATION
dotnet aspnet-codegenerator controller -name locationController -async -m dal.location -dc dal.trucktrackContext -udl --relativeFolderPath Controllers --referenceScriptLibraries

REPORT
dotnet aspnet-codegenerator controller -name reportController -async -m dal.report -dc dal.trucktrackContext -udl --relativeFolderPath Controllers --referenceScriptLibraries
