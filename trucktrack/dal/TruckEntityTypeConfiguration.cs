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
            .Property(t => t.truckName)
            .HasColumnType("VARCHAR")
            .HasMaxLength(200)
            .IsRequired();

         builder
            .Property(t => t.homeCity)
            .HasColumnType("VARCHAR")
            .HasMaxLength(75);

         builder
            .Property(t => t.homeState)
            .HasColumnType("CHAR")
            .HasMaxLength(2);

         builder
            .Property(t => t.foodStyle)
            .HasColumnType("VARCHAR")
            .HasMaxLength(75);

         builder
            .Property(t => t.priceRange)
            .HasColumnType("VARCHAR")
            .HasMaxLength(10);

         builder
            .Property(t => t.tagLine)
            .HasColumnType("VARCHAR")
            .HasMaxLength(200);

         builder
            .Property(t => t.truckURL)
            .HasColumnType("VARCHAR")
            .HasMaxLength(300);

         builder.Property(t => t.timeStamp).IsRowVersion();


      }
   }
}