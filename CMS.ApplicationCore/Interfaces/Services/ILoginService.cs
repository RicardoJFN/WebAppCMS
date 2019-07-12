using CMS.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.ApplicationCore.Interfaces.Services
{
    public interface ILoginService
    {
        Login Add(Login entity);
        void Update(Login entity);
        void Remove(Login entity);
        Login GetById(int id);
        Login Authenticate(string username, string password);
        Login GetByUserNameAndPassword(string username, string password);
    }
}
