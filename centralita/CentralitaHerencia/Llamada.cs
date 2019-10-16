using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroORigen;           

        public float Duracion
        {
            get { return duracion; }
        }

        public string NroDestino
        {
            get { return nroDestino; }
        }

        public string NroORigen
        {
            get { return nroORigen; }
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroORigen = nroOrigen;
        }

        public string mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Duracion: {o}\nNro destino: {1}\nNro origen: {2}", this.duracion, this.nroDestino, this.nroORigen);
            return str.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return 0;
        }
    }
}
