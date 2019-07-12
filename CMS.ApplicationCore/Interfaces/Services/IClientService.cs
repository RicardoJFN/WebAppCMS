using CMS.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CMS.ApplicationCore.Interfaces.Services
{
    public interface IClientService
    {
        Client Add(Client entity);
        void Update(Client entity);
        IEnumerable<Client> GetAll();
        Client GetById(int id);
        IEnumerable<Client> Get(Expression<Func<Client, bool>> predicate);
        void Remove(Client entity);
    }
}
