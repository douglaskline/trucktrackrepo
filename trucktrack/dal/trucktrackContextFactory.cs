using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace dal
{
    public class truckTrackContextFactory
    : IDesignTimeDbContextFactory<trucktrackContext>
    {
       // private const string ConnectionString= "Server=tcp:uncwkline.database.windows.net,1433;Initial Catalog=trucktrackdb;Persist Security Info=False;User ID=trucktrackwebapp;Password=24KrgIft3P83kSkQlT7yBAUL2OB;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        

        public truckTrackContextFactory(){

        }



public trucktrackContext CreateDbContext(string[] args) //#C
        {
            string ConnStr = args[0];
            var optionsBuilder = new                      //#D
                DbContextOptionsBuilder<trucktrackContext>(); //#D
            optionsBuilder.UseSqlServer(ConnStr, //#E
                b => b.MigrationsAssembly("dal"));  //#E

            return new trucktrackContext(optionsBuilder.Options); //#F
        }

    }
}