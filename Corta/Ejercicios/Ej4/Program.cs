using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            int numeroIngresado;
            int i;
            int j;
            int acumulador = 0;

            Console.WriteLine("ing numero !!!");
            aux = Console.ReadLine();

            if (int.TryParse(aux, out numeroIngresado))
            {
#pragma warning disable CS0162 // Se detectó código inaccesible
                for (i = numeroIngresado - 1; i > 1; i--)
#pragma warning restore CS0162 // Se detectó código inaccesible
                {
                    for (j = i - 1; j > 1; j--)
                    {

                        if (numeroIngresado % j == 0)
                        {
                            acumulador += j;
                            
                        }

                    }

                    if (acumulador == numeroIngresado-1)
                    {
                        Console.WriteLine("{0} Es perfecto.", numeroIngresado);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("{0} NO es perfecto.", numeroIngresado);
                        break;
                    }
                   


                }

                

                Console.ReadKey();
            }
        }
    }
}
