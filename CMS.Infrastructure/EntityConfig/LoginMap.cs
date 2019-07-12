using CMS.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infrastructure.EntityConfig
{
    public class LoginMap : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.HasKey(l => l.Id);

            builder.Property(l => l.UserName)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(l => l.Password)
                .HasColumnType("varchar(200)")
                .IsRequired();
        }
    }
}
