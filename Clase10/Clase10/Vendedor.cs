using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
  public class Vendedor:Empleado
  {
    int objetivo;
    public Vendedor(string nombre, double cuil, float sueldo, int objetivo)
      :base(nombre, cuil, sueldo)
    {
      this.objetivo = objetivo;
    }

    public override string Mostrar()
    {
      StringBuilder str = new StringBuilder();
      str.AppendFormat(", Objetivo: {0} ", this.objetivo.ToString());
      return base.Mostrar() + str.ToString();
    }

    public override void Aumentar(int porcentaje)
    {
      base.Aumentar(porcentaje);
      float porcentajeActual = (float)porcentaje / 100;
      this.objetivo = (int)(this.objetivo + this.objetivo * porcentajeActual);
    }
  }
}
