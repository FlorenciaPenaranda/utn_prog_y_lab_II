using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**  3. Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
     por consola.
     Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%)
**/

namespace ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, res;
            int contador;
            string num;
            do
            {

                Console.Write("Ingrese un numero: ");
                num = Console.ReadLine();

                if (int.TryParse(num, out res) && res < 0)
                {
                    Console.WriteLine("ERROR. el numero debe ser mayor a 0");
                }
                else
                {
                    for (i = 2; i < res; i++)
                    {
                        contador = 0;

                        for (int j = 1; j < i; j++)
                        {
                            if( i% j == 0)
                            {
                                contador++;
                            }
                        }

                        if (contador == 1)
                        {
                            Console.WriteLine("Numero primo: {0}", i);
                        }
                    }

                }

            } while (res < 0);




            Console.ReadKey();
        }
    }
}
