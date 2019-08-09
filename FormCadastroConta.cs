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
        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }
        private void BotaoCadastro_Click(object sender, EventArgs e)
        {
            Conta novaConta;
            if (tipoConta == "Conta Corrente")
            {
                novaConta = new ContaCorrente();
            }
            else
            {
                novaConta = new ContaPoupanca();
            }

            novaConta.Titular = new Cliente(textoCadastraTitular.Text);
            novaConta.Numero = Convert.ToInt32(textoCadastraNumero.Text);

            this.formPrincipal.AdicionaConta(novaConta);
            this.Close();
        }

        private void comboTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoConta = comboTipoConta.SelectedItem.ToString();
        }
    }
}
