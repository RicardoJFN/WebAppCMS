using CMS.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CMS.ApplicationCore.Interfaces.Services
{
    public interface IContactService
    {
        Contact Add(Contact entity);
        void Update(Contact entity);
        IEnumerable<Contact> GetAll();
        Contact GetById(int id);
        IEnumerable<Contact> Get(Expression<Func<Contact, bool>> predicate);
        void Remove(Contact entity);
    }
}
