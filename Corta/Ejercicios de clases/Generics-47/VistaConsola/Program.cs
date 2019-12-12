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
            Torneo<EquipoFutbol> futbol = new Torneo<EquipoFutbol>("CHAMPIONS LEAGUE BRRRRRR");
            Torneo<EquipoBasquet> basquet = new Torneo<EquipoBasquet>("NBA");

            EquipoFutbol e1 = new EquipoFutbol("Barcelona", new DateTime());
            EquipoFutbol e2 = new EquipoFutbol("riber ndea", new DateTime());
            EquipoFutbol e3 = new EquipoFutbol("biber", new DateTime());

            EquipoBasquet b1 = new EquipoBasquet("basquet1", new DateTime());
            EquipoBasquet b2 = new EquipoBasquet("basquet2", new DateTime());
            EquipoBasquet b3 = new EquipoBasquet("basquet3", new DateTime());

            futbol += e1;
            futbol += e2;
            futbol += e3;
            futbol += e1;

            Console.WriteLine(futbol.Mostrar());

            basquet += b1;
            basquet += b2;
            basquet += b3;

            Console.WriteLine(basquet.Mostrar());

            Console.WriteLine("-----------------partidos futbol jugarrrr -----");
            Console.WriteLine(futbol.JugarPartido);
            Console.WriteLine(futbol.JugarPartido);
            Console.WriteLine(futbol.JugarPartido);
            Console.WriteLine("-----------------partidos basket jugarrrr -----");
            Console.WriteLine(basquet.JugarPartido);
            Console.WriteLine(basquet.JugarPartido);
            Console.WriteLine(basquet.JugarPartido);


            Console.ReadKey();


        }

    }

}
