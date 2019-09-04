using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repaso
{
    public class Producto
    {
        string codigoDeBarra;
        string marca;
        float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;

        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            return string.Format("-Codigo de barras: {0}\n -Marca: {1}\n -Precio: {2}",p.codigoDeBarra, p.marca, p.precio);
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca)
            {
                return true;
            }
            else
            {
                return false;
            }
            /*
             * 
             * Otra forma seria:
                return (p1==p2);            
             */
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p1, string marca)
        {
            return (p1.marca == marca);
        }

        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1.marca == marca);
        }

    }
}
