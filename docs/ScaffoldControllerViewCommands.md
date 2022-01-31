# Commands to scaffold a simple controller and views for user model

```shell
#install the code generator tool
dotnet tool install -g dotnet-aspnet-codegenerator --version 5.0.2


dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2


dotnet aspnet-codegenerator controller -name UniversityController -async --model dataAccess.University -outDir Controllers -dc dataAccess.MSCSISContext

dotnet aspnet-codegenerator view University List --project ui.csproj --model dataAccess.University  -outDir Views 

```