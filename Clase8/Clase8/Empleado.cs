using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8
{
    public class Empleado
    {
        private string nombre; //de instancia?
        private string apellido;
        private string legajo;
        private EPuestoJerarquico puesto;
        private int salario;

        public Empleado(string nombre, string apellido, string legajo, EPuestoJerarquico puesto, int salario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.puesto = puesto;
            this.salario = salario;
        }

        public enum EPuestoJerarquico
        {
            Administración = 1,
            Gerencia = 2,
            Sistemas = 3,
            Accionista = 4,
        }

        public static bool operator ==(Empleado primerEmpleado, Empleado segundoEmpleado)
        {
            if (primerEmpleado != null && segundoEmpleado != null)
            {
                if (primerEmpleado.salario == segundoEmpleado.salario)
                    {
                        return true;
                    }
                
            }
            return false;
        }

        public static bool operator !=(Empleado primerEmpleado, Empleado segundoEmpleado)
        {
            return !(primerEmpleado.salario == segundoEmpleado.salario);
        }

        public string Mostrar()
        {

        }
    }
}
