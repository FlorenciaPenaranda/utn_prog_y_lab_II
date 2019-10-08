using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
  public class Empleado:Persona
  {
    float sueldo;
    public Empleado(string nombre, double cuil, float sueldo)
      :base(nombre, cuil)
    {
      this.sueldo = sueldo;
    }

    public override string Mostrar()
    {
      StringBuilder str = new StringBuilder();
      str.AppendFormat("Nombre: {0}, CUIL: {1}, Sueldo: {2}", this.nombre, this.cuil.ToString(), this.sueldo.ToString());
      return str.ToString();
    }

    public virtual void Aumentar(int porcentaje)
    {
      float porcentajeActual = (float)porcentaje / 100;
      this.sueldo = this.sueldo + this.sueldo * porcentajeActual;
    }
  }
}
