using CMS.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infrastructure.EntityConfig
{
    public class ProfessionClientMap : IEntityTypeConfiguration<ProfessionClient>
    {
        public void Configure(EntityTypeBuilder<ProfessionClient> builder)
        {
            builder.HasKey(pc => pc.Id);

            builder.HasOne(pc => pc.Client)
                .WithMany(c => c.ProfessionsClients)
                .HasForeignKey(pc => pc.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(pc => pc.Profession)
                .WithMany(p => p.ProfessionsClients)
                .HasForeignKey(pc => pc.ProfessionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
