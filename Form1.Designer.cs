namespace Banco
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.botaoDeposita = new System.Windows.Forms.Button();
            this.labelTitular = new System.Windows.Forms.Label();
            this.labelNumeroConta = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoIndice = new System.Windows.Forms.TextBox();
            this.botaoBusca = new System.Windows.Forms.Button();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(141, 43);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(156, 22);
            this.textoTitular.TabIndex = 0;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(141, 71);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(156, 22);
            this.textoNumero.TabIndex = 1;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(141, 99);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(156, 22);
            this.textoSaldo.TabIndex = 2;
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(141, 127);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(156, 22);
            this.textoValor.TabIndex = 3;
            // 
            // botaoDeposita
            // 
            this.botaoDeposita.Location = new System.Drawing.Point(222, 155);
            this.botaoDeposita.Name = "botaoDeposita";
            this.botaoDeposita.Size = new System.Drawing.Size(75, 23);
            this.botaoDeposita.TabIndex = 4;
            this.botaoDeposita.Text = "Deposita";
            this.botaoDeposita.UseVisualStyleBackColor = true;
            this.botaoDeposita.Click += new System.EventHandler(this.botaoDeposita_Click);
            // 
            // labelTitular
            // 
            this.labelTitular.AutoSize = true;
            this.labelTitular.Location = new System.Drawing.Point(87, 46);
            this.labelTitular.Name = "labelTitular";
            this.labelTitular.Size = new System.Drawing.Size(48, 17);
            this.labelTitular.TabIndex = 5;
            this.labelTitular.Text = "Titular";
            // 
            // labelNumeroConta
            // 
            this.labelNumeroConta.AutoSize = true;
            this.labelNumeroConta.Location = new System.Drawing.Point(18, 74);
            this.labelNumeroConta.Name = "labelNumeroConta";
            this.labelNumeroConta.Size = new System.Drawing.Size(117, 17);
            this.labelNumeroConta.TabIndex = 6;
            this.labelNumeroConta.Text = "Número da conta";
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(91, 102);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(44, 17);
            this.labelSaldo.TabIndex = 7;
            this.labelSaldo.Text = "Saldo";
            // 
            // botaoSaque
            // 
            this.botaoSaque.Location = new System.Drawing.Point(141, 155);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(75, 23);
            this.botaoSaque.TabIndex = 8;
            this.botaoSaque.Text = "Saca";
            this.botaoSaque.UseVisualStyleBackColor = true;
            this.botaoSaque.Click += new System.EventHandler(this.botaoSaque_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelTitular);
            this.groupBox1.Controls.Add(this.textoValor);
            this.groupBox1.Controls.Add(this.botaoSaque);
            this.groupBox1.Controls.Add(this.botaoDeposita);
            this.groupBox1.Controls.Add(this.textoTitular);
            this.groupBox1.Controls.Add(this.labelSaldo);
            this.groupBox1.Controls.Add(this.textoNumero);
            this.groupBox1.Controls.Add(this.labelNumeroConta);
            this.groupBox1.Controls.Add(this.textoSaldo);
            this.groupBox1.Location = new System.Drawing.Point(29, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 214);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Valor da operação";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboContas);
            this.groupBox2.Controls.Add(this.botaoBusca);
            this.groupBox2.Controls.Add(this.textoIndice);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(29, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 113);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca de Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Escolha a conta";
            // 
            // textoIndice
            // 
            this.textoIndice.Location = new System.Drawing.Point(141, 22);
            this.textoIndice.Name = "textoIndice";
            this.textoIndice.Size = new System.Drawing.Size(75, 22);
            this.textoIndice.TabIndex = 1;
            // 
            // botaoBusca
            // 
            this.botaoBusca.Location = new System.Drawing.Point(222, 21);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(75, 23);
            this.botaoBusca.TabIndex = 2;
            this.botaoBusca.Text = "Buscar";
            this.botaoBusca.UseVisualStyleBackColor = true;
            this.botaoBusca.Click += new System.EventHandler(this.BotaoBusca_Click);
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(141, 59);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(156, 24);
            this.comboContas.TabIndex = 11;
            this.comboContas.Text = "Escolha a conta";
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.ComboContas_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 701);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Button botaoDeposita;
        private System.Windows.Forms.Label labelTitular;
        private System.Windows.Forms.Label labelNumeroConta;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button botaoBusca;
        private System.Windows.Forms.TextBox textoIndice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboContas;
    }
}

