using Banco.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaPoupanca : Conta, ITributavel
    {
        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }
        internal override void Deposita(double valor)
        {
            this.setSaldo(this.Saldo + (valor));
        }
        internal override void Saca(double valor)
        {
            if (valor < 0.0)
            {
                throw new Exception("Não é possível sacar um valor negativo!");
            }
            else if (valor + 0.10 > this.Saldo)
            {
                throw new Exception("Valor do saque maior que o saldo");
            }
            else
            {
                this.setSaldo(this.Saldo - (valor + 0.10));
            }
        }
    }
}
