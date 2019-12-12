using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ElPuestoJerarquico
    {
        Administracion,
        Gerencia,
        Sistemas,
        Accionista
    }
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private string legajo;
        private ElPuestoJerarquico puesto;
        private int salario;


        public Empleado(string name, string lastname, string legajo, ElPuestoJerarquico puestito,int salario)
        {
            this.nombre = name;
            this.apellido = lastname;
            this.legajo = legajo;
            this.puesto = puestito;
            this.salario = salario;

        }

        public static bool operator ==(Empleado ep1, Empleado ep2)
        {
            bool aux = false;
            if(ep1.legajo == ep2.legajo)
            {
                aux = true;
            }
            return aux;
        }

        public static bool operator !=(Empleado ep1, Empleado ep2)
        {
            return !(ep1 == ep2);
        }

        public string Mostrar()
        {
            return String.Format("Nombre: " + this.nombre + "\n" + "Apellido : " + this.apellido + "\n" + "Legajo : " + this.legajo + "\n" + "Puesto :" + this.puesto + "\n" + "Salario : " + this.salario + "\n");
        }

    }
}
