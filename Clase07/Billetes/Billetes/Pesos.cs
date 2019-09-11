using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Pesos
    {
        double cantidad;
        static double cotizRespectoDolar;

        private Pesos()
        {
            Pesos.cotizRespectoDolar = 38.33;
        }

        public Pesos(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizRespectoDolar; 
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public explicit operator Dolar(Pesos p)
        {
            

        }

    }
}
