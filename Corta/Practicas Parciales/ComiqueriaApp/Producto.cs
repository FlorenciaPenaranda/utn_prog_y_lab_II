using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorniqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string description;
        private double precio;
        private int stock;

        public string Descripcion { get { return this.description; } }
        public double Precio { get { return this.precio; } }
        public int Stock
        {
            get { return this.stock; }
            set
            {
                if (value > 0)
                {
                    this.stock = value;
                }

            }
        }


        public static explicit operator Guid(Producto p)
        {
            return p.codigo = Guid.NewGuid();
        }

        protected Producto(string descripcion, int stock, double precio)
        {
            this.description = descripcion;
            this.stock = stock;
            this.precio = precio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Descripcion : {this.description}");
            sb.AppendLine($"Codigo : {this.codigo.ToString()}");
            sb.AppendLine($"Precio : ${this.precio}");
            sb.AppendLine($"Stock : {this.stock}");
            return sb.ToString();
        }
    }
}
