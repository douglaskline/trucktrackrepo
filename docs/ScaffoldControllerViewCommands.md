# Commands to scaffold a simple controller and views for user model

```shell
#install the code generator tool
dotnet tool install -g dotnet-aspnet-codegenerator --version 5.0.2


dotnet add package  --version 5.0.2

dotnet aspnet-codegenerator controller -name UserController -async -m dal.user -dc dal.trucktrackContext 
# the command above requires a hard-coded connection string in trucktrackContextFactory.cs
# but we aren't leaving that in the source code
# so we may be building these controllers and views by hand

# examples below
dotnet aspnet-codegenerator controller -name UserController -async --model dal.user -outDir Controllers -dc dal.trucktrackContext


dotnet aspnet-codegenerator view University List --project ui.csproj --model dataAccess.University  -outDir Views 

```

