using CMS.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClientContext context)
        {
            if (context.Clients.Any())
                return;

            var clients = new Client[]
            {
                new Client
                {
                    Name = "Ricardo",
                    CCNumber = 123456789
                },

                new Client
                {
                    Name = "Jorge",
                    CCNumber = 987654321
                }
            };

            context.AddRange(clients);

            var contacts = new Contact[]
            {
                new Contact
                {
                    Name = "Contact 1",
                    PhoneNumber = "91666555",
                    Email = "contact1@teste.pt",
                    Client = clients[0]
                },

                new Contact
                {
                    Name = "Contact 2",
                    PhoneNumber = "91222333",
                    Email = "contact2@teste.pt",
                    Client = clients[1]
                }
            };

            context.AddRange(contacts);

            context.SaveChanges();
        }
    }
}
