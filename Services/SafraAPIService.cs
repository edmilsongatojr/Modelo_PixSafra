using Modelo_PixSafra.Enumeradores;
using Modelo_PixSafra.Models.Security;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;

namespace Modelo_PixSafra.Services
{
    public class SafraAPIService
    {

        public static T Get<T>(string url, Dictionary<string, string> headers, string? resource) where T : new()
        {
            var client = new RestClient(url);
            var request = new RestRequest(resource);
            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Key, header.Value);
                }
            }
            var response = client.Execute<T>(request);
            return response.Data;
        }
        public static T Post<T>(string url, Dictionary<string, string>? headers, string requestObject) where T : new()
        {
            var client = new RestClient(url);
            var request = new RestRequest("", Method.Post);
            if (!string.IsNullOrEmpty(requestObject)) request.AddParameter("application/json", requestObject, ParameterType.RequestBody);

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.AddHeader(header.Key, header.Value);
                }
            }
            var response = client.Execute<T>(request);
            return response.Data;
        }
    }
}






