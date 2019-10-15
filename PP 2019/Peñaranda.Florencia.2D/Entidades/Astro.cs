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

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Duracion de orbita: " + this.duracionOrbita);
            sb.AppendLine("Duracion de rotacion: " + this.duracionRotacion);
            return sb.ToString();
        }

        public abstract string Orbitar();

        public virtual string Rotar()
        {
          return String.Format($"\nRotando. Tiempo estimado: {this.duracionRotacion}");
        }

        public static explicit operator string(Astro a)
        {
            return a.nombre.ToString();
        }

    }
}
