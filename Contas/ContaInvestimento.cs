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
            this.setSaldo(this.Saldo + (valor));
        }

        internal override void Saca(double valor)
        {
            this.setSaldo(this.Saldo - (valor));
        }
    }
}
