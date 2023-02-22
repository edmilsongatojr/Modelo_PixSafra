namespace Modelo_PixSafra.Views
{
    partial class FCobrancaPix
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtRetornoPix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QRcodePix = new System.Windows.Forms.PictureBox();
            this.BtnReceberPix = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtValorPix = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.QRcodePix)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtRetornoPix
            // 
            this.TxtRetornoPix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRetornoPix.Location = new System.Drawing.Point(12, 314);
            this.TxtRetornoPix.Multiline = true;
            this.TxtRetornoPix.Name = "TxtRetornoPix";
            this.TxtRetornoPix.Size = new System.Drawing.Size(462, 301);
            this.TxtRetornoPix.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Retorno:";
            // 
            // QRcodePix
            // 
            this.QRcodePix.BackColor = System.Drawing.SystemColors.ControlLight;
            this.QRcodePix.Location = new System.Drawing.Point(224, 28);
            this.QRcodePix.Name = "QRcodePix";
            this.QRcodePix.Size = new System.Drawing.Size(215, 215);
            this.QRcodePix.TabIndex = 2;
            this.QRcodePix.TabStop = false;
            // 
            // BtnReceberPix
            // 
            this.BtnReceberPix.Location = new System.Drawing.Point(480, 361);
            this.BtnReceberPix.Name = "BtnReceberPix";
            this.BtnReceberPix.Size = new System.Drawing.Size(169, 51);
            this.BtnReceberPix.TabIndex = 3;
            this.BtnReceberPix.Text = "RECEBER";
            this.BtnReceberPix.UseVisualStyleBackColor = true;
            this.BtnReceberPix.Click += new System.EventHandler(this.BtnReceberPix_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor:";
            // 
            // TxtValorPix
            // 
            this.TxtValorPix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtValorPix.Location = new System.Drawing.Point(522, 323);
            this.TxtValorPix.Name = "TxtValorPix";
            this.TxtValorPix.Size = new System.Drawing.Size(76, 23);
            this.TxtValorPix.TabIndex = 5;
            this.TxtValorPix.Text = "1";
            // 
            // FCobrancaPix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 627);
            this.Controls.Add(this.TxtValorPix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnReceberPix);
            this.Controls.Add(this.QRcodePix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRetornoPix);
            this.Name = "FCobrancaPix";
            this.Text = "Cobrança PIX | Safra";
            ((System.ComponentModel.ISupportInitialize)(this.QRcodePix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtRetornoPix;
        private Label label1;
        private PictureBox QRcodePix;
        private Button BtnReceberPix;
        private Label label2;
        private TextBox TxtValorPix;
    }
}