using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(float duracion, string nroOrigen, string nroDestino)
            : base(duracion, nroOrigen, nroDestino)
        {

        }
        public Local(float duracion, string nroOrigen, string nroDestino, float costo)
            : base(duracion, nroOrigen, nroDestino)
        {
            this.costo = costo;
        }
        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            return base.duracion * this.costo;
        }
        protected new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Costo: " + this.costo);
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Local)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }








    }
}
