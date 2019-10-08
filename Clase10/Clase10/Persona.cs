using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
  public abstract class Persona
  {
    public string nombre { get; set; }
    private double Cuil;
    public double cuil
    {
      get
      {
        return Cuil;
      }
      set
      {
        if (validarCuil(this.Cuil) == true)
        {
          this.Cuil = value;
        }
        else
        {
          throw new Exception("El Cuil no es valido.");
        }
      }
    }

    public Persona(string nombre, double cuil)
    {
      this.nombre = nombre;
      this.cuil = cuil;
    }

    public abstract string Mostrar();
    public bool validarCuil(double cuil)
    {
      char[] ponderador = { '5', '4', '3', '2', '7', '6', '5', '4', '3', '2' };
      int i;
      double suma = 0;
      char[] numero = cuil.ToString("00000000000").ToCharArray();
      for (i = 0; i < 10; i++)
      {
        suma += (int.Parse(ponderador[i].ToString()) * int.Parse(numero[i].ToString()));
      }

      suma = suma % 11;

      suma = 11 - suma;

      suma = suma == 10 ? 0 : suma == 11 ? 1 : suma;

      

      return suma == int.Parse(numero[10].ToString());
    }
  }
}
