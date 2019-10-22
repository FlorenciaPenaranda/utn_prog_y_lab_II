using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    public abstract class Producto
    {
        private int id_Producto;
        private string descripcion;

        public Producto(int id, string descripcion)
        {
            this.id_Producto = id;
            this.descripcion = descripcion;
        }

        public int Id
        {
            get { return id_Producto; }
        }

    }
}
