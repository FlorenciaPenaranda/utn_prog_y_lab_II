using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = Calculadora.Calcular(5, 5, '*');

            Console.WriteLine("calculo {0}", aux);

            Console.ReadKey();

        }
    }
}
