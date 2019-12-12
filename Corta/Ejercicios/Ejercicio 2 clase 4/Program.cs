using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_clase_4
{
  class Program
  {
    static void Main(string[] args)
    {

      string cadena = "";
      Empleado emp1 = new Empleado();
      double jubilacion;
      double obrasocial;
      double ley;
      double sueldo;
      Console.WriteLine("Ingresar sueldo bruno : ");
      if (double.TryParse(Console.ReadLine(), out sueldo))
      {

        obrasocial = Empleado.CalcularPorcentaje(sueldo, 3);
        jubilacion = Empleado.CalcularPorcentaje(sueldo, 11);
        ley = Empleado.CalcularPorcentaje(sueldo, 3);

        emp1 = new Empleado("thiago", "Corta", sueldo, jubilacion, ley, obrasocial);
        cadena = emp1.MostrarEmpleado();
        Console.WriteLine(cadena);

        emp1.Aumento(20);
        cadena = emp1.MostrarEmpleado();
        Console.WriteLine(cadena);

        emp1.Aumento(2000);
        cadena = emp1.MostrarEmpleado();
        Console.WriteLine(cadena);




      }

      Console.ReadKey();
    }
  }
}
