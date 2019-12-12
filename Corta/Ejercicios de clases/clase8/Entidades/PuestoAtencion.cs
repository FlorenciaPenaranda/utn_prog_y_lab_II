using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Entidades
{
  public enum Puesto
  {
    caja1,
    caja2
  }

  public class PuestoAtencion
  {
    private static int numeroActual;
    private Puesto puesto;

    public int NumeroActual { get {
        numeroActual++;
        return numeroActual;
      } }


    public bool Atender(Cliente cli)
    {
      Thread.Sleep(1000);
      return true;
    }

    static PuestoAtencion()
    {
      numeroActual = 0;
    }

    public PuestoAtencion(Puesto puestos)
    {
      this.puesto = puestos;
    }
  }
}
