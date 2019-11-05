using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    abstract class Universitario : Persona
    {
        protected int legajo;

        public Universitario() 
        {        
        }

        public Universitario(string nombre, string apellido, int dni, ENacionalidad nacionalidad, int legajo)
            :base(nombre, apellido,  dni, nacionalidad)
        {
            this.legajo = legajo;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj); // PREGUNTAR
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
