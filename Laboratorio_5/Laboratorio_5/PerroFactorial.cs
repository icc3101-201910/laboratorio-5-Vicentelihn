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

            int resultado = 1;

            for (int i = 1; i <= x; i++)
            {
                resultado = resultado * i;
            }

            if (resultado==0)
            {
                return 1;
            }
            else
            {
                return resultado;
            }
        }
    }
}
