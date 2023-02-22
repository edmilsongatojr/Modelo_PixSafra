using Modelo_PixSafra.Enumeradores;
using Modelo_PixSafra.Services;
using Newtonsoft.Json;
using RestSharp;

namespace Modelo_PixSafra.Models.Security
{
    public class AuthorizationSafra
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public bool Success { get; set; }
        public object[] Errors { get; set; }
        public string TraceKey { get; set; }

        public AuthorizationSafra ObterAuth(string cnpj, string merchantToken, int? Timeout)
        {
            SecurityService securityService = new SecurityService(cnpj, merchantToken);
            var bCrypt = securityService.BCryptToken();
            var urlPortal = string.Concat(EnumUrlEndpointsHom.Gateway.GetDescription(), EnumEndpointsHom.Auth.GetDescription());
            var headers = new Dictionary<string, string>(){
                { "Authorization", bCrypt},
                { "merchantCredential", cnpj}
            };
            var ResponseAuth = SafraAPIService.Post<AuthorizationSafra>(urlPortal, headers, null);

            return ResponseAuth;
        }
    }
}
