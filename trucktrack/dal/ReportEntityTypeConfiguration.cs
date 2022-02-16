using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace dal
{

   public  class ReportEntityTypeConfiguration : IEntityTypeConfiguration<dal.report>
   {
      public void Configure(EntityTypeBuilder<dal.report> builder)
      {
         builder.ToTable("report");
         
         builder.HasKey(r=>r.Id);

         //builder.HasOne 
         /*
         builder
            .HasOne(r=r.userId)
            .WithMany(r=r.)

         builder
            .HasOne(r=>r.userId)
            .WithMany()
            .HasForeignKey<dal.user> (r=>r.userId);

         builder
            .Property(r=> r.reportTime)
            .IsRequired();
         
         builder
            .Property(r=> r.Id)
            .IsRequired();

         builder
            .Property(r=> r.userId)
            .IsRequired();

          builder
            .Property(r=> r.truckId)
            .IsRequired();  

         builder
            .Property(r=> r.locationId)
            .IsRequired();


         
            */
      }
   }
}