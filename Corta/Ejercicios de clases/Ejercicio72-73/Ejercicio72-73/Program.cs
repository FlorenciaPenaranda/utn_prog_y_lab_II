using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio72;
namespace Ejercicio72_73
{
    class Program
    {
        static void Main(string[] args)
        {

            string aux = "si";
            long num;
            string aux2 = "si";
            string auxprueba;
            while(aux == "si")
            {
                Console.Write("Ingresar un numero : ");
                long.TryParse(Console.ReadLine(), out num);
                Console.WriteLine("Cantidad de digitos : " + num.cantidadDeDigitos());
                Console.Write("Desea ingresar otro numero ? si / no");
                aux = Console.ReadLine();
            }

            while (aux2 == "si")
            {
                Console.Write("Ingresar un string con puntos o comas y lo cuento : ");
                auxprueba = Console.ReadLine();
                Console.WriteLine("Cantidad de puntos o comas : " + auxprueba.cantidadDeComasPuntos());
                Console.Write("Desea ingresar otro string ? si / no");
                aux = Console.ReadLine();
            }

            Console.ReadKey();



        }
    }
}
