using Banco.Contas;
using System;
using System.Collections;
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
        private List<Conta> contas;
        private int numeroDeContas = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void AdicionaConta(Conta conta)
        {
            contas.Add(conta);
            this.numeroDeContas++;
            comboContas.Items.Add(conta.Titular.Nome);
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

            contas = new List<Conta>();

            Conta c1 = new ContaPoupanca();
            c1.Titular = new Cliente("victor");
            c1.Numero = 1;
            this.AdicionaConta(c1);
            Conta c2 = new ContaPoupanca();
            c2.Titular = new Cliente("mauricio");
            c2.Numero = 2;
            this.AdicionaConta(c2);
            Conta c3 = new ContaCorrente();
            c3.Titular = new Cliente("osni");
            c3.Numero = 3;
            this.AdicionaConta(c3);
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

        private void BotaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }

        private void BotaoImpostos_Click(object sender, EventArgs e)
        {
            TotalizadorDeTributos totalizador = new TotalizadorDeTributos();

            foreach (var conta in contas)
            {
                if (conta is ITributavel)
                {
                    totalizador.Adiciona(conta as ITributavel);
                }
            }

            MessageBox.Show("Total: " + totalizador.Total);
        }
    }
}
