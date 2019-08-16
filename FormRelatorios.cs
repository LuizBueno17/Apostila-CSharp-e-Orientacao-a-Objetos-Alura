using System;
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
    public partial class FormRelatorios : Form
    {
        private List<Conta> contas;
        public FormRelatorios(List<Conta> contas)
        {
            InitializeComponent();
            this.contas = contas;
        }
        private void BotaoFiltroSaldo_Click(object sender, EventArgs e)
        {
            var resultado = contas.Where(c => c.Saldo > 500);
            ListaContas(resultado);
        }

        private void ListaContas(IEnumerable<Conta> resultado)
        {
            listaResultado.Items.Clear();
            foreach (Conta c in resultado)
            {
                listaResultado.Items.Add(c);
            }
            double saldoTotal = resultado.Sum(conta => conta.Saldo);
            double maiorSaldo = resultado.Max(conta => conta.Saldo);
            labelSaldoTotal.Text = saldoTotal.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
            labelMaiorSaldo.Text = maiorSaldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
        }

        private void BotaoFiltraContasAntigas_Click(object sender, EventArgs e)
        {
            var resultado = contas.Where(c => c.Numero <= 10 && c.Saldo > 1000);
            ListaContas(resultado);
        }

        private void BotaoOrdenaAlfabeticamente_Click(object sender, EventArgs e)
        {
            List<Conta> lista = listaResultado.Items.Cast<Conta>().ToList();
            listaResultado.Items.Clear();
            //var ordenados = from c in lista
            //          orderby c.Titular.Nome, c.Numero
            //          select c;
            var ordenados = lista.OrderBy(c => c.Titular.Nome).ThenBy(c => c.Numero);
            ListaContas(ordenados);
        }
    }
}
