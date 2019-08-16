namespace Banco
{
    partial class FormRelatorios
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
            this.listaResultado = new System.Windows.Forms.ListBox();
            this.botaoFiltroSaldo = new System.Windows.Forms.Button();
            this.botaoFiltraContasAntigas = new System.Windows.Forms.Button();
            this.GroupBoxResumo = new System.Windows.Forms.GroupBox();
            this.labelMaiorSaldo = new System.Windows.Forms.Label();
            this.labelSaldoTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoOrdenaAlfabeticamente = new System.Windows.Forms.Button();
            this.GroupBoxResumo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaResultado
            // 
            this.listaResultado.FormattingEnabled = true;
            this.listaResultado.ItemHeight = 16;
            this.listaResultado.Location = new System.Drawing.Point(323, 12);
            this.listaResultado.Name = "listaResultado";
            this.listaResultado.Size = new System.Drawing.Size(453, 388);
            this.listaResultado.TabIndex = 0;
            // 
            // botaoFiltroSaldo
            // 
            this.botaoFiltroSaldo.Location = new System.Drawing.Point(12, 69);
            this.botaoFiltroSaldo.Name = "botaoFiltroSaldo";
            this.botaoFiltroSaldo.Size = new System.Drawing.Size(237, 23);
            this.botaoFiltroSaldo.TabIndex = 1;
            this.botaoFiltroSaldo.Text = "Saldo > 500";
            this.botaoFiltroSaldo.UseVisualStyleBackColor = true;
            this.botaoFiltroSaldo.Click += new System.EventHandler(this.BotaoFiltroSaldo_Click);
            // 
            // botaoFiltraContasAntigas
            // 
            this.botaoFiltraContasAntigas.Location = new System.Drawing.Point(12, 98);
            this.botaoFiltraContasAntigas.Name = "botaoFiltraContasAntigas";
            this.botaoFiltraContasAntigas.Size = new System.Drawing.Size(237, 23);
            this.botaoFiltraContasAntigas.TabIndex = 2;
            this.botaoFiltraContasAntigas.Text = "Contas antigas com Saldo > 1000";
            this.botaoFiltraContasAntigas.UseVisualStyleBackColor = true;
            this.botaoFiltraContasAntigas.Click += new System.EventHandler(this.BotaoFiltraContasAntigas_Click);
            // 
            // GroupBoxResumo
            // 
            this.GroupBoxResumo.Controls.Add(this.labelMaiorSaldo);
            this.GroupBoxResumo.Controls.Add(this.labelSaldoTotal);
            this.GroupBoxResumo.Controls.Add(this.label2);
            this.GroupBoxResumo.Controls.Add(this.label1);
            this.GroupBoxResumo.Location = new System.Drawing.Point(12, 336);
            this.GroupBoxResumo.Name = "GroupBoxResumo";
            this.GroupBoxResumo.Size = new System.Drawing.Size(305, 96);
            this.GroupBoxResumo.TabIndex = 3;
            this.GroupBoxResumo.TabStop = false;
            this.GroupBoxResumo.Text = "Resumo";
            // 
            // labelMaiorSaldo
            // 
            this.labelMaiorSaldo.AutoSize = true;
            this.labelMaiorSaldo.Location = new System.Drawing.Point(148, 63);
            this.labelMaiorSaldo.Name = "labelMaiorSaldo";
            this.labelMaiorSaldo.Size = new System.Drawing.Size(46, 17);
            this.labelMaiorSaldo.TabIndex = 3;
            this.labelMaiorSaldo.Text = "label4";
            // 
            // labelSaldoTotal
            // 
            this.labelSaldoTotal.AutoSize = true;
            this.labelSaldoTotal.Location = new System.Drawing.Point(148, 37);
            this.labelSaldoTotal.Name = "labelSaldoTotal";
            this.labelSaldoTotal.Size = new System.Drawing.Size(46, 17);
            this.labelSaldoTotal.TabIndex = 2;
            this.labelSaldoTotal.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maior Saldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo Total";
            // 
            // botaoOrdenaAlfabeticamente
            // 
            this.botaoOrdenaAlfabeticamente.Location = new System.Drawing.Point(323, 409);
            this.botaoOrdenaAlfabeticamente.Name = "botaoOrdenaAlfabeticamente";
            this.botaoOrdenaAlfabeticamente.Size = new System.Drawing.Size(152, 23);
            this.botaoOrdenaAlfabeticamente.TabIndex = 4;
            this.botaoOrdenaAlfabeticamente.Text = "Ordem alfabética";
            this.botaoOrdenaAlfabeticamente.UseVisualStyleBackColor = true;
            this.botaoOrdenaAlfabeticamente.Click += new System.EventHandler(this.BotaoOrdenaAlfabeticamente_Click);
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoOrdenaAlfabeticamente);
            this.Controls.Add(this.GroupBoxResumo);
            this.Controls.Add(this.botaoFiltraContasAntigas);
            this.Controls.Add(this.botaoFiltroSaldo);
            this.Controls.Add(this.listaResultado);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.GroupBoxResumo.ResumeLayout(false);
            this.GroupBoxResumo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaResultado;
        private System.Windows.Forms.Button botaoFiltroSaldo;
        private System.Windows.Forms.Button botaoFiltraContasAntigas;
        private System.Windows.Forms.GroupBox GroupBoxResumo;
        private System.Windows.Forms.Label labelMaiorSaldo;
        private System.Windows.Forms.Label labelSaldoTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoOrdenaAlfabeticamente;
    }
}