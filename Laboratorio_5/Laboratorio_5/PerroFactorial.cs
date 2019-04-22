using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    class PerroFactorial:ICalcular
    {
        public int Calcular(int x)
        {
            //int x = Calcular();
            int resultado = 1;

            for (int i = 1; i <= x; i++)
            {
                return resultado = resultado * i;
            }

            return resultado;
        }

    }
}
