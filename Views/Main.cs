using Modelo_PixSafra.Services;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
using RestSharp;
using Modelo_PixSafra.Models.Security;

namespace Modelo_PixSafra
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnTestes_Click(object sender, EventArgs e)
        {
            try
            {
                ConfiguracaoService.GeraJsonEndpointsPadrao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas ao gerar arquivo!");
                Console.WriteLine($"Encontramos um problema.\nMotivo: {ex.Message}");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void BtnGerarToken_Click(object sender, EventArgs e)
        {
            SafraAPIService service = new SafraAPIService("mk_qMhiH9yhLUK2ntqcRmgDZw");
            Token token = service.ObterToken(service.GeraToken(null));
            TxtRetorno.Text = token.GeneratedToken.ToString();
        }
    }
}