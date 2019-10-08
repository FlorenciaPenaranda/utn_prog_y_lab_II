using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClase8
{
  public enum EPuestoJerarquico
  {
    Administración,
    Gerencia,
    Sistemas,
    Accionsita,
  }

  public class Empleado
  { 
    private string nombre;
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

    public static bool operator ==(Empleado emp1, Empleado emp2)
    {
      if(emp1.legajo == emp2.legajo)
      {
        return true;
      }
      else
      {
        return false;
      }
        
    }

    public static bool operator !=(Empleado emp1, Empleado emp2)
    {
      if (emp1.legajo == emp2.legajo)
      {
        return false;
      }
      else
      {
        return false;
      }
    }

    public string Mostrar()
    {
      StringBuilder str = new StringBuilder();
      str.AppendFormat("Nombre: {0}\nApellido: {1}\nLegajo: {2}\nPuesto: {3}\nSalario: {4}", this.nombre, this.apellido, this.legajo, this.puesto, this.salario);
      return str.ToString();
    }
  }
}
