namespace Modelo_PixSafra.Models.Pix.Request
{
    public class PixCobranca
    {
        public string MerchantChargeId { get; set; }
        public PixCliente Customer { get; set; }
        public PixTransacaoEnvio[] Transactions { get; set; }
        public PixMetadata[] Metadata { get; set; }
        public int Source { get; set; }
    }
}
