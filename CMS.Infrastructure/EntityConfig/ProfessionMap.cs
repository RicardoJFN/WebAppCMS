using CMS.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infrastructure.EntityConfig
{
    public class ProfessionMap : IEntityTypeConfiguration<Profession>
    {
        public void Configure(EntityTypeBuilder<Profession> builder)
        {
            builder.Property(p => p.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.Code)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnType("varchar(1000)")
                .IsRequired();
        }
    }
}
