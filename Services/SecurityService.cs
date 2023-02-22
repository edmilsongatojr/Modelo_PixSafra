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
        public string Salt { get => salt; private set => salt = value; }
        public string MerchantToken { get; private set; }
        public string Cnpj { get; private set; }

        public SecurityService(string cnpj, string merchantToken)
        {
            MerchantToken = merchantToken;
            Cnpj = cnpj;
        }
        public string BCryptToken()
        {
            var bCryptConcatToken = string.Concat(Cnpj, MerchantToken);
            string hashBCryptToken = HashPassword(bCryptConcatToken,Salt);
            return hashBCryptToken;
        }
        private static string HashPassword(string bCryptToken, string salt)
        {
            return BCrypt.Net.BCrypt.HashPassword(bCryptToken,salt);
        }

       
    }
}
