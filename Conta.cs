using System;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        internal Cliente Titular { get; set; }

        internal void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }
    }
}