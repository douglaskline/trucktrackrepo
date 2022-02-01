using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace dal
{
    public class truckTrackContextFactory
    : IDesignTimeDbContextFactory<trucktrackContext>
    {
        

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