using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    class Ferreteria : Producto
    {
        private float peso;

        public Ferreteria(int id, string descripcion, float peso)
            :base(id, descripcion)
        {
            this.peso = peso;
        }
    }
}
