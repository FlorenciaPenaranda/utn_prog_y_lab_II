using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase5Integrador
{
  class Estante
  {
    private Producto[] productos;
    private int ubicacion;

    private Estante(int capacidad)
    {
      this.productos = new Producto[capacidad];
    }

    public Estante(int capacidad, int ubicacion) : this(capacidad)
    {
      this.ubicacion = ubicacion;
    }

    public Producto[] GetProductos()
    {
      return this.productos;
    }

    public static string MostrarEstantes(Estante e)
    {
      string cadena = "";
      foreach (var item in e.productos)
      {
        cadena +=Producto.MostrarProducto(item);
      }
      return cadena;
    }

    public static bool operator !=(Estante e, Producto p)
    {
      for (int i = 0; i < e.productos.Length; i++)
      {
        if (e.productos[i] == p)
          return false;
      }
      return true;
    }

    public static bool operator ==(Estante e, Producto p)
    {
      for(int i = 0; i < e.productos.Length; i++)
      {
        if (e.productos[i] == p)
          return true;
      }
      return false;
    }

    public static Estante operator -(Estante e, Producto p)
    {

      if(e == p)
      {
        for(int i = 0; i < e.productos.Length; i++)
        {
          if (e.productos[i] == p)
          {
            e.productos[i] = null;
            return e;
          }
        }
      }

      return e;
    }

    public static bool operator +(Estante e, Producto p)
    {
      int i = 0;
      if(e != p ) {
        for(i = 0; i < e.productos.Length; i++)
        {
          if (e.productos[i] is null)
          {
            e.productos[i] = p;
            return true;
          }
        }
      }
    
      return false;
    }
  }
}
