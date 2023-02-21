using Modelo_PixSafra.Enumeradores;
using Modelo_PixSafra.Models.Security;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace Modelo_PixSafra.Services
{
    public class SafraAPIService
    {
        private string merchantToken = string.Empty;
        private string token = string.Empty;

        public string MerchantToken { get => merchantToken; private set => merchantToken = value; }
        public string Token { get => token; private set => token = value; }

        public SafraAPIService(string merchantToken)
        {
            MerchantToken = merchantToken;
        }

        public RestResponse GeraToken(int? Timeout)
        {
            try
            {
                var urlPortal = EnumUrlEndpointsHom.Portal.GetDescription();
                var endpoint = EnumEndpointsHom.GenerateToken.GetDescription();
                var client = new RestClient(urlPortal);
                var request = new RestRequest(endpoint, Method.Post);
                request.AddHeader("MerchantToken", MerchantToken);

                if (Timeout.Equals(0) || Timeout.Equals(null)) request.Timeout = 0;
                else request.Timeout = Convert.ToInt32(Timeout);

                RestResponse response = client.ExecutePost(request);
                ObterToken(response);

                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Falha ao GerarToken. Motivo: {ex.Message}");
                return null;
            }
        }
        public Token ObterToken(RestResponse response)
        {
            try
            {
                var jsonResponseToken = JsonConvert.DeserializeObject<Token>(response.Content);
                return jsonResponseToken;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Falha ao Obter Token. Motivo: {ex.Message}");
                return null;
            }

        }

        public RestResponse ComunicaAPISafra(string urlEndpoint, string endpoint)
        {
            RestRequest request = NovaRequisicao();
            RestClient client = RestClientAPI(urlEndpoint, endpoint);
            RestResponse response = client.Execute(request);
            try
            {
                if (!string.IsNullOrEmpty(endpoint))
                {
                    return response;
                }
                else
                {
                    Console.WriteLine("Não foi possivel iniciar comunicação, Caminho 'Endpoint' vazio.");
                    return response;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private RestClient RestClientAPI(string urlEndpoint, string endpoint)
        {
            return new RestClient(ConcatenaEndpoint(urlEndpoint, endpoint));
        }

        private string ConcatenaEndpoint(string urlEndpoint, string endpoint)
        {
            return string.Concat(urlEndpoint, endpoint);
        }
        private static RestRequest NovaRequisicao()
        {
            return new RestRequest();
        }
    }
}
