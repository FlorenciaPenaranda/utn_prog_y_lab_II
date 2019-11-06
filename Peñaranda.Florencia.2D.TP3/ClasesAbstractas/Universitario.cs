using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        public Universitario() 
            :base()
        {        
        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(nombre, apellido,  dni, nacionalidad)
        {
            this.legajo = legajo;
        }

        /// <summary>
        /// Sobrescribe el metodo Equals 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>devuelve true si el objeto es del tipo Universitario o false si no lo es.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Universitario)
            {
                return this == (Universitario)obj;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return legajo;
        }

        protected virtual string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Legajo: " + this.legajo);
            return sb.ToString();
        }

        protected abstract string ParticipaEnClase();

        public static bool operator ==(Universitario pg1, Universitario pg2) 
        {
            if (pg1.Dni == pg2.Dni || pg1.legajo == pg2.legajo) 
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
    }
}
