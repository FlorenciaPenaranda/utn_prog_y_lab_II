using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
    {
        double cantidad;
        static double cotizRespectoDolar;

        private Euro()
        {
            Euro.cotizRespectoDolar = 1.16;
        }

        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }


    }
}
