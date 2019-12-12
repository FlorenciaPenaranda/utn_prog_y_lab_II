using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            double num;

            do
            {
                Console.WriteLine("Ing numero");
                aux = Console.ReadLine();

                if (double.TryParse(aux, out num))
                {
                    if (num > 0)
                    {
                       
                        Console.Write("Numero al cuadrado : {0} \n Numero al cubo : {1}", Math.Pow(num,2), Math.Pow(num,3));
                    }
                    else
                    {
                        Console.Write("ing numero d nuevo!");
                    }
                }

            } while (num < 0);

            Console.ReadKey();
          
           
            





          
        }
    }
}
