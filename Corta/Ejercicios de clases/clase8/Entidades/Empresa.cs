using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresa
    {

        private List<Empleado> nominaEmpleado;
        private string razonSocial;
        private string direccion;
        private float ganancia;

        private Empresa()
        {
            nominaEmpleado = new List<Empleado>();

        }


        public Empresa(string razon, string direccion, float ganancia) : this()
        {
            this.razonSocial = razon;
            this.direccion = direccion;
            this.ganancia = ganancia;

        }

        

        public static bool operator +(Empresa empresa, Empleado ep)
        {
            bool aux = false;
            if (empresa.nominaEmpleado.IndexOf(ep)!=-1) {
                aux = false;
            }
            else
            {
                empresa.nominaEmpleado.Add(ep);
                aux = true;
            }
            return aux;
        }

        public string MostrarEmpresa()
        {
           string aux = String.Format("La empresa : " + this.razonSocial + " sita en la calle : " + this.direccion + " Cuenta con ganancias por : " + this.ganancia + " y con cantidad de empleados : " + this.nominaEmpleado.Count + "Empleados : " + "\n" );

            foreach (Empleado item in this.nominaEmpleado)
            {
                aux += item.Mostrar();
            }
            return aux;
        }

    }
}
