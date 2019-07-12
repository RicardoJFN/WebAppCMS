using CMS.ApplicationCore.Entity;
using CMS.ApplicationCore.Interfaces.Repository;
using CMS.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Infrastructure.Repository
{
    public class ProfessionRepository : EFRepository<Profession>, IProfessionRepository
    {

        public ProfessionRepository(ClientContext context) : base(context)
        {

        }

    }
}
