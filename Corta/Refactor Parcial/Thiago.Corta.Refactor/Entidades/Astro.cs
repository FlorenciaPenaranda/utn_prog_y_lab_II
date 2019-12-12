using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Astro
    {
        private int duracionOrbita;
        private int duracionRotacion;
        protected string nombre;

        public Astro(int duracionOrbita, int duracionRotacion, string nombre)
        {
            this.duracionOrbita = duracionOrbita;
            this.duracionRotacion = duracionRotacion;
            this.nombre = nombre;
        }


        #region Metodos
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre :{this.nombre}");
            sb.AppendLine($"Duracion Orbita : {this.duracionOrbita}");
            sb.AppendLine($"Duracion Rotacion : {this.duracionRotacion}");
            return sb.ToString();
        }

        public abstract string Orbitar();

        public virtual string Rotar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rotando. Tiempo estimado : {this.duracionRotacion}");
            return sb.ToString();
        }

        public static explicit operator string(Astro a)
        {
            return a.nombre;
        }
        #endregion


    }
}
