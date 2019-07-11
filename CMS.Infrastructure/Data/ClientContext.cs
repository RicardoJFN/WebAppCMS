using CMS.ApplicationCore.Entity;
using CMS.Infrastructure.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Infrastructure.Data
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .ToTable("Client");

            modelBuilder.Entity<Contact>()
                .ToTable("Contact");

            modelBuilder.Entity<Address>()
                .ToTable("Address");

            modelBuilder.Entity<Profession>()
                .ToTable("Profession");

            modelBuilder.Entity<ProfessionClient>()
                .ToTable("ProfessionClient");

            modelBuilder.ApplyConfiguration(new ClientMap());
            modelBuilder.ApplyConfiguration(new ContactMap());
            modelBuilder.ApplyConfiguration(new ProfessionMap());
            modelBuilder.ApplyConfiguration(new AddressMap());
            modelBuilder.ApplyConfiguration(new ProfessionClientMap());
            modelBuilder.ApplyConfiguration(new MenuMap());
        }
    }
}
