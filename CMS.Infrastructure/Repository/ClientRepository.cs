using CMS.ApplicationCore.Entity;
using CMS.ApplicationCore.Interfaces.Repository;
using CMS.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Infrastructure.Repository
{
    public class ClientRepository : EFRepository<Client>, IClientRepository
    {

        public ClientRepository(ClientContext context) : base(context)
        {

        }

        public Client GetByProfession(int id)
        {
            return Get(c => c.ProfessionsClients.Any(pc => pc.ClientId == id))
                .FirstOrDefault();
        }
    }
}
