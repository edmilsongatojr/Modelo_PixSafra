using Modelo_PixSafra.Services;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
using RestSharp;

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
            SafraAPIService service = new SafraAPIService("123");
            RestResponse response = service.GeraToken(null);
            string content = response.Content;
            if (response.ResponseStatus == ResponseStatus.Error)
            {
                // Cria um novo objeto XmlDocument
                WebBrowser webBrowser = new WebBrowser();
                webBrowser.Navigate("about:blank");
                webBrowser.Document.OpenNew(false);
                webBrowser.Document.Write(content);
                webBrowser.Refresh();
                if (!string.IsNullOrEmpty(webBrowser.DocumentText))
                {
                    string htmlFormatado = webBrowser.DocumentText;
                    content = htmlFormatado;
                }
                else
                {
                    content = "Arquivo Vazio ou Null";
                }
            }
            
            TxtRetorno.Text = $"{response.StatusDescription.ToUpper()}\n" + content;
        }
    }
}