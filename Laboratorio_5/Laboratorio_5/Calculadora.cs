using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    class Calculadora
    {
        private int numero;
        public List<ICalcular> calculadoras;

        PersonaQueSuma5 personaQueSuma5 = new PersonaQueSuma5();
        RobotFibonacci robotFibonacci = new RobotFibonacci();
        PerroFactorial perroFactorial = new PerroFactorial();
        Cubo cubo = new Cubo();
        Cuadrado cuadrado = new Cuadrado();


        public Calculadora(int numero)
        {
            this.numero = numero;
            calculadoras = new List<ICalcular>();

            calculadoras.Add(cuadrado);
            calculadoras.Add(cubo);
            calculadoras.Add(perroFactorial);
            calculadoras.Add(robotFibonacci);
            calculadoras.Add(personaQueSuma5);

        }

        public void Calcular(int operacion)
        {
            if (operacion == 5)
            {
              Console.WriteLine(calculadoras[4].Calcular(numero));
              numero = calculadoras[4].Calcular(numero);
            }
            else if (operacion == 4)
            {
                Console.WriteLine(calculadoras[3].Calcular(numero));
                numero = calculadoras[3].Calcular(numero);
            }
            else if (operacion == 3)
            {
                Console.WriteLine(calculadoras[2].Calcular(numero));
                numero = calculadoras[2].Calcular(numero);
            }
            else if (operacion == 2)
            {
                Console.WriteLine(calculadoras[1].Calcular(numero));
                numero = calculadoras[1].Calcular(numero);
            }
            else if (operacion == 1)
            {
                Console.WriteLine(calculadoras[0].Calcular(numero));
                numero = calculadoras[0].Calcular(numero);
            }
        }

        public int GetNumero()
        {
            return numero;
        }


    }
}
