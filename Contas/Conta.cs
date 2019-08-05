using System;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        internal Cliente Titular { get; set; }

        internal virtual void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        public virtual void Saca(double valor)
        {
            this.Saldo -= valor;
        }
    }
}