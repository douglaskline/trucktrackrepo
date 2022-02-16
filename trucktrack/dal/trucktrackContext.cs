using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dal
{
   public partial class trucktrackContext : DbContext
   {
      public trucktrackContext() { }

      public trucktrackContext(DbContextOptions<trucktrackContext> options) : base(options) { }

      public virtual DbSet<dal.user> users { get; set; }
      public virtual DbSet<dal.report> reports {get; set;}

      public virtual DbSet<dal.location> locations {get; set;}

      public virtual DbSet<dal.truck> trucks {get; set;}

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         if (!optionsBuilder.IsConfigured)
         { }
      }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
         modelBuilder.ApplyConfiguration(new ReportEntityTypeConfiguration());
         modelBuilder.ApplyConfiguration(new LocationEntityTypeConfiguration());
         modelBuilder.ApplyConfiguration(new TruckEntityTypeConfiguration()) ;  
      }
   }
}