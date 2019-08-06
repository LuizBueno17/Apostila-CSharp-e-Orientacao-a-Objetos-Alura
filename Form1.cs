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
        private Conta[] contas;
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

            contas = new Conta[3];

            this.contas[0] = new Conta();
            this.contas[0].Titular = new Cliente("victor");
            this.contas[0].Numero = 1;
            this.contas[1] = new ContaPoupanca();
            this.contas[1].Titular = new Cliente("mauricio");
            this.contas[1].Numero = 2;
            this.contas[2] = new ContaCorrente();
            this.contas[2].Titular = new Cliente("osni");
            this.contas[2].Numero = 3;

            foreach (Conta conta in contas)
            {
                comboContas.Items.Add(conta.Titular.Nome);
                comboContaRecebeTransferencia.Items.Add(conta.Titular.Nome);
            }

            //TotalizadorDeContas totalizadorDeContas = new TotalizadorDeContas();

            //Conta c1 = new ContaPoupanca();
            //c1.Deposita(100.0);
            //c1.Saca(50.0);
            //totalizadorDeContas.Soma(c1);
            //MessageBox.Show("conta poupança = " + c1.Saldo);
            //Conta c2 = new ContaCorrente();
            //c2.Deposita(100.0);
            //c2.Saca(50.0);
            //totalizadorDeContas.Soma(c2);
            //MessageBox.Show("conta = " + c2.Saldo);
            //MessageBox.Show("Saldo total das contas c1 e c2 = " + totalizadorDeContas.ValorTotal);
        }

        private void botaoDeposita_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Deposita(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Saca(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }
        private void ComboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);
        }

        private void BotaoTransfere_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            int indiceTransferencia = comboContaRecebeTransferencia.SelectedIndex;
            Conta recebeTransferencia = this.contas[indiceTransferencia];

            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Transfere(valor, recebeTransferencia);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoSaldoTransferencia.Text = Convert.ToString(recebeTransferencia.Saldo);
        }

        private void ComboContaRecebeTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContaRecebeTransferencia.SelectedIndex;
            Conta selecionada = contas[indice];
            textoTitularTransferencia.Text = selecionada.Titular.Nome;
            textoSaldoTransferencia.Text = Convert.ToString(selecionada.Saldo);
            textoNumeroTransferencia.Text = Convert.ToString(selecionada.Numero);
        }
    }
}
