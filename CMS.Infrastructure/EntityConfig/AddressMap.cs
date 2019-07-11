using CMS.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infrastructure.EntityConfig
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(a => a.City)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(a => a.PostalCode)
                .HasColumnType("varchar(15)")
                .IsRequired();

            builder.Property(a => a.County)
                .HasColumnType("varchar(200)")
                .IsRequired();
        }
    }
}
