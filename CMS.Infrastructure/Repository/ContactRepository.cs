using CMS.ApplicationCore.Entity;
using CMS.ApplicationCore.Interfaces.Repository;
using CMS.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Infrastructure.Repository
{
    public class ContactRepository : EFRepository<Contact>, IContactRepository
    {

        public ContactRepository(ClientContext context) : base(context)
        {

        }

    }
}
