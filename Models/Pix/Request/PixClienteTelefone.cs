namespace Modelo_PixSafra.Models.Pix.Request
{
    public class PixClienteTelefone
    {
        public string Number { get; set; }
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public int Type { get; set; }
    }
}
