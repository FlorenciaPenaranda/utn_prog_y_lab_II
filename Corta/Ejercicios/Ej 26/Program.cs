using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] asd = new int[20];
            Random rnd = new Random();

            Console.WriteLine("lISTA sin Ordenar");
            for (int i = 0; i < asd.Length; i++)
            {
                asd[i] = rnd.Next(-20,20);
                Console.WriteLine($"Numero generado {asd[i]}");
            }

            Array.Sort(asd);

            Console.WriteLine("lISTA ORDENADA");
            for (int i = 0; i < asd.Length; i++) { 

                Console.WriteLine($"Numero ordenado {asd[i]}");
            }

            Console.WriteLine("Solo negativos");
            for (int i = 0; i< asd.Length; i++)
            {
                if (asd[i]<0)
                {
                    Console.WriteLine($"Numeros negativos : {asd[i]}");
                }
            }

            Console.WriteLine("Solo Positivos");
            for (int i = 0; i < asd.Length; i++)
            {
                if (asd[i] > 0)
                {
                    Console.WriteLine($"Numeros negativos : {asd[i]}");
                }
            }
            Console.ReadKey();

        }
    }
}
