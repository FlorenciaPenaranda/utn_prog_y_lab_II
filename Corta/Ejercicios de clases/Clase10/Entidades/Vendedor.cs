using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Vendedor : Empleado
  {
    private int objetivo;

    public Vendedor(string nombre, int cuil, float sueldo, int objetivo) : base(nombre, cuil, sueldo)
    {
      this.objetivo = objetivo;
    }

    public override string Mostrar()
    {
      return base.Mostrar() + String.Format("Objetivo : " + this.objetivo);
    }

    public override string ToString()
    {
      return Mostrar();
    }

    public override void Aumentar(int porcentaje)
    {
      base.Aumentar(porcentaje);
      this.objetivo += 20;
    }
  }
}
