using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej17
{
    class Program
    {
        static void Main(string[] args)
        {

            Boligrafo azul = new Boligrafo((short)100, ConsoleColor.Blue);
            Boligrafo rojo = new Boligrafo((short)50, ConsoleColor.Red);
            string blue;
            string red;

            rojo.Pintar((short)49, out red);

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("primera ves");
            Console.WriteLine(red);

            if(rojo.Pintar((short)50, out red))
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("segunda");
                Console.WriteLine(red);

            }
            else
            {
                rojo.Recargar();
                Console.WriteLine("Tinta recargada");
                rojo.Pintar((short)99, out red);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(red);

            }

            azul.Pintar((short)99, out blue);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("primera ves");
            Console.WriteLine(blue);

            if (azul.Pintar((short)50, out blue))
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("segunda");
                Console.WriteLine(blue);

            }
            else
            {
                azul.Recargar();
                Console.WriteLine("Tinta recargada");
                azul.Pintar((short)99, out blue);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine(blue);

            }





            Console.ReadKey();



        }
    }
}
