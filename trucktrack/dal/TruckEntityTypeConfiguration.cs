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
            .IsRequired()
            .HasAnnotation("DisplayName", "Truck Name");

         builder
            .Property(t => t.homeCity)
            .HasColumnType("VARCHAR")
            .HasMaxLength(75)
            .HasAnnotation("DisplayName", "Home City");

         builder
            .Property(t => t.homeState)
            .HasColumnType("CHAR")
            .HasMaxLength(2)
            .HasAnnotation("DisplayName", "Home State");

         builder
            .Property(t => t.foodStyle)
            .HasColumnType("VARCHAR")
            .HasMaxLength(75)
            .HasAnnotation("DisplayName", "Food Style");

         builder
            .Property(t => t.priceRange)
            .HasColumnType("VARCHAR")
            .HasMaxLength(10)
            .HasAnnotation("DisplayName", "Price Range");


         builder
            .Property(t => t.tagLine)
            .HasColumnType("VARCHAR")
            .HasMaxLength(200)
            .HasAnnotation("DisplayName", "Tag Line");


         builder
            .Property(t => t.truckURL)
            .HasColumnType("VARCHAR")
            .HasMaxLength(300)
            .HasAnnotation("DisplayName", "Truck URL");


         builder.Property(t => t.timeStamp).IsRowVersion();


      }
   }
}