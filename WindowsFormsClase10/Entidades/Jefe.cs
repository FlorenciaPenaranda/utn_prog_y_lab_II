using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Jefe : Empleado
    {
        public int Bono;

        public Jefe(string nombre, int cuil, float sueldo, int Bono)
            : base(nombre, cuil, sueldo)
        {
            this.Bono = Bono;
        }

        public override string Mostrar()
        {
            return base.Mostrar() + this.Bono.ToString();
        }
    }
}
