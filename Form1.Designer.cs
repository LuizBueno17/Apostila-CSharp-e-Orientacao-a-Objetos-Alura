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
            this.botaoTransfere = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.contaTransferencia = new System.Windows.Forms.GroupBox();
            this.comboContaRecebeTransferencia = new System.Windows.Forms.ComboBox();
            this.textoSaldoTransferencia = new System.Windows.Forms.TextBox();
            this.textoNumeroTransferencia = new System.Windows.Forms.TextBox();
            this.textoTitularTransferencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoNovaConta = new System.Windows.Forms.Button();
            this.botaoImpostos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contaTransferencia.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.botaoImpostos);
            this.groupBox1.Controls.Add(this.botaoTransfere);
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
            this.groupBox1.Location = new System.Drawing.Point(29, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 220);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // botaoTransfere
            // 
            this.botaoTransfere.Location = new System.Drawing.Point(33, 155);
            this.botaoTransfere.Name = "botaoTransfere";
            this.botaoTransfere.Size = new System.Drawing.Size(102, 23);
            this.botaoTransfere.TabIndex = 10;
            this.botaoTransfere.Text = "Transfere";
            this.botaoTransfere.UseVisualStyleBackColor = true;
            this.botaoTransfere.Click += new System.EventHandler(this.BotaoTransfere_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(29, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 62);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca de Conta";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(141, 21);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(156, 24);
            this.comboContas.TabIndex = 11;
            this.comboContas.Text = "Escolha a conta";
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.ComboContas_SelectedIndexChanged);
            // 
            // contaTransferencia
            // 
            this.contaTransferencia.Controls.Add(this.comboContaRecebeTransferencia);
            this.contaTransferencia.Controls.Add(this.textoSaldoTransferencia);
            this.contaTransferencia.Controls.Add(this.textoNumeroTransferencia);
            this.contaTransferencia.Controls.Add(this.textoTitularTransferencia);
            this.contaTransferencia.Controls.Add(this.label4);
            this.contaTransferencia.Controls.Add(this.label3);
            this.contaTransferencia.Controls.Add(this.label2);
            this.contaTransferencia.Location = new System.Drawing.Point(371, 99);
            this.contaTransferencia.Name = "contaTransferencia";
            this.contaTransferencia.Size = new System.Drawing.Size(322, 183);
            this.contaTransferencia.TabIndex = 11;
            this.contaTransferencia.TabStop = false;
            this.contaTransferencia.Text = "Conta a transferir";
            // 
            // comboContaRecebeTransferencia
            // 
            this.comboContaRecebeTransferencia.FormattingEnabled = true;
            this.comboContaRecebeTransferencia.Location = new System.Drawing.Point(141, 36);
            this.comboContaRecebeTransferencia.Name = "comboContaRecebeTransferencia";
            this.comboContaRecebeTransferencia.Size = new System.Drawing.Size(156, 24);
            this.comboContaRecebeTransferencia.TabIndex = 6;
            this.comboContaRecebeTransferencia.Text = "Escolha a conta";
            this.comboContaRecebeTransferencia.SelectedIndexChanged += new System.EventHandler(this.ComboContaRecebeTransferencia_SelectedIndexChanged);
            // 
            // textoSaldoTransferencia
            // 
            this.textoSaldoTransferencia.Location = new System.Drawing.Point(141, 141);
            this.textoSaldoTransferencia.Name = "textoSaldoTransferencia";
            this.textoSaldoTransferencia.Size = new System.Drawing.Size(156, 22);
            this.textoSaldoTransferencia.TabIndex = 5;
            // 
            // textoNumeroTransferencia
            // 
            this.textoNumeroTransferencia.Location = new System.Drawing.Point(141, 113);
            this.textoNumeroTransferencia.Name = "textoNumeroTransferencia";
            this.textoNumeroTransferencia.Size = new System.Drawing.Size(156, 22);
            this.textoNumeroTransferencia.TabIndex = 4;
            // 
            // textoTitularTransferencia
            // 
            this.textoTitularTransferencia.Location = new System.Drawing.Point(141, 85);
            this.textoTitularTransferencia.Name = "textoTitularTransferencia";
            this.textoTitularTransferencia.Size = new System.Drawing.Size(156, 22);
            this.textoTitularTransferencia.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Número da conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titular";
            // 
            // botaoNovaConta
            // 
            this.botaoNovaConta.Location = new System.Drawing.Point(62, 325);
            this.botaoNovaConta.Name = "botaoNovaConta";
            this.botaoNovaConta.Size = new System.Drawing.Size(102, 23);
            this.botaoNovaConta.TabIndex = 11;
            this.botaoNovaConta.Text = "Nova Conta";
            this.botaoNovaConta.UseVisualStyleBackColor = true;
            this.botaoNovaConta.Click += new System.EventHandler(this.BotaoNovaConta_Click);
            // 
            // botaoImpostos
            // 
            this.botaoImpostos.Location = new System.Drawing.Point(33, 189);
            this.botaoImpostos.Name = "botaoImpostos";
            this.botaoImpostos.Size = new System.Drawing.Size(183, 23);
            this.botaoImpostos.TabIndex = 11;
            this.botaoImpostos.Text = "Calcular Impostos";
            this.botaoImpostos.UseVisualStyleBackColor = true;
            this.botaoImpostos.Click += new System.EventHandler(this.BotaoImpostos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 701);
            this.Controls.Add(this.botaoNovaConta);
            this.Controls.Add(this.contaTransferencia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.contaTransferencia.ResumeLayout(false);
            this.contaTransferencia.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.GroupBox contaTransferencia;
        private System.Windows.Forms.ComboBox comboContaRecebeTransferencia;
        private System.Windows.Forms.TextBox textoSaldoTransferencia;
        private System.Windows.Forms.TextBox textoNumeroTransferencia;
        private System.Windows.Forms.TextBox textoTitularTransferencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botaoTransfere;
        private System.Windows.Forms.Button botaoNovaConta;
        private System.Windows.Forms.Button botaoImpostos;
    }
}

