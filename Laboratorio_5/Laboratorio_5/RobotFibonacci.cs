using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    class RobotFibonacci: ICalcular
    {
        public int Calcular(int x)
        {
            int a, b,auxiliar, i;
            a = 0;
            b = 1;
            for (i = 0; i < x; i++)
            {
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                
            }
            return a;

        }
    }
}
