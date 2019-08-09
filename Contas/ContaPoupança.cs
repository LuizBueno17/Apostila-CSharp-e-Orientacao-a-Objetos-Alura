using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaPoupanca : Conta
    {
        internal override void Deposita(double valor)
        {
            this.setSaldo(this.Saldo + (valor));
        }
        internal override void Saca(double valor)
        {
            this.setSaldo(this.Saldo - (valor + 0.10));
        }
    }
}
