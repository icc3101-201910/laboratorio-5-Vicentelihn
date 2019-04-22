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

            Console.WriteLine("Que operacion desea realizar: ");
            Console.WriteLine("[1] Calculadora - Cuadrado");
            Console.WriteLine("[2] Calculadora - Cubo");
            Console.WriteLine("[3] Calculadora - Perro");
            Console.WriteLine("[4] Calculadora - RobotFibonacci");
            Console.WriteLine("[5] Calculadora - PersonaQueSuma5");
            Console.WriteLine();

            int operacion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese el numero que desea operar: ");
            int numero_1 = Convert.ToInt32(Console.ReadLine());
            Calculadora calculadora = new Calculadora(numero_1);
            Console.WriteLine();

            if (operacion == 5)
            {
                Console.WriteLine("Su numero '" +numero_1+ "' resuelto es: ");
                calculadora.Calcular(operacion);
                Console.WriteLine();
            }
            else if (operacion == 4)
            {
                Console.WriteLine("Su numero '" + numero_1 + "' resuelto es: ");
                calculadora.Calcular(operacion);
                Console.WriteLine();
            }
            else if (operacion == 3)
            {
                Console.WriteLine("Su numero '" + numero_1 + "' resuelto es: ");
                calculadora.Calcular(operacion);
                Console.WriteLine();
            }
            else if (operacion == 2)
            {
                Console.WriteLine("Su numero '" + numero_1 + "' resuelto es: ");
                calculadora.Calcular(operacion);
                Console.WriteLine();
            }
            else if (operacion == 1)
            {
                Console.WriteLine("Su numero '" + numero_1 + "' resuelto es: ");
                calculadora.Calcular(operacion);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Su numero de operacion '" + operacion + "' no pertence a la lista de opciones.");
                Console.WriteLine("Adios");  
            }


            Console.WriteLine("Numero final: " + calculadora.GetNumero());
            Console.WriteLine();
            Console.WriteLine("Fin del Programa");
            Console.ReadLine();






        }
    }
}
