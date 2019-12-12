using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej12
{
    class Program
    {
        static void Main(string[] args)
        {
            char c ;
            int aux;
            int acumulador = 0;

            do
            {
                Console.WriteLine("Ingresar numero ");
                if(int.TryParse(Console.ReadLine(), out aux))
                {
                    acumulador += aux;
                }

                Console.WriteLine("Continuar S/N");
                if(char.TryParse(Console.ReadLine(), out c))
                {
                    while (c != 's' && c != 'n')
                    {
                        Console.WriteLine("Error ing S/N");
                        char.TryParse(Console.ReadLine(), out c);
                    }
                }

                
            } while (ValidarRespuesta.ValidateChar(c));

            Console.WriteLine("La suma de todos los numeros ing es : {0}", acumulador);
            Console.ReadKey();
        }
    }
}
