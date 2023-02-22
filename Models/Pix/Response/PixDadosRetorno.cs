namespace Modelo_PixSafra.Models.Pix.Response
{
    public class PixDadosRetorno
    {
        public string MerchantChargeId { get; set; }
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string ChargeStatus { get; set; }
        public PixTransacaoRetorno[] Transactions { get; set; }
        public string Nsu { get; set; }
    }
}
