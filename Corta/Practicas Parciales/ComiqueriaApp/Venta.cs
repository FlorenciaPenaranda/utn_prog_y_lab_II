using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorniqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;

        static Venta()
        {
            porcentajeIva = 21;
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);
            
        }

        private void Vender(int cantidad) {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(this.producto.Precio, cantidad);
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double aux = 0;
            aux += precioUnidad * cantidad;
            aux -= aux * porcentajeIva / 100;
            return aux;
        }

        public string ObetenerDescripcionBreve() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fecha : {this.fecha} -- Descripcion : {this.producto.Descripcion} -- Precio Final : {this.precioFinal}");
            return sb.ToString();
        }

        internal DateTime Fecha{ get { return this.fecha; } }

    }
}
