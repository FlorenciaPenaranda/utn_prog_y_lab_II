using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Vendedor : Empleado
    {
        public int Objetivo;

        public Vendedor(string nombre, int cuil, float sueldo, int objetivo)
            : base(nombre, cuil, sueldo)
        {
            this.Objetivo = objetivo;
        }

        public override string Mostrar()
        {
            return base.Mostrar() + " " + this.Objetivo.ToString();  
        }

        

    }
}
