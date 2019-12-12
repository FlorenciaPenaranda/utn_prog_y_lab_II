using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_20
{
  class Program
  {
    static void Main(string[] args)
    {
      //Generar un nuevo proyecto del tipo Console Application. Construir tres clases dentro de un
      //namespace llamado Billetes: Pesos, Euro y Dolar.

      //a.Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí
      //con total normalidad como si fueran tipos numéricos, teniendo presente que 1 Euro
      //equivale a 1,16 dólares y 1 dólar equivale a 38,33 pesos.

      //b.El atributo cotizRespectoDolar y el método GetCotizacion son estáticos.

      //c.Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los
      //distintos tipos de datos.

      //d.Colocar dentro del Main el código necesario para probar todos los métodos.

      //e.Los constructores estáticos le darán una cotización respecto del dólar por defecto a las
      //clases.

      //f.Los comparadores == compararan cantidades.

      //g.Para operar dos tipos de monedas, se deberá convertir todo a una y luego realizar lo pedido.
      //Por ejemplo, si quiero sumar Dólar y Euro, deberé convertir el Euro a Dólar y luego
      //sumarlos.

      //h.Reutilizar el código.Sólo realizar las conversiones dentro de los operadores para dicho uso.

      Console.Title = "Ejercicio 20";

      Dolar dolar = new Dolar(100);
      Dolar dolar2 = new Dolar(100);
      Peso peso = new Peso(1000);
      Euro euro = new Euro(100);
      Euro euro2 = new Euro(100);

      Console.WriteLine($"Get cantidad: Euro {euro.GetCantidad()} Dolar {dolar.GetCantidad()} Peso {peso.GetCantidad()}");
      Console.WriteLine($"\nGet cotizacion: Euro {Euro.GetCotizacion()} Dolar {Dolar.GetCotizacion()} Peso {Peso.GetCotizacion()}");

      dolar = (Dolar)peso;
      Console.WriteLine($"\nConv. explicita peso a dolar: {dolar.GetCantidad()}");

      dolar = (Dolar)euro;
      Console.WriteLine($"Conv. explicita euro a dolar: {dolar.GetCantidad()}");

      euro = (Euro)peso;
      Console.WriteLine($"Conv. explicita peso a euro: {euro.GetCantidad()}");

      euro = (Euro)dolar2;
      Console.WriteLine($"Conv. explicita dolar a euro: {euro.GetCantidad()}");

      peso = (Peso)euro2;
      Console.WriteLine($"Conv. explicita euro a peso: {peso.GetCantidad()}");

      peso = (Peso)dolar2;
      Console.WriteLine($"Conv. explicita dolar a peso: {peso.GetCantidad()}");

      Console.WriteLine("\nConv. implicita desde double\n");

      dolar = 100;
      euro = 100;
      peso = 100;

      Console.WriteLine($"Dolar: {dolar.GetCantidad()} Euro: {euro.GetCantidad()} Peso: {peso.GetCantidad()}");

      dolar = (Dolar)peso;
      Console.WriteLine($"\nPeso a dolar {dolar.GetCantidad()}");

      peso = (Peso)dolar;
      Console.WriteLine($"Dolar a peso {peso.GetCantidad()}");

      peso = (Peso)euro;
      Console.WriteLine($"Euro a peso {peso.GetCantidad()}");

      euro = (Euro)peso;
      Console.WriteLine($"Peso a euro {euro.GetCantidad()}");

      dolar = (Dolar)euro;
      Console.WriteLine($"Euro a dolar {dolar.GetCantidad()}");

      euro = (Euro)dolar;
      Console.WriteLine($"Dolar a euro {euro.GetCantidad()}");

      Console.ReadKey();
    }
  }
}
