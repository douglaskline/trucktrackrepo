using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dal
{

   public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
   {
      public void Configure(EntityTypeBuilder<User> builder)
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
            .Property(u => u.userName)
            .IsRequired();

         builder
            .Property(u => u.email)
            .IsRequired();
      }
   }
}