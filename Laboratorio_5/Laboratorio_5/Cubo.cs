﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    class Cubo: ICalcular
    {
        public int Calcular(int x)
        {
            return x*x*x;
        }
    }
}
