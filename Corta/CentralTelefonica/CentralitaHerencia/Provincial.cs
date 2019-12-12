using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{

    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Provincial(Franja miFranja, Llamada l1) : base(l1.Duracion, l1.NumeroDestino, l1.NumeroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            if (this.franjaHoraria == Franja.Franja_1)
                return Duracion * (float)0.99;
            else if (this.franjaHoraria == Franja.Franja_2)
                return Duracion * (float)1.25;
            else
                return Duracion * (float)0.66;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("Llamada tipo Provincial");
            sb.AppendLine($"Franja Horarioa : {this.franjaHoraria}");
            sb.AppendLine($"Costo llamada : {this.CostoLlamada}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }


    }
}
