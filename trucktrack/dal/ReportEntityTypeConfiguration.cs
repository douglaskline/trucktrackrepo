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
         builder.HasOne(r=>r.truck).WithMany(t=>t.reports).IsRequired().OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(r=>r.user).WithMany(u=>u.reports).OnDelete(DeleteBehavior.Restrict);
         builder.HasOne(r=>r.location).WithMany(l=>l.reports).IsRequired().OnDelete(DeleteBehavior.Restrict);
 
         builder
            .Property(r=> r.reportTime)
            .IsRequired();

         builder.Property(r => r.timeStamp).IsRowVersion();

      }
   }
}