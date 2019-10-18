using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Provincial : Llamada
    {
        protected FranjaHoraria miFranja;

        public Provincial(float duracion, string nroOrigen, string nroDestino, FranjaHoraria franja)
            : base(duracion, nroOrigen, nroDestino)
        {
            this.miFranja = franja;
        }
        public Provincial(FranjaHoraria franja, Llamada llamada)
            : this(llamada.Duracion, llamada.NroOrigen, llamada.NroDestino, franja)
        {
            this.miFranja = franja;
        }
       
        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            float costoLlamadaProv;
            switch (this.miFranja)
            {
                case FranjaHoraria.Franja_1:
                    costoLlamadaProv = base.duracion * 0.99f;
                    break;
                case FranjaHoraria.Franja_2:
                    costoLlamadaProv = base.duracion * 1.25f;
                    break;
                case FranjaHoraria.Franja_3:
                    costoLlamadaProv = base.duracion * 0.66f;
                    break;
            }
            return CostoLlamada;
        }
        private new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Franja: " + this.miFranja);
            sb.AppendLine("Costo de Llamada: " + this.CostoLlamada);
            return sb.ToString();
        }




    }
}
