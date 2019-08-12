using Banco.Busca;
using Banco.Contas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal = new Form1();
        private string tipoConta;
        private ICollection<string> devedores;
        public FormCadastroConta(Form1 formPrincipal)
        {

            this.formPrincipal = formPrincipal;
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraList();
        }
        private void BotaoCadastro_Click(object sender, EventArgs e)
        {
            Conta novaConta;
            if (tipoConta == "Conta Corrente")
            {
                novaConta = new ContaCorrente();
            }
            else if (tipoConta == "Conta Poupança")
            {
                novaConta = new ContaPoupanca();
            }
            else if (tipoConta == "Conta de Investimentos")
            {
                novaConta = new ContaInvestimento();
            }
            else
            {
                MessageBox.Show("Escolha um tipo de conta");
                return;
            }
            string titular = textoCadastraTitular.Text;
            novaConta.Titular = new Cliente(titular);
            bool ehDevedor = this.devedores.Contains(titular);
            if (!ehDevedor)
            {
                this.formPrincipal.AdicionaConta(novaConta);
                this.Close();
            }
            else
            {
                MessageBox.Show("devedor");
            }
        }
        private void comboTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoConta = comboTipoConta.SelectedItem.ToString();
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            textoCadastroNumero.Text = Convert.ToString(Conta.ProximaConta().ToString("X5"));
        }
    }
}
