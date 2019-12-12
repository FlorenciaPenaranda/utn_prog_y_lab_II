using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Jefe : Empleado
  {
    private int bono;

    public Jefe(string nombre, int cuil, float sueldo, int bono) : base(nombre, cuil, sueldo)
    {
      this.bono = bono;
    }

    public override string Mostrar()
    {
      return base.Mostrar() + String.Format("Bono : " + this.bono + "\n");
    }

    public override string ToString()
    {
      return Mostrar();
    }

    public override void Aumentar(int porcentaje)
    {
      base.Aumentar(porcentaje);
      this.bono += 1000;

    }
  }
}
