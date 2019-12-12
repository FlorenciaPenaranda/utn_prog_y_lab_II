using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5Integrador
{
  class Producto
  {
    public string codigoDeBarra { get; set; }
    private string marca { get; set; }
    private float precio { get; set; }


    public Producto()
    {

    }

    public Producto(string marca, string codigoDeBarra, float precio)
    {
      this.codigoDeBarra = codigoDeBarra;
      this.marca = marca;
      this.precio = precio;
    }

    public string GetMarca()
    {
      return this.marca;
    }

    public float GetPrecio()
    {
      return this.precio;
    }
    public static string MostrarProducto(Producto p)
    {
      if(!(p is null))
      {
        return String.Format("Marca : {0} \nPrecio : {1}\nCodigo De Barras : {2}\n\n ", p.marca, p.precio, p.codigoDeBarra);
      }
      return string.Format("");
    }

    public static explicit operator string(Producto p)
    {
      return p.codigoDeBarra;
    }

    public static bool operator !=(Producto p1, Producto p2)
    {
      bool aux = false;
      if (p1.codigoDeBarra != p2.codigoDeBarra || p1.marca != p2.marca)
      {
        aux = true;
      }
      return aux;
    }

    public static bool operator ==(Producto p1, Producto p2)
    {
      bool aux = false;
      if(!(p1 is null) && !(p2 is null))
      {
        if (p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca)
        {
          aux = true;
        }
      }
      
      return aux;
    }

    public static bool operator ==(Producto p1, string str)
    {
      bool aux = false;
      if(p1.marca == str)
      {
        aux = true;
      }
      return aux;

    }

    public static bool operator !=(Producto p1, string str)
    {
      bool aux = false;
      if (p1.marca == str)
      {
        aux = true;
      }
      return aux;

    }



  }
}
