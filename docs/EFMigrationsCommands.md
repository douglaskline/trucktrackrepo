# Commands for EF database migrations

## what are migrations?

EF core uses something called a migration to make the model classes in our code match the schema in our database.

Typically, we will make changes to our model classes and dbContext (for example user.cs and trucktrackContext.cs), then create a migration to make the necessary changes to our database.

[Link to the tools](https://docs.microsoft.com/en-us/ef/core/cli/dotnet)

To use the ef tools, such as migrations, you need to install it at the command line like this:

```shell
dotnet tool install --global dotnet-ef --version 5.0.14
dotnet tool install --global dotnet-aspnet-codegenerator --version 5.0.2

```

On my mac, I had to also run this to add the tools to my path variable:

```shell
cat << \EOF >> ~/.zprofile
# Add .NET Core SDK tools
export PATH="$PATH:/Users/dougkline/.dotnet/tools"
EOF
```

## Create a migration

```shell
% cd dal
# make sure you are in the dal project folder

dotnet ef migrations add InitialMigration -c trucktrackContext -s ../ui/ui.csproj -- connectionstring

```

The command above should create some files under the /trucktrack/dal/Migrations folder.

## Create a sql script from the migration

```shell
% cd Migrations
# make sure you are in the /trucktrack/dal/Migrations folder

dotnet ef migrations script 0  InitialMigration -o dbmigration.sql -- connectionstring
```
