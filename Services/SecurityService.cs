using Modelo_PixSafra.Models.Security;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_PixSafra.Services
{
    public class SecurityService
    {
        private string salt = BCrypt.Net.BCrypt.GenerateSalt();

        private string token = "";

        public string Salt { get => salt; private set => salt = value; }
        public string Token { get => token; private set => token = value; }


        public SecurityService(string token)
        {
            Token = token;
        }
        public string BCryptToken()
        {
            var bCryptToken = string.Concat(Token, Salt);
            string hashBCryptToken = HashPassword(bCryptToken);
            Authorization authorizationSafra = new(hashBCryptToken);
            return authorizationSafra.Auth;
        }
        private static string HashPassword(string bCryptToken)
        {
            return BCrypt.Net.BCrypt.HashPassword(bCryptToken);
        }

       
    }
}
