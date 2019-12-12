using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    
    public abstract class Llamada
    {
        protected float duracion;
        protected string numeroDestino;
        protected string numeroOrigen;

        #region Propiedades
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NumeroDestino
        {
            get
            {
                return this.numeroDestino;
            }
        }
        public string NumeroOrigen
        {
            get
            {
                return this.numeroOrigen;
            }
        }

        public abstract float CostoLlamada { get; }
        #endregion

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.numeroOrigen = nroOrigen;
            this.numeroDestino = nroDestino;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion : {this.duracion}");
            sb.AppendLine($"Numero Origen : {this.numeroOrigen}");
            sb.AppendLine($"Numero Destino : {this.numeroDestino}");
            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada l1 , Llamada l2)
        {
            int rtn = 0;

            if (l2.duracion > l1.duracion) rtn = -1;
            else if (l2.duracion < l1.duracion) rtn = 1;
            
            return rtn;
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if (l1.Equals(l2))
            {
                if(l1.NumeroOrigen == l2.NumeroOrigen && l1.NumeroDestino == l2.NumeroDestino && l1.Equals(l2))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

    }
}
