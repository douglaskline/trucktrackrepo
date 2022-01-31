using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace dal
{

   public  class UserEntityTypeConfiguration : IEntityTypeConfiguration<dal.user>
   {
      public void Configure(EntityTypeBuilder<dal.user> builder)
      {
         builder
            .Property(u => u.Id)
            .HasColumnName("Id")
            .IsRequired();

         builder
            .Property(u => u.firstName);

         builder
            .Property(u => u.lastName)
            .IsRequired();

         builder
            .Property(u => u.username)
            .IsRequired();

         builder
            .Property(u => u.email)
            .IsRequired();
      }
   }
}