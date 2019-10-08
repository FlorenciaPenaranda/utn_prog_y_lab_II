using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Vendedor : Empleado
    {
        public int Objetivo { get; set; }
        public Vendedor(string nombre, double cuil, float sueldo, int objetivo) : base(nombre, cuil, sueldo)
        {
            this.Objetivo = objetivo;
        }

        public override string Mostrar()
        {
            return base.Mostrar() + " obj:" + this.Objetivo;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override void Aumentar(int porcentaje)
        {
            base.Aumentar(porcentaje);
            this.Objetivo = this.Objetivo + this.Objetivo * porcentaje / 100; 
        }

    }
}
