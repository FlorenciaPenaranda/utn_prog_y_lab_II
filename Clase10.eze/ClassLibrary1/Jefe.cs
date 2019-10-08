using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Jefe : Empleado
    {
        public int Bono { get; set; }
        public Jefe(string nombre, double cuil, float sueldo, int bono) : base(nombre, cuil, sueldo)
        {
            this.Bono = bono;
        }

        public override string Mostrar()
        {
            return base.Mostrar() + " Bon:"+ this.Bono;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
