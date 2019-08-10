using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    class ContaInvestimento : Conta, ITributavel
    {
        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }
        internal override void Deposita(double valor)
        {
            if (valor < 0.0)
            {
                throw new Exception("Não é possível depositar um valor negativo!");
            }
            this.setSaldo(this.Saldo + (valor));
        }
        internal override void Saca(double valor)
        {
            if (valor < 0.0)
            {
                throw new Exception("Não é possível sacar um valor negativo!");
            }
            else if (valor > this.Saldo)
            {
                throw new Exception("Valor do saque maior que o saldo");
            }
            else
            {
                this.setSaldo(this.Saldo - (valor));
            }
        }
    }
}
