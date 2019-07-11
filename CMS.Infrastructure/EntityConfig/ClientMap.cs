using CMS.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infrastructure.EntityConfig
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasMany(c => c.Contacts)
                .WithOne(c => c.Client)
                .HasForeignKey(c => c.ClientId)
                .HasPrincipalKey(c => c.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Address)
                .WithOne(a => a.Client)
                .HasForeignKey<Address>(a => a.ClientId);

            builder.Property(e => e.CCNumber)
                .IsRequired();

            builder.Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .IsRequired();
        }
    }
}
