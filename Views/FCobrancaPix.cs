using MessagingToolkit.QRCode.Codec;
using Modelo_PixSafra.Models.Pix.Request;
using Modelo_PixSafra.Models.Pix.Response;
using Modelo_PixSafra.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo_PixSafra.Views
{
    public partial class FCobrancaPix : Form
    {
        public FCobrancaPix()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnReceberPix_Click(object sender, EventArgs e)
        {
            PixResponse pixResponse = new PixResponse();
            try
            {

                var pixRequest = new PixRequest()
                {
                    Charge = new PixCobranca()
                    {
                        MerchantChargeId = "TESTE0002043",

                        Customer = new PixCliente()
                        {
                            Name = "Edmilson Gato Junior",
                            Email = "edmilson.gato@saurus.com.br",
                            Document = "37127781800",
                            DocumentType = 1,
                            Phone = new PixClienteTelefone()
                            {
                                Number = "996563684",
                                CountryCode = "55",
                                AreaCode = "13",
                                Type = 1,
                            }
                        },
                        Transactions = new List<PixTransacaoEnvio>()
                        {
                            new PixTransacaoEnvio()
                            {
                                Amount = Convert.ToInt32(TxtValorPix.Text),
                            }
                        }.ToArray(),

                        Metadata = new List<PixMetadata>()
                        {
                            new PixMetadata() {
                                Key = "Key_Sample",
                                Value = "Value_Sample"
                            }
                        }.ToArray(),
                        Source = 1
                    }
                };
                var jsonPixRequest = JsonConvert.SerializeObject(pixRequest);
                PixService pixService = new("00462691000145", "mk_qMhiH9yhLUK2ntqcRmgDZw");
                pixResponse = pixService.GerarCobrancaPix(jsonPixRequest);


                //var caminho = "retpix.json";
                //using (StreamReader reader = new StreamReader(caminho))
                //{
                //    var json = reader.ReadToEnd();
                //    pixResponse = JsonConvert.DeserializeObject<PixResponse>(json);
                //};
                QRCodeEncoder encoder = new QRCodeEncoder();
                encoder.QRCodeScale = 4;
                encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
                foreach (var item in pixResponse.Charge.Transactions)
                {
                    Bitmap qrCodeBitmap = encoder.Encode(item.QrCode);
                    QRcodePix.Image = qrCodeBitmap;
                    TxtRetornoPix.Text = $"Pix Copia e Cola: \n{item.QrCode}" +
                        $"\n Valor: {item.Amount}" +
                        $"\n\n\n Banco: {item.BankIssuerId}";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao Gerar Cobrança PIX.\n Motivo: {ex.Message}");
            }
            //TxtRetornoPix.Text = $"Sucesso: {pixResponse.Success}\n";
            for (int i = 0; i < pixResponse.Errors.Length; i++)
            {
                TxtRetornoPix.Text += $"\n {pixResponse.Errors[i]}";
            }
        }
    }
}
