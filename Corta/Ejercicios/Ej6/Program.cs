using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    class Program
    {
        static void Main(string[] args)
        {
            int from;
            int to;

            Console.WriteLine("Ingresar anio de inicio");
            if(int.TryParse(Console.ReadLine(), out from))
            {
                Console.WriteLine("Ingresar anio de fin");
                if (int.TryParse(Console.ReadLine(), out to))
                {
                    for(int i = from; i < to; i++)
                    {
                        if((i % 400 == 0) || (i%4==0 && i % 100 != 0)){
                            Console.WriteLine("El anio : {0} es bisisesto ", i);
                        }
                    }
                }

                Console.ReadKey();
            }


        }
    }
}
