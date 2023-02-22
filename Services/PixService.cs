using Modelo_PixSafra.Enumeradores;
using Modelo_PixSafra.Models.Pix.Request;
using Modelo_PixSafra.Models.Pix.Response;
using Modelo_PixSafra.Models.Security;
using Newtonsoft.Json;
using RestSharp;

namespace Modelo_PixSafra.Services
{
    public class PixService
    {
        public string MerchantToken { get; private set; }
        public string Cnpj { get; private set; }

        public PixService(string cnpj, string merchantToken)
        {
            MerchantToken = merchantToken;
            Cnpj = cnpj;
        }

        public PixResponse GerarCobrancaPix(string pixRequest)
        {
            AuthorizationSafra authorizationSafra = new();
            var bearerToken = authorizationSafra.ObterAuth("00462691000145", "mk_qMhiH9yhLUK2ntqcRmgDZw", null);
            var urlEndpoint = string.Concat(EnumUrlEndpointsHom.Gateway.GetDescription(), EnumEndpointsHom.Pix.GetDescription());
            var headers = new Dictionary<string, string>()
            {
                { "Authorization", $"Bearer {bearerToken.AccessToken}"},
                { "Content-Type", "application/json"}
            };
            var RetornoPixResponse = SafraAPIService.Post<PixResponse>(urlEndpoint, headers, pixRequest);
            return RetornoPixResponse;
        }
    }
}
