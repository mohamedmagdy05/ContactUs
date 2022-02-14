using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bayan.ContactUs.Data.Config
{
    public class ContactUsEntityConfiguration : IEntityTypeConfiguration<Bayan.ContactUs.Data.Entity.ContactUs>
    {
        public void Configure(EntityTypeBuilder<Entity.ContactUs> builder)
        {
            builder
                .ToTable("ContactUs");
            builder
                .HasKey(c => c.id)
                .HasName("Id");

            builder
                .Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired();
            builder
             .Property(c => c.Email)
             .HasMaxLength(50)
             .IsRequired();
            builder
             .Property(c => c.Phone)
             .HasMaxLength(50)
             .IsRequired();
            builder
             .Property(c => c.CreatedOn)
             .HasMaxLength(50)
             .HasDefaultValueSql("getdate()");

        }
    }
}
