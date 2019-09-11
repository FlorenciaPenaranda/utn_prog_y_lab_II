using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolar
    {
        double cantidad;
        static double cotizRespectoDolar; 

        private Dolar ()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        } 

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }
    }
}
