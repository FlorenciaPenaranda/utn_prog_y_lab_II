using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nacimiento;
            Console.WriteLine("Ing fecha nacimiento");
            if(DateTime.TryParse(Console.ReadLine(), out nacimiento))
            {
                DateTime Today = DateTime.Now;
                Console.WriteLine("Viviste {0} dias ",(Today-nacimiento).Days);
            }

            Console.ReadKey();
        }
    }
}
