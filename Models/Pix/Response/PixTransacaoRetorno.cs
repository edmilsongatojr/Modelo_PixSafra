namespace Modelo_PixSafra.Models.Pix.Response
{
    public class PixTransacaoRetorno
    {
        public string AditumNumber { get; set; }
        public string QrCode { get; set; }
        public string QrCodeBase64 { get; set; }
        public string RransactionId { get; set; }
        public string PaymentType { get; set; }
        public int Amount { get; set; }
        public string TransactionStatus { get; set; }
        public string Acquirer { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string BankIssuerId { get; set; }
    }
}
