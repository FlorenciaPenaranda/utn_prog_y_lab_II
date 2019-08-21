using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**  2. Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
    mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
    Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
**/

namespace ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int res;
            string num;
            double cuadrado, cubo;

            do
            {
                Console.Write("Ingrese un numero: ");
                num = Console.ReadLine();

                if (int.TryParse(num, out res) && res <= 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
                else
                {
                    cuadrado = Math.Pow(res, 2);
                    cubo = Math.Pow(res, 3);
                    Console.WriteLine("cuadrado: {0}", cuadrado);
                    Console.WriteLine("cubo: {0}", cubo);
                }

            } while (res <= 0);           


            Console.ReadKey();// para  no cerrar a consola
        }
    }
}
