using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial: Llamada
    {
        Franja franjaHoraria;

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        public float CostoLlamadaProvincial
        {
            get { return CalcularCosto(); }
        }

        public Provincial(Llamada llamada,Franja franjaHoraria)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroORigen)
        {
            this.franjaHoraria = franjaHoraria;
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Duracion: {o}\nNro destino: {1}\nNro origen: {2}\nCosto: {3}", base.duracion, base.nroDestino, base.nroORigen, this.CostoLlamadaProvincial);
            return str.ToString();
        }

        private float CalcularCosto()
        {
            switch (franjaHoraria)
            {
                case 0:
                    return base.Duracion * 0.99f;
                    break;
                case 1:
                    return base.Duracion * 1.25f;
                    break;
                case 3:
                    return base.Duracion * 0.66f;
                    break;
            }
               

        }


    }
}
