using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaPoupanca : Conta
    {
        internal override void Saca(double valor)
        {
            base.Saca(valor + 0.10);
        }
    }
}
