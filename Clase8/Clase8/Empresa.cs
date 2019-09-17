using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8
{
    class Empresa
    {
        private List<Empleado> nominaEmpleados;
        private string razonSocial;
        private string direccion;
        private float ganancias;

        public Empresa()
        {
            this.nominaEmpleados = new List<Empleado>();
        }

        public Empresa(string razonSocial, string direccion, float ganancias) : this()
        {
            this.razonSocial = razonSocial;
            this.direccion = direccion;
            this.ganancias = ganancias;

        }

        public static Empresa operator +(Empleado empleado, Empresa empresa)
        {
            if (empleado != null && empresa != null)
            {
                foreach (Empleado item in empresa.nominaEmpleados)
                {
                    if(item == empleado)
                    {
                       return empresa;
                    }
                }
                empresa.nominaEmpleados.Add(empleado);
                return empresa;

            }//si algun aprametro en null, devolver la empresa.
            
        }

  
    }


}
