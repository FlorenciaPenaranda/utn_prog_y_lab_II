using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public Vehiculo(string patente)
        {
            this.ingreso = DateTime.Now.AddHours(-3);
            this.Patente = patente;
        }

        public override string ToString()
        {
            return String.Format("Patente {0}", this.patente);
        }

        #region Propiedades

        public string Patente
        {
            get
            {
                if(!(this.patente is null))
                {
                    return this.patente;
                }
                return "";
            }
            set
            {
                if(value.Length == 6)
                {
                    this.patente = value;
                }
            }
        }

        #endregion


        #region Metodos
        public abstract string ConsultarDatos();

        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ingreso : {this.ingreso}");
            sb.AppendLine($"Patente : {this.ToString()}");
            return sb.ToString();
        }

        #endregion

       
        #region Operadores
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
           if(v1.patente == v2.patente && v1.Equals(v2))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.patente == v2.patente);
        }

        #endregion




    }
}
