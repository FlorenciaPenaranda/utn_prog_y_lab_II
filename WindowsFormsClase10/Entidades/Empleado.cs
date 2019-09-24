using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        public float Sueldo { get; set; }

        public enum TipoEmpleado
        {
            Empleado,
            Vendedor,
            Jefe
        }

        public Empleado(string nombre, int cuil, float sueldo) 
            : base(nombre, cuil)
        {
            this.Sueldo = sueldo;
        }

        public override string Mostrar()
        {
            return base.Mostrar2() + this.Sueldo.ToString();
        }

        public void Aumentar(int porcentaje)
        {
            this.Sueldo = this.Sueldo * porcentaje;
        }
    }
}
