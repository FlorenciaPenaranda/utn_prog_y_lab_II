using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej27
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();
            List<int> num = new List<int>();
            Queue<int> numeross = new Queue<int>();
           
            Random rnd = new Random();

            for(int i = 0; i < 20; i++)
            {
                numeros.Push(rnd.Next(-20, 20));
            }

            Console.WriteLine("Sin ordenar \n\n");
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }

            num = numeros.ToList();
            num.Sort();

            Console.WriteLine("ordenados \n\n");
            foreach (int item in num)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("negativos \n\n");
            foreach (int item in num)
            {
                if(item < 0)
                {
                    Console.WriteLine(item);
                }
               
            }

            Console.WriteLine("positivos \n\n");
            foreach (int item in num)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }

            }


            Console.WriteLine("Queueeee \n\n");
            for (int i = 0; i < 20; i++)
            {
                numeross.Enqueue(rnd.Next(-20, 20));
            }


            Console.WriteLine("Queueeee como esta \n\n");
            foreach (int item in numeross)
            {
                Console.WriteLine(item);
            }

            num = numeross.ToList();
            num.Sort();

            Console.WriteLine("Ordenadoooa \n\n");
            foreach (int item in num)
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();


        }
    }
}
