using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_clase
{

  class Empleado
  {
    public string nombre { get; set; }
    public string apellido { get; set; }
    public double sueldoBruto { get; set; }
    public double sueldoNeto { get; set; }
    public double jubilacion { get; set; }
    public double ley19032 { get; set; }
    public double obraSocial { get; set; }

    public Empleado()
    {

    }

    public Empleado(string nombre, string apellido, double sueldoBruto)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.sueldoBruto = sueldoBruto;
    }

    public Empleado(string nombre, string apellido, double sueldoBruto,
                    double jubilacion, double ley, double obraSocial) : this(nombre, apellido, sueldoBruto)
    {
      this.jubilacion = jubilacion;
      this.ley19032 = ley;
      this.obraSocial = obraSocial;
      CalcularNeto();
    }

    private void CalcularNeto()
    {
      double aux;
      aux = this.jubilacion + this.obraSocial + this.ley19032;
      this.sueldoNeto = this.sueldoBruto - aux;

    }

    public static double CalcularPorcentaje(double sueldoBruto, int porcentaje)
    {
      return sueldoBruto * porcentaje / 100;
    }

    public string MostrarEmpleado()
    {
      string cadena = "";
      cadena += "Nombre : ";
      cadena += this.nombre.ToString() + "\n";
      cadena += "Apellido : ";
      cadena += this.apellido.ToString() + "\n";
      cadena += "Jubliacion : ";
      cadena += this.jubilacion.ToString() + "\n";
      cadena += "Ley 19032 : ";
      cadena += this.ley19032.ToString() + "\n";
      cadena += "Obra social : ";
      cadena += this.obraSocial.ToString() + "\n";
      cadena += "Sueldo bruto : ";
      cadena += this.sueldoBruto.ToString() + "\n";
      cadena += "Sueldo neto : ";
      cadena += this.sueldoNeto.ToString() + "\n";
      return cadena;
    }


  }
}

