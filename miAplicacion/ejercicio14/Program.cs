using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double primerOperando, segundoOperando;
            char operador;

            Console.WriteLine("CALCULADORA. \n");
            Console.WriteLine("Ingrese Primer numero:");
            primerOperando = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero:");
            segundoOperando = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese operador:");
            operador = char.Parse(Console.ReadLine());

        }
    }
}
