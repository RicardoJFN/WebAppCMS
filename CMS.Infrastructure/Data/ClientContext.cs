using CMS.ApplicationCore.Entity;
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

            #region Client Configuration
            modelBuilder.Entity<Client>()
                .Property(e => e.CCNumber)
                .IsRequired();

            modelBuilder.Entity<Client>()
                .Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .IsRequired();
            #endregion

            #region Contact Configuration
            modelBuilder.Entity<Contact>()
                .Property(e => e.Name)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Contact>()
                .Property(e => e.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Contact>()
                .Property(e => e.PhoneNumber)
                .HasColumnType("varchar(15)");
            #endregion


        }
    }
}
