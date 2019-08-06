using System;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        internal Cliente Titular { get; set; }

        internal virtual void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        internal virtual void Saca(double valor)
        {
            this.Saldo -= valor;
        }
        internal virtual void Transfere(double valor, Conta conta)
        {
            this.Saldo -= valor;
            conta.Saldo += valor;
        }
    }
}