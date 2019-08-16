using Banco.Contas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private List<Conta> contas;
        private Dictionary<string, Conta> dicionario;
        public Form1()
        {
            InitializeComponent();
        }
        public void AdicionaConta(Conta conta)
        {
            contas.Add(conta);
            comboContas.Items.Add(conta);
            comboContaRecebeTransferencia.Items.Add(conta);
            this.dicionario.Add(conta.Titular.Nome, conta);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.dicionario = new Dictionary<string, Conta>();
            contas = new List<Conta>();

            Conta c1 = new ContaPoupanca();
            c1.Titular = new Cliente("victor");
            c1.Deposita(2000);
            this.AdicionaConta(c1);
            Conta c2 = new ContaPoupanca();
            c2.Titular = new Cliente("mauricio");
            c2.Deposita(2000);
            this.AdicionaConta(c2);
            Conta c3 = new ContaCorrente();
            c3.Titular = new Cliente("osni");
            c3.Deposita(2000);
            this.AdicionaConta(c3);
        }

        private void botaoDeposita_Click(object sender, EventArgs e)
        {
            try
            {
                Conta selecionada = (Conta) comboContas.SelectedItem;
                double valor = Convert.ToDouble(textoValor.Text);
                selecionada.Deposita(valor);
                textoSaldo.Text = selecionada.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            try
            {
                Conta selecionada = (Conta)comboContas.SelectedItem;
                double valor = Convert.ToDouble(textoValor.Text);
                selecionada.Saca(valor);
                textoSaldo.Text = selecionada.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ComboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = selecionada.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
            textoNumero.Text = Convert.ToString(selecionada.Numero.ToString("X5"));
        }

        private void BotaoTransfere_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            int indiceTransferencia = comboContaRecebeTransferencia.SelectedIndex;
            Conta recebeTransferencia = this.contas[indiceTransferencia];

            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Transfere(valor, recebeTransferencia);
            textoSaldo.Text = selecionada.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
            textoSaldoTransferencia.Text = recebeTransferencia.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
        }

        private void ComboContaRecebeTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContaRecebeTransferencia.SelectedIndex;
            Conta selecionada = contas[indice];
            textoTitularTransferencia.Text = selecionada.Titular.Nome;
            textoSaldoTransferencia.Text = selecionada.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
            textoNumeroTransferencia.Text = Convert.ToString(selecionada.Numero.ToString("X5"));
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

        private void BotaoBusca_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeTitular = textoBuscaTitular.Text;
                Conta conta = dicionario[nomeTitular];
                textoTitular.Text = conta.Titular.Nome;
                textoNumero.Text = Convert.ToString(conta.Numero.ToString("X5"));
                textoSaldo.Text = conta.Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
                comboContas.SelectedItem = conta;
            }
            catch (Exception)
            {
                MessageBox.Show("Conta não encontrada");
            }
        }

        private void BotaoRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorios form = new FormRelatorios(this.contas);
            form.ShowDialog();
        }
    }
}
