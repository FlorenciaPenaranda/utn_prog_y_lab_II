using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace VistaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();
            Recibo hola = new Recibo();
            Recibo hola1 = new Recibo(213123);
            Recibo hola2 = new Recibo(555555);
            Factura chau = new Factura(111111);
            Factura chau1 = new Factura(2222222);
            Factura chau2 = new Factura(3333333);

            contabilidad += hola;
            contabilidad += hola1;
            contabilidad += hola2;

            contabilidad += chau;
            contabilidad += chau1;
            contabilidad += chau2;

            Console.ReadKey();

        }
    }
}
