using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroOrigen;
        protected string nroDestino;

        public float Duracion
        {
            get { return this.duracion; }
        }
        public string NroDestino
        {
            get { return this.nroDestino; }
        }
        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        public abstract float CostoLlamada { get; }

        public Llamada(float duracion, string nroOrigen, string nroDestino)
        {
            this.duracion = duracion;
            this.nroOrigen = nroOrigen;
            this.nroDestino = nroDestino;
        }

        protected virtual string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion de la llamada: " + this.duracion);
            sb.AppendLine("Numero de origen: " + this.nroOrigen);
            sb.AppendLine("Numero destino: " + this.nroDestino);
            return sb.ToString();
        }

        public bool operator ==(Llamada l1, Llamada l2)
        {
            if(l1)
            
        }

        public bool operator !=(Llamada l1, Llamada l2)
        {

        }


    }
}
