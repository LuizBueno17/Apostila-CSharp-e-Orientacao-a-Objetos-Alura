using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    class ContaCorrente : Conta, ITributavel
    {
        internal override void Saca(double valor)
        {
            this.setSaldo(this.Saldo - (valor + 0.05));
        }
        internal override void Deposita(double valor)
        {
            this.setSaldo(this.Saldo + (valor - 0.10));
        }
        public double CalculaTributo()
        {
            return this.Saldo * 0.05;
        }
    }
}
