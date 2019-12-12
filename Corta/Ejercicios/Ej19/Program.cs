using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej19
{
    class Program
    {
        static void Main(string[] args)
        {

            Sumador p = new Sumador();
            Sumador q = new Sumador();



            Console.WriteLine("{0} {1}", q.Sumar(20, 20), q.Sumar("weon", "qliao"));
            Console.WriteLine("{0} {1}", p.Sumar(20, 20), p.Sumar("weon", "qliao"));
            if (p | q)
            {
                Console.WriteLine("funciona");
            }
            else
            {
                Console.WriteLine("nofunciona");
            }
            Console.WriteLine("{0}", p + q);
            
            Console.ReadKey();
        }
    }
}
