using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dal
{
   public partial class trucktrackContext : DbContext
   {
      public trucktrackContext() { }

      public trucktrackContext(DbContextOptions<trucktrackContext> options) : base(options) { }

      public virtual DbSet<user> user { get; set; }
      public virtual DbSet<dal.truck> truck { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         if (!optionsBuilder.IsConfigured)
         { }
      }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
         
         
      }
   }
}