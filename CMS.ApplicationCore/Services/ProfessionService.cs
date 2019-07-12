using CMS.ApplicationCore.Entity;
using CMS.ApplicationCore.Interfaces.Repository;
using CMS.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CMS.ApplicationCore.Services
{
    public class ProfessionService : IProfessionService
    {

        private readonly IProfessionRepository _professionRepository;

        public ProfessionService(IProfessionRepository professionRepository)
        {
            _professionRepository = professionRepository;
        }

        public Profession Add(Profession entity)
        {
            return _professionRepository.Add(entity);
        }

        public IEnumerable<Profession> Get(Expression<Func<Profession, bool>> predicate)
        {
            return _professionRepository.Get(predicate);
        }

        public IEnumerable<Profession> GetAll()
        {
            return _professionRepository.GetAll();
        }

        public Profession GetById(int id)
        {
            return _professionRepository.GetById(id);
        }

        public void Remove(Profession entity)
        {
            _professionRepository.Remove(entity);
        }

        public void Update(Profession entity)
        {
            _professionRepository.Update(entity);
        }
    }
}
