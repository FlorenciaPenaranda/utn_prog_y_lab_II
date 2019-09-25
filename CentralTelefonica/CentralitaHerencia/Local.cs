using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Local : Llamada
    {
        protected float costo;

        public float CostoLlamadaLocal
        {
            get { return CalcularCosto(); }
        }

        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion,  llamada.NroDestino, llamada.NroORigen)
        {
            this.costo = costo;
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Duracion: {o}\nNro destino: {1}\nNro origen: {2}\nCosto: {3}", base.duracion, base.nroDestino, base.nroORigen, this.CostoLlamadaLocal);
            return str.ToString();
        }

        private float CalcularCosto()
        {
            return base.Duracion * this.costo;
        }
    }
}
