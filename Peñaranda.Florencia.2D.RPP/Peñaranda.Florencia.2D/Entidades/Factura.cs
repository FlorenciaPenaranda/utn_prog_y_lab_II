using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        #region Atributos
        protected string cuit;
        protected string razonSocial;
        protected List<Producto> productos;
        #endregion

        #region Constructores
        protected Factura()
        {
            productos = new List<Producto>();
        }
        public Factura(string cuit, string razonSocial)
            : this()
        {
            this.cuit = cuit;
            this.razonSocial = razonSocial;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Factura f, Producto p)
        {
            foreach(Producto item in f.productos)
            {
                if (item.Codigo == p.Codigo) //PREGUNTAR
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Factura f, Producto p)
        {
            return !(f == p);
        }

        public static bool operator +(Factura f, Producto p)
        {
            foreach(Producto item in f.productos)
            {
                if(item != p)
                {
                    f.productos.Add(p);
                    return true;
                }
            }
            return false;
        }
        #endregion

        protected string ImprimirFactura()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cuit: " + this.cuit);
            sb.AppendLine("Razon social: " + this.razonSocial);
            foreach(Producto item in this.productos)
            {
                item.Mostrar();
            }
            return sb.ToString();
        }


    }
}
