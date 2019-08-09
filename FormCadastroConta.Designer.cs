namespace Banco
{
    partial class FormCadastroConta
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
            this.textoTitular = new System.Windows.Forms.Label();
            this.textoNumero = new System.Windows.Forms.Label();
            this.textoCadastraNumero = new System.Windows.Forms.TextBox();
            this.textoCadastraTitular = new System.Windows.Forms.TextBox();
            this.botaoCadastro = new System.Windows.Forms.Button();
            this.comboTipoConta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.AutoSize = true;
            this.textoTitular.Location = new System.Drawing.Point(24, 34);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(48, 17);
            this.textoTitular.TabIndex = 0;
            this.textoTitular.Text = "Titular";
            // 
            // textoNumero
            // 
            this.textoNumero.AutoSize = true;
            this.textoNumero.Location = new System.Drawing.Point(14, 62);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(58, 17);
            this.textoNumero.TabIndex = 1;
            this.textoNumero.Text = "Número";
            // 
            // textoCadastraNumero
            // 
            this.textoCadastraNumero.Location = new System.Drawing.Point(78, 59);
            this.textoCadastraNumero.Name = "textoCadastraNumero";
            this.textoCadastraNumero.Size = new System.Drawing.Size(210, 22);
            this.textoCadastraNumero.TabIndex = 2;
            // 
            // textoCadastraTitular
            // 
            this.textoCadastraTitular.Location = new System.Drawing.Point(78, 31);
            this.textoCadastraTitular.Name = "textoCadastraTitular";
            this.textoCadastraTitular.Size = new System.Drawing.Size(210, 22);
            this.textoCadastraTitular.TabIndex = 1;
            // 
            // botaoCadastro
            // 
            this.botaoCadastro.Location = new System.Drawing.Point(130, 117);
            this.botaoCadastro.Name = "botaoCadastro";
            this.botaoCadastro.Size = new System.Drawing.Size(100, 23);
            this.botaoCadastro.TabIndex = 4;
            this.botaoCadastro.Text = "Cadastrar";
            this.botaoCadastro.UseVisualStyleBackColor = true;
            this.botaoCadastro.Click += new System.EventHandler(this.BotaoCadastro_Click);
            // 
            // comboTipoConta
            // 
            this.comboTipoConta.FormattingEnabled = true;
            this.comboTipoConta.Items.AddRange(new object[] {
            "Conta Poupança",
            "Conta Corrente",
            "Conta de Investimentos"});
            this.comboTipoConta.Location = new System.Drawing.Point(78, 87);
            this.comboTipoConta.Name = "comboTipoConta";
            this.comboTipoConta.Size = new System.Drawing.Size(210, 24);
            this.comboTipoConta.TabIndex = 3;
            this.comboTipoConta.Text = "Selecione o tipo da conta";
            this.comboTipoConta.SelectedIndexChanged += new System.EventHandler(this.comboTipoConta_SelectedIndexChanged);
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 153);
            this.Controls.Add(this.comboTipoConta);
            this.Controls.Add(this.botaoCadastro);
            this.Controls.Add(this.textoCadastraTitular);
            this.Controls.Add(this.textoCadastraNumero);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.textoTitular);
            this.Name = "FormCadastroConta";
            this.Text = "FormCadastroConta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoTitular;
        private System.Windows.Forms.Label textoNumero;
        private System.Windows.Forms.TextBox textoCadastraNumero;
        private System.Windows.Forms.TextBox textoCadastraTitular;
        private System.Windows.Forms.Button botaoCadastro;
        private System.Windows.Forms.ComboBox comboTipoConta;
    }
}