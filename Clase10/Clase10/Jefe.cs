using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
  public class Jefe:Empleado
  {
    int bono;
    public Jefe(string nombre, double cuil, float sueldo, int bono)
      :base(nombre, cuil, sueldo)
    {
      this.bono = bono;
    }

    public override string Mostrar()
    {
      StringBuilder str = new StringBuilder();
      str.AppendFormat(", Bono: {0} ", this.bono.ToString());
      return base.Mostrar() + str.ToString();
    }

    public override void Aumentar(int porcentaje)
    {
      base.Aumentar(porcentaje);
      float porcentajeActual = (float)porcentaje / 100;
      this.bono = (int)(this.bono + this.bono * porcentajeActual);
    }
  }
}
