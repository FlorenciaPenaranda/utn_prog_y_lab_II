using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClase8
{
  public class Empresa
  {
    private List<Empleado> nominaEmpleados;
    private string razonSocial;
    private string direccion;
    private string ganancias;

    private Empresa()
    {
      this.nominaEmpleados = new List<Empleado>();
    }

    public Empresa(string razonSocial, string direccion, string ganancias)
      : this()
    {
      this.razonSocial = razonSocial;
      this.direccion = direccion;
      this.ganancias = ganancias;
    }

    public static Empresa operator +(Empresa empresaActual, Empleado empleadoActual)
    {
      foreach (Empleado item in empresaActual.nominaEmpleados)
      {
        if(item == empleadoActual)
        {
          return empresaActual;
        }
      }
      empresaActual.nominaEmpleados.Add(empleadoActual);
      return empresaActual;
    }

    public string MostrarEmpresa()
    {
      StringBuilder str = new StringBuilder();
      str.AppendFormat("La empresa {0} sita en la calle {1}, cuenta con ganancias {2} y con {3} empleados:\n", this.razonSocial, this.direccion, this.ganancias, this.nominaEmpleados.Count);
      foreach(Empleado empleadoActual in this.nominaEmpleados)
      {
        str.AppendFormat("{0}\n", empleadoActual.Mostrar());
      }
      return str.ToString();
    }
  }
}
