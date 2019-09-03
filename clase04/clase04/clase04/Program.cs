using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado emp1 = new Empleado("Fabian", "Rolon", 200000);
            emp1.CalcularNeto();
            emp1.Mostrar();

        }
    }
}
