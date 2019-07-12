using CMS.ApplicationCore.Entity;
using CMS.ApplicationCore.Interfaces.Repository;
using CMS.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CMS.ApplicationCore.Services
{
    public class ContactService : IContactService
    {

        private IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public Contact Add(Contact entity)
        {
            return _contactRepository.Add(entity);
        }

        public IEnumerable<Contact> Get(Expression<Func<Contact, bool>> predicate)
        {
            return _contactRepository.Get(predicate);
        }

        public IEnumerable<Contact> GetAll()
        {
            return _contactRepository.GetAll();
        }

        public Contact GetById(int id)
        {
            return _contactRepository.GetById(id);
        }

        public void Remove(Contact entity)
        {
            _contactRepository.Remove(entity);
        }

        public void Update(Contact entity)
        {
            _contactRepository.Update(entity);
        }
    }
}
