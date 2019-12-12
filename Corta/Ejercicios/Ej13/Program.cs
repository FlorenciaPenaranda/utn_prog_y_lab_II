using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13
{
    class Program
    {
        static void Main(string[] args)
        {

            double m;
            string x;

            Console.WriteLine("Ing double");
            if(double.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Num convertido {0}", Conversor.DecimalBinario(m));
            }

            Console.WriteLine("Ing binario");
            x = Console.ReadLine();
            
             Console.WriteLine("Num convertido {0}", Conversor.BinarioDecimal(x));

            Console.ReadKey();


        }
    }
}
