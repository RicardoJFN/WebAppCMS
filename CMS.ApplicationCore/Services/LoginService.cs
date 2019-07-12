using CMS.ApplicationCore.Entity;
using CMS.ApplicationCore.Interfaces.Services;
using CMS.Infrastructure.Helpers;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CMS.ApplicationCore.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginService _loginService;
        private readonly AppSettings _appSettings;

        public LoginService(ILoginService loginService, IOptions<AppSettings> appSettings)
        {
            _loginService = loginService;
            _appSettings = appSettings.Value;
        }

        public Login Add(Login entity)
        {
            return _loginService.Add(entity);
        }

        public Login Authenticate(string username, string password)
        {
            var user = GetByUserNameAndPassword(username, password);

            if (user == null)
                return null;

            var token = ReturnSecurityToken(_appSettings.Secret, user.Id);

            var tokenHandler = new JwtSecurityTokenHandler();
            user.Token = tokenHandler.WriteToken(token);

            user.Password = null;

            return user;
        }

        public Login GetById(int id)
        {
            return _loginService.GetById(id);
        }

        public Login GetByUserNameAndPassword(string username, string password)
        {
            return _loginService.GetByUserNameAndPassword(username, password);
        }

        public void Remove(Login entity)
        {
            _loginService.Remove(entity);
        }

        public void Update(Login entity)
        {
            _loginService.Update(entity);
        }

        private SecurityToken ReturnSecurityToken(string secret, int id)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            return tokenHandler.CreateToken(tokenDescriptor);

        } 
        
    }
}
