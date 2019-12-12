using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_31
{
  class Program
  {
    static void Main(string[] args)
    {
      Negocio neg = new Negocio("Negocio 1");
      Cliente c1 = new Cliente(1, "juan");
      Cliente c2 = new Cliente(2, "pepe"); 
      Cliente c3 = new Cliente(1, "nene");
      neg.Cliente = c1;
      neg.Cliente = c2;
      neg.Cliente = c3;
      





    }
  }
}
