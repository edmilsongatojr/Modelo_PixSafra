using BCrypt.Net;
using Modelo_PixSafra.Enumeradores;
using Modelo_PixSafra.Services;
using RestSharp;

namespace Modelo_PixSafra.Models.Security
{
    public class Token
    {
        public string GeneratedToken { get; set; }
        public string RefreshToken { get; set; }
        public bool Success { get; set; }
        public object[] Errors { get; set; }
        public string TraceKey { get; set; }

        public Token ObterToken(string merchantToken, int? Timeout)
        {
            var urlPortal = string.Concat(EnumUrlEndpointsHom.Portal.GetDescription(), EnumEndpointsHom.GenerateToken.GetDescription());
            var headers = new Dictionary<string, string>(){
                { "MerchantToken", merchantToken}
        };
            var ResponseToken = SafraAPIService.Post<Token>(urlPortal, headers, null);

            return ResponseToken;
        }
    }
}



