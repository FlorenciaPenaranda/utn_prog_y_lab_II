using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double numero1, numero2;

            Console.WriteLine("Calcular Area. \n" +
                "1- Calcular el area de un cuadrado.\n" +
                "2- Calcular el area de un trinagulo.\n" +
                "3- Calcular el area de un circulo.\n\n" +
                "Ingrese la opcion deseada: ");
            opcion = int.Parse(Console.ReadLine());

            switch(opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el area del cuadrado: ");
                    numero1 = int.Parse(Console.ReadLine());
                    CalculoDeArea.CalcularCuadrado(numero1);
                    break;
                case 2:
                    break;
                case 3:
                    break;

            }

            Console.ReadKey();
        }
    }
}
