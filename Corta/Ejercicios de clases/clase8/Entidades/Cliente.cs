using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Cliente
  {
    private string nombre;
    private int numero;

    public int Numero { get {
        return this.numero;
      } }
    public string Nombre {
      get {
        return this.nombre;
      }
      set {
        this.nombre = value;
      } }

    public Cliente(int numero)
    {
      this.numero = numero;
    }

    public Cliente(int numero, string nombre) : this(numero)
    {
      this.nombre = nombre;
    }

    public static bool operator!=(Cliente c1, Cliente c2)
    {
      bool aux = false;
      if (c1.numero != c2.numero)
        aux = true;
      return aux;
    }

    public static bool operator ==(Cliente c1, Cliente c2)
    {
      return !(c1 != c2);
    }


  }
}
