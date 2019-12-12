using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        private int id_prod;
        private string descripcion;

        public int IdProducto
        {
            get { return id_prod; }
            set { id_prod = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Producto(int id, string desc)
        {
            this.id_prod = id;
            this.descripcion = desc;
        }



    }
}
