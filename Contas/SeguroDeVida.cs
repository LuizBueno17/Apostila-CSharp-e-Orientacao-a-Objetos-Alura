﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    public class SeguroDeVida : ITributavel
    {
        public double CalculaTributo()
        {
            return 42.0;
        }
    }
}
