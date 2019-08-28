
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0, acumulador = 0;
            int numero, min=0, max=0;
            

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                if(!Validacion.Validar(numero,-100,100))
                {
                    Console.WriteLine("ERROR. Ingrese un número entre -100 y 100");
                }
                else
                {
                    acumulador += numero;

                    if(contador == 0)
                    {
                        min = numero;
                        max = numero;
                    }

                    if (numero < min)
                    {
                        min = numero;
                    }
                    else if(numero > max)
                    {
                        max = numero;
                    }

                    contador++;
                }
            } while (contador < 10);

            Console.WriteLine("minimo: {0}", min);
            Console.WriteLine("maximo: {0}", max);
            Console.WriteLine("promedio: {0}", (double)acumulador/(double)contador);

            Console.ReadKey();
        }
    }
}
