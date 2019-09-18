using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    class Program
    {
        static void Main(string[] args)
        {

            PuestoDeAtencion puestoDeAtencion = new PuestoDeAtencion(0);

            Console.WriteLine("Hola");

            bool JuanCarlos= puestoDeAtencion.Atender(new Cliente(45));

            Console.WriteLine(JuanCarlos);
            Console.ReadKey();




        }
    }
}
