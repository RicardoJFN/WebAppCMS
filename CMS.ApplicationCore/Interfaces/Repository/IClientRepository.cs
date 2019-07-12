using CMS.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.ApplicationCore.Interfaces.Repository
{
    public interface IClientRepository : IRepository<Client>
    {
        Client GetByProfession(int id);
    }
}
