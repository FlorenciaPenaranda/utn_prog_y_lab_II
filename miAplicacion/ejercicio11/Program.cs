using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0, numero;
            char resp;

            do
            {
                Console.WriteLine("Ingrese un numero:");
                numero = int.Parse(Console.ReadLine());

                acumulador += numero;
                Console.WriteLine("Desea continuar ingresando numeros? S/N");
                resp = char.Parse(Console.ReadLine());

            } while (ValidarRespuesta.ValidaS_N(resp));

            Console.WriteLine("\nLos numeros ingresados suman un total de {0}", acumulador);
            
            Console.ReadKey();
        }
    }
}
