using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            int numero;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            float acumulador = 0;
            int i = 0;

            do
            {
             Console.Write("Ingresar numeros");
             aux = Console.ReadLine();

             if (int.TryParse(aux, out numero)){
                    if (numero > maximo)
                    {
                        maximo = numero;
                        Console.Write(" Valor max actual : {0}\n", maximo);
                    }
                    else
                    {
                        if(numero < minimo)
                        {
                            minimo = numero;
                            Console.Write(" Valor min actual : {0}\n", minimo);
                        }
                    }
                    acumulador += numero;
             }
    
             i++;
            } while (i < 5);

            Console.Write("Num max : {0} \n Num Min : {1} \n cant numero total : {2} \n Promedio : {3}", maximo, minimo, acumulador,acumulador/5);
            Console.ReadKey();
        }
    }
}
