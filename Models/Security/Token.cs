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


       
    }
}

   

