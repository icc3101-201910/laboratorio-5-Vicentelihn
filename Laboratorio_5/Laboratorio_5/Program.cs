using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 5 - Vicente Lihn");
            Console.WriteLine();

            Console.WriteLine("Numero de calculos a realizar: ");
            int calculos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el numero que desea operar: ");
            int numero_1 = Convert.ToInt32(Console.ReadLine());
            Calculadora calculadora = new Calculadora(numero_1);
            Console.WriteLine();

            if (calculos>0)
            {
                calculadora.Calcular(calculos);
                Console.WriteLine();
            }

            Console.WriteLine("Numero final: " + calculadora.GetNumero());
            Console.WriteLine();
            Console.WriteLine("Fin del Programa");
            Console.ReadLine();

        }
    }
}
