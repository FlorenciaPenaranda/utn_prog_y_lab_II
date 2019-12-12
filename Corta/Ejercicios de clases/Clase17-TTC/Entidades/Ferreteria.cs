using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ferreteria : Producto
    {
        private float peso;

        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public Ferreteria(float peso, int id, string desc) : base(id, desc)
        {
            this.peso = peso;
        }
    }
}
