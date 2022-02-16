using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace dal
{

   public  class TruckEntityTypeConfiguration : IEntityTypeConfiguration<dal.truck>
   {
      public void Configure(EntityTypeBuilder<dal.truck> builder)
      {
         builder.ToTable("truck");
         
         builder
            .Property(t => t.truckId)
            .HasColumnName("truckId")
            .IsRequired();

         builder
            .Property(t => t.truckName);

         builder
            .Property(t => t.homeCity)
            .IsRequired();

         builder
            .Property(t => t.homeState)
            .IsRequired();

         builder
            .Property(t => t.foodStyle)
            .IsRequired();

         builder
            .Property(t => t.priceRange)
            .IsRequired();

         builder
            .Property(t => t.tagLine);

         builder
            .Property(t => t.truckURL);

      }
   }
}