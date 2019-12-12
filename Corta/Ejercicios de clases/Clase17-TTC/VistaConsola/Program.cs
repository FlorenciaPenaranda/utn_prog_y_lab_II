using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace VistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancio Estanterias.
            Estanteria<Producto> estProductos = new Estanteria<Producto>();
            Estanteria<Alimenticio> estAlimenticio = new Estanteria<Alimenticio>();
            Estanteria<Ferreteria> estFerreteria = new Estanteria<Ferreteria>();

            //Creo Productos.
            Alimenticio arroz = new Alimenticio(1, "Arroz", new DateTime());
            Alimenticio leche = new Alimenticio(2, "leche", new DateTime());
            Alimenticio aceite = new Alimenticio(3, "aceite", new DateTime());

            Ferreteria tornillo = new Ferreteria(10,1,"Tornillo");
            Ferreteria bulon = new Ferreteria(13, 2, "bulon");
            Ferreteria tuerca = new Ferreteria(12, 3, "tuerca");

            // Agrego al estante (Ferreteria)
            Console.WriteLine("**Si esta bien, agrega 3 prod. Ferreteria.");
            Console.WriteLine("");
            if (estFerreteria + tornillo)
            {
                Console.WriteLine("Agrege Tornillo a Estante de Ferreteria");
            }
            if (estFerreteria + bulon)
            {
                Console.WriteLine("Agrege bulon a Estante de Ferreteria");
            }
            if (estFerreteria + tuerca)
            {
                Console.WriteLine("Agrege tuerca a Estante de Ferreteria");
            }

            // Agrego al estante (Alimenticio)
            Console.WriteLine("**Si esta bien, agrega 3 prod. Alimenticio.");
            Console.WriteLine("");
            if (estAlimenticio + arroz)
            {
                Console.WriteLine("Agrege arroz a Estante de Alimenticio");
            }
            if (estAlimenticio + aceite)
            {
                Console.WriteLine("Agrege aceite a Estante de Alimenticio");
            }
            if (estAlimenticio + leche)
            {
                Console.WriteLine("Agrege leche a Estante de Alimenticio");
            }

            // Agrego al estante (General)
            Console.WriteLine("**Si esta bien, agrega 4 prod. Generales.");
            Console.WriteLine("");
            if (estProductos + arroz)
            {
                Console.WriteLine("Agrege arroz a Estante de Productos Generales");
            }
            if (estProductos + bulon)
            {
                Console.WriteLine("Agrege bulon a Estante de Productos Generales");
            }
            if (estProductos + leche)
            {
                Console.WriteLine("Agrege leche a Estante de Productos Generales");
            }
            if (estProductos + tornillo)
            {
                Console.WriteLine("Agrege Tornillo a Estante de Productos Generales");
            }

            //Quito elementos.
            Console.WriteLine("**Si esta bien, QUITO 4 prod. Generales.");
            Console.WriteLine("");
            if (estProductos - arroz)
            {
                Console.WriteLine("Quite arroz a Estante de Productos Generales");
            }
            if (estProductos - bulon)
            {
                Console.WriteLine("Quite bulon a Estante de Productos Generales");
            }
            if (estProductos - leche)
            {
                Console.WriteLine("Quite leche a Estante de Productos Generales");
            }
            if (estProductos - tornillo)
            {
                Console.WriteLine("Quite Tornillo a Estante de Productos Generales");
            }

            Console.ReadKey();
        }
    }
}
