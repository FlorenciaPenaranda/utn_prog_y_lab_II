using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej - 5 ";
            int numIng = 0;
            int aux = 1;
           


            Console.WriteLine("Ing numero para calcular centros numericos");
            if(int.TryParse(Console.ReadLine(), out numIng))
            {
                do
                {
                    int suma1 = 0;
                    int suma2 = 0;
                    int j = aux + 1;

                    for (int i = 1; i < aux; i++)
                    {
                        suma1 += i;
                    }
                    Console.WriteLine("suma1 {0} ", suma1);

                    do
                    {
                        suma2 += j;
                        j++;

                    } while (suma1 > suma2);
                    Console.WriteLine("suma2 {0} ", suma2);

                    if (suma1 == suma2)
                    {
                        Console.WriteLine("Centro num {0}, suma {1} ", aux, suma1);
                    }
                    aux++;
                } while (aux < numIng);
            }
            Console.ReadKey();

        }
    }
}
