using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            int numeroIngresado;
            int j;
            int i;

            Console.WriteLine("Ing numero");
            aux = Console.ReadLine();
            if (int.TryParse(aux, out numeroIngresado))
            {

                /* for (i=num-1; i>1; i--)
                 {
                     Console.Write("{0}\n", i);

                     if (num % i == 0)
                     {
                         Console.Write("El numero {0} NO es primo", num);
                         break;
                     }


                 }

                 if ( i == 1)
                 {
                     Console.Write("El numero {0} Es primo", num);
                 }*/

                /* for( i = num - 1; i > 1; i--)
                 {
                     for( j = i - 1; j > 1; i--)
                     {
                         if (i % j == 0)
                         {
                             break;
                         }
                     }

                     if (j == 1)
                     {
                         Console.Write("El numero {0} Es primo", i);
                     }
                 }*/

                for (i = numeroIngresado - 1; i > 1; i--)
                {
                    for (j = i - 1; j > 1; j--)
                    {

                        if (i % j == 0)
                        {
                            break;
                        }
                        
                    }

                    if (j == 1)
                    {
                        Console.WriteLine("{0} Es primo.", i);
                    }

                    	
                }

            }

            Console.ReadKey();

        }
    }
}
