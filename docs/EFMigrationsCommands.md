# Commands for EF database migrations

## what are migrations?

EF core uses something called a migration to make the model classes in our code match the schema in our database.

Typically, we will make changes to our model classes and dbContext (for example user.cs and trucktrackContext.cs), then create a migration to make the necessary changes to our database.

[Link to the tools](https://docs.microsoft.com/en-us/ef/core/cli/dotnet)

To use the ef tools, such as migrations, you need to install it at the command line like this:

```shell
dotnet tool install --global dotnet-ef

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

dotnet ef migrations add InitialMigration -c trucktrackContext -s ../ui/ui.csproj
```
