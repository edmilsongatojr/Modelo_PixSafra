namespace Modelo_PixSafra.Models.Pix.Response
{
    public class PixResponse
    {

        public PixDadosRetorno Charge { get; set; }
        public bool Success { get; set; }
        public object[] Errors { get; set; }
        public string TraceKey { get; set; }


    }
}
