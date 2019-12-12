using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        private float costo;

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }

        }

        private float CalcularCosto()
        {
            return this.costo * base.duracion;
        }

        public Local(Llamada l1, float costo) : base(l1.Duracion, l1.NumeroDestino, l1.NumeroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo ) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Llamada tipo LOCAL");
            sb.AppendLine($"Costo de llamada : {this.CostoLlamada}");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
