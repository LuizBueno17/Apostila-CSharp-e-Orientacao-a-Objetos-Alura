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
    public partial class Form1 : Form
    {
        private Conta conta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta c = new ContaPoupanca();
            c.Numero = 1;
            Cliente cliente = new Cliente("victor");
            c.Titular = cliente;

            this.conta = new ContaPoupanca();

            textoTitular.Text = c.Titular.Nome;
            textoNumero.Text = Convert.ToString(c.Numero);
            textoSaldo.Text = Convert.ToString(c.Saldo);

            TotalizadorDeContas totalizadorDeContas = new TotalizadorDeContas();

            Conta c1 = new ContaPoupanca();
            c1.Deposita(100.0);
            c1.Saca(50.0);
            totalizadorDeContas.Soma(c1);
            MessageBox.Show("conta poupança = " + c1.Saldo);
            Conta c2 = new ContaCorrente();
            c2.Deposita(100.0);
            c2.Saca(50.0);
            totalizadorDeContas.Soma(c2);
            MessageBox.Show("conta = " + c2.Saldo);
            MessageBox.Show("Saldo total das contas c1 e c2 = " + totalizadorDeContas.ValorTotal);
        }

        private void botaoDeposita_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            conta.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            //MessageBox.Show("Sucesso");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.conta.Saca(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            //MessageBox.Show("Sucesso");
        }
    }
}
