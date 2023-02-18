namespace Modelo_PixSafra
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnTestes = new System.Windows.Forms.Button();
            this.BtnGerarToken = new System.Windows.Forms.Button();
            this.TxtRetorno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnTestes
            // 
            this.BtnTestes.Location = new System.Drawing.Point(494, 407);
            this.BtnTestes.Name = "BtnTestes";
            this.BtnTestes.Size = new System.Drawing.Size(184, 33);
            this.BtnTestes.TabIndex = 0;
            this.BtnTestes.Text = "TESTAR";
            this.BtnTestes.UseVisualStyleBackColor = true;
            this.BtnTestes.Click += new System.EventHandler(this.BtnTestes_Click);
            // 
            // BtnGerarToken
            // 
            this.BtnGerarToken.Location = new System.Drawing.Point(494, 27);
            this.BtnGerarToken.Name = "BtnGerarToken";
            this.BtnGerarToken.Size = new System.Drawing.Size(184, 33);
            this.BtnGerarToken.TabIndex = 0;
            this.BtnGerarToken.Text = "GERAR TOKEN";
            this.BtnGerarToken.UseVisualStyleBackColor = true;
            this.BtnGerarToken.Click += new System.EventHandler(this.BtnGerarToken_Click);
            // 
            // TxtRetorno
            // 
            this.TxtRetorno.Location = new System.Drawing.Point(12, 27);
            this.TxtRetorno.Multiline = true;
            this.TxtRetorno.Name = "TxtRetorno";
            this.TxtRetorno.Size = new System.Drawing.Size(476, 413);
            this.TxtRetorno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Retorno";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRetorno);
            this.Controls.Add(this.BtnGerarToken);
            this.Controls.Add(this.BtnTestes);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BtnTestes;
        private Button BtnGerarToken;
        private TextBox TxtRetorno;
        private Label label1;
        //private Label LblRetornos;
        //private GroupBox groupBox1;
    }
}