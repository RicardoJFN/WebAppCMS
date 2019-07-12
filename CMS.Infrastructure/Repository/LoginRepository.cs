using CMS.ApplicationCore.Entity;
using CMS.ApplicationCore.Interfaces.Repository;
using CMS.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMS.Infrastructure.Repository
{
    public class LoginRepository : EFRepository<Login>, ILoginRepository
    {
        public LoginRepository(ClientContext context) : base(context)
        {
        }

        public Login GetByUserNameAndPassword(string username, string password)
        {
            var logins = GetAll();

            return logins.Where(l => l.UserName.Equals(username) && l.Password.Equals(password))
                .FirstOrDefault();
        }
    }
}
