using CMS.ApplicationCore.Interfaces.Repository;
using CMS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CMS.Infrastructure.Repository
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected readonly ClientContext context;

        public EFRepository(ClientContext context)
        {
            this.context = context;
        }

        public virtual TEntity Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
            return entity;
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>()
                .Where(predicate)
                .AsEnumerable();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>()
                .AsEnumerable();
        }

        public virtual TEntity GetById(int id)
        {
            return context.Set<TEntity>()
                .Find(id);
        }

        public void Remove(TEntity entity)
        {
            context.Set<TEntity>()
                .Remove(entity);
            context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            context.Entry(entity)
                .State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
