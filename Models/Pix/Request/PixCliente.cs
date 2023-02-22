namespace Modelo_PixSafra.Models.Pix.Request
{
    public class PixCliente
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public int DocumentType { get; set; }
        public PixClienteTelefone Phone { get; set; }
    }
}
