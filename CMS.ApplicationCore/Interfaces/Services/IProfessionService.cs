using CMS.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CMS.ApplicationCore.Interfaces.Services
{
    public interface IProfessionService
    {
        Profession Add(Profession entity);
        void Update(Profession entity);
        IEnumerable<Profession> GetAll();
        Profession GetById(int id);
        IEnumerable<Profession> Get(Expression<Func<Profession, bool>> predicate);
        void Remove(Profession entity);
    }
}
