using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej11
{
    class Program
    {
        static void Main(string[] args)
        {

            int min = int.MaxValue;
            int max = int.MinValue;
            int acumulador = 0;
            int aux;

            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("ing 10 numeros");
                if(int.TryParse(Console.ReadLine(), out aux))
                {
                    if (Validar.validate(aux, -100, 100))
                    {
                        if (aux > max)
                        {
                            max = aux;
                            Console.Write(" Valor max actual : {0}\n", max);
                        }
                        else
                        {
                            if (aux < min)
                            {
                                min = aux;
                                Console.Write(" Valor min actual : {0}\n", min);
                            }
                        }
                        acumulador += aux;

                    }
                   
                }

            }
            Console.Write("Num max : {0} \n Num Min : {1} \n cant numero total : {2} \n Promedio : {3}", max, min, acumulador, acumulador / 10);
            Console.ReadKey();


        }
            
        }
    }

