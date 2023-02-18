using Modelo_PixSafra.Enumeradores;
using Modelo_PixSafra.Models;
using Newtonsoft.Json;

namespace Modelo_PixSafra.Services
{
    public class ConfiguracaoService
    {

        public ConfiguracaoService() { }

        public static void GeraJsonEndpointsPadrao()
        {
            try
            {
                var caminhoJson = "ConfiguracaoEndpointsSafra.json";
                EndpointsSafra endpointSafra = new();
                using (StreamWriter fluxoArquivo = new StreamWriter(caminhoJson))
                {
                    var jsonEndpoints = JsonConvert.SerializeObject(endpointSafra.InserirEndpointPadrao());

                    fluxoArquivo.Write(jsonEndpoints);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Falha na Geração do JSON do EndpointsSafra.\nMotivo: {ex.Message}");
            }
        }

       
    }
}

