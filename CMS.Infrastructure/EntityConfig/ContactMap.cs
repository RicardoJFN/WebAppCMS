using CMS.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infrastructure.EntityConfig
{
    public class ContactMap : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasOne(c => c.Client)
                .WithMany(c => c.Contacts)
                .HasForeignKey(c => c.ClientId)
                .HasPrincipalKey(c => c.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(e => e.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(e => e.PhoneNumber)
                .HasColumnType("varchar(15)");
        }
    }
}
