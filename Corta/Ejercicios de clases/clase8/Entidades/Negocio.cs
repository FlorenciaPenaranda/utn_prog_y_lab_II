using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Negocio
  {
    private Puesto caja;
    private Queue<Cliente> clientes;
    private string nombre;

    public Cliente Cliente { get {
        return clientes.Dequeue();
      } set {
        if (!clientes.Contains(value))
        {
          clientes.Enqueue(value);
        }
      }
    }

    private Negocio()
    {
      this.clientes = new Queue<Cliente>();
      this.caja = Puesto.caja1;
    }

    public Negocio(string nombre)
    {
      this.nombre = nombre;
    }

    public static bool operator !=(Negocio n, Cliente c)
    {
      bool aux = true;
      if (!n.clientes.Contains(c))
      {
        aux = false;
      }
      return aux;
    }

    public static bool operator ==(Negocio n, Cliente c)
    {
      return !(n != c);
    }

    public static bool operator +(Negocio n, Cliente c)
    {
      bool aux = false;
      if (n != c)
      {
        n.clientes.Enqueue(c);
        aux = true;
      }
      return aux;
    }

    public static bool operator ~(Negocio n)
    {
      bool aux = false;
      if(n.clientes.Count != 0)
      {
        PuestoAtencion puesto = new PuestoAtencion(n.caja);
        puesto.Atender(n.clientes.Dequeue());
        aux = true;
      }

      return aux;
    }



  }
}
