using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace dal
{

   public  class LocationEntityTypeConfiguration : IEntityTypeConfiguration<dal.location>
   {
      public void Configure(EntityTypeBuilder<dal.location> builder)
      {

         builder.ToTable("location");

         builder
            .Property(l => l.locationId)
            .HasColumnName("locationId")
            .IsRequired();

         builder
            .Property(l => l.locationName)
            .IsRequired();

         builder
            .Property(l => l.latitude)
            .IsRequired();

         builder
            .Property(l => l.longitude)
            .IsRequired();

         builder
            .Property(l => l.geocode);
        
        builder
            .Property(l => l.locationDescription)
            .HasColumnType("VARCHAR")
            .HasMaxLength(200);

         builder.Property(l => l.timeStamp).IsRowVersion();

      }
   }
}