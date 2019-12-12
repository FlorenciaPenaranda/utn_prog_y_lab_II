using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Empleado : Persona
  {
    private float sueldo;

    public Empleado(string nombre, int cuil, float sueldo) : base(nombre , cuil)
    {
      this.sueldo = sueldo;
    }

    public override string Mostrar()
    {
      return String.Format("Nombre :" + base.nombre + "\n" + "Cuil : " + base.Cuil + "\n" + "Sueldo : " + this.sueldo + "\n");
    }

    public override string ToString()
    {
      return Mostrar();
    }

    public virtual void Aumentar(int porcentaje)
    {
      float aux = this.sueldo;
      aux = aux * porcentaje / 100;
      this.sueldo += aux;
    }
  }
}
