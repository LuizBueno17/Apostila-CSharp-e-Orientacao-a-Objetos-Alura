using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    class ContaCorrente : Conta
    {
        internal override void Saca(double valor)
        {
            base.Saca(valor + 0.05);
        }
        internal override void Deposita(double valor)
        {
            base.Deposita(valor - 0.10);
        }
    }
}
