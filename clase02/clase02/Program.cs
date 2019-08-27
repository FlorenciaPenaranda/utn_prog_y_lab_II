using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

// /*para tatuarse*/
//ESTATIC = "DE CLASE"
//NO ESTATIC = "DE INSTANCIA"

namespace clase02
{
    //
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            do {
                Console.Write("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine()); //parse valida que sea entero. COMO USARR?*

                if (num <= 0)
                {
                    Console.WriteLine("ERROR. Ingrese un número mayor a 0");
                }
                else
                {
                    Console.WriteLine("cuadrado: {0}", Cuadrado.PotenciaCuadrado(num));
                    Console.WriteLine("cubo: {0}", Cubo.PotenciaCubo(num));
                }
            } while ();
            Console.ReadKey();
        }
    }    
}
