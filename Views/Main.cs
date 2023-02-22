using Modelo_PixSafra.Services;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
using RestSharp;
using Modelo_PixSafra.Models.Security;
using Newtonsoft.Json.Linq;
using Modelo_PixSafra.Views;

namespace Modelo_PixSafra
{
    public partial class Main : Form
    {
        private string merchantToken = string.Empty;
        private string cnpj = string.Empty;
        private string MerchantToken { get => merchantToken; set => merchantToken = value; }
        private string Cnpj { get => cnpj; set => cnpj = value; }

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
            MerchantToken = "mk_qMhiH9yhLUK2ntqcRmgDZw";
            Cnpj = "00462691000145";
        }

        private void BtnGerarToken_Click(object sender, EventArgs e)
        {
            Token token = new();
            token = token.ObterToken(MerchantToken,null);
            TxtRetorno.Text = token.GeneratedToken.ToString();
        }

        private void BtnGerarAuth_Click(object sender, EventArgs e)
        {
            AuthorizationSafra authorization = new AuthorizationSafra();
            authorization = authorization.ObterAuth(Cnpj, MerchantToken, null);
            if (authorization != null)
            {
                if (authorization.Success == true)
                {
                    TxtRetorno.Text = "Sucesso!\n\n";
                    TxtRetorno.Text = authorization.AccessToken;

                }
                else
                {
                    foreach (var error in authorization.Errors)
                    {
                        TxtRetorno.Text = error.ToString();
                    }
                }
            }
            else
            {
                TxtRetorno.Text = "Objeto Auth nulo";
            }

        }

        private void BtnPix_Click(object sender, EventArgs e)
        {
            FCobrancaPix cobrancaPix= new FCobrancaPix();
            cobrancaPix.Show();
        }
    }
}