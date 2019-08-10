using System;

namespace Banco
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        internal Cliente Titular { get; set; }
        private static int numeroDeContas = 0;
        public Conta()
        {
            numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }
        public static int ProximaConta()
        {
            return Conta.numeroDeContas + 1;
        }
        internal abstract void Deposita(double valor);
        internal abstract void Saca(double valor);
        internal virtual void Transfere(double valor, Conta conta)
        {
            this.Saldo -= valor;
            conta.Saldo += valor;
        }
        internal void setSaldo(double saldo)
        {
            this.Saldo = saldo;
        }
    }
}