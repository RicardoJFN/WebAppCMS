using CMS.ApplicationCore.Entity;
using CMS.ApplicationCore.Interfaces.Repository;
using CMS.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CMS.ApplicationCore.Services
{
    public class ClientService : IClientService
    {

        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Client Add(Client entity)
        {
            return _clientRepository.Add(entity);
        }

        public IEnumerable<Client> Get(Expression<Func<Client, bool>> predicate)
        {
            return _clientRepository.Get(predicate);
        }

        public IEnumerable<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public Client GetById(int id)
        {
            return _clientRepository.GetById(id);
        }

        public void Remove(Client entity)
        {
            _clientRepository.Remove(entity);
        }

        public void Update(Client entity)
        {
            _clientRepository.Update(entity);
        }
    }
}
