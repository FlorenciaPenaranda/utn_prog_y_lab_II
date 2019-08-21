using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**  1. Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el
     valor máximo, el valor mínimo y el promedio.
**/

namespace miAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int res, acum = 0;
            string num;
            int min = 0, max = 0; //int.MinValue o int.MaxValue les asigna numeros menores o mayores posibles. 

            for (i = 0 ; i < 5 ;  i++)
            {
                Console.Write("Ingrese un numero: ");
                num = Console.ReadLine();  // devuelve un string

                //tripase convierte un string a entero
                if (int.TryParse(num, out res) && i == 0)
                {
                    min = res;
                    max = res;
                }
                else if (res > min)
                {
                    max = res;
                }
                else
                {
                    min = res;
                }

                acum += res;                
            }
            Console.WriteLine("Mininmo: {0}", min); // De esta forma se muestra una variable por consola, writeline tiene el salto de linea.
            Console.WriteLine("Maximo: {0}", max);
            Console.WriteLine("promedio: {0}", (float)acum/i);








            Console.ReadKey();// para  no cerrar a consola
        }
    }
}
