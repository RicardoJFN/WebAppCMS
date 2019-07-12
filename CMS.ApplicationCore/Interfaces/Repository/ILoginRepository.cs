using CMS.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.ApplicationCore.Interfaces.Repository
{
    public interface ILoginRepository : IRepository<Login>
    {
        Login GetByUserNameAndPassword(string username, string password);
    }
}
