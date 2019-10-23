using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase abstracta
    /// </summary>
    public abstract class Astro
    {
        private int duracionOrbita;
        private int duracionRotacion;
        private string nombre;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value.ToString();
            }
        }

        public int DuracionOrbita
        {
            get
            {
                return this.duracionOrbita;
            }
            set
            {
                this.duracionOrbita = value;
            }
        }

        public int DuracionRotacion
        {
            get
            {
                return this.duracionRotacion;
            }
            set
            {
                this.duracionRotacion = value;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="duracionOrbita"></param>
        /// <param name="duracionRotacion"></param>
        /// <param name="nombre"></param>
        public Astro(int duracionOrbita, int duracionRotacion, string nombre)
        {
            this.duracionOrbita = duracionOrbita;
            this.duracionRotacion = duracionRotacion;
            this.nombre = nombre;
        }

        /// <summary>
        /// Método protegido que devuelve toda la información del astro.
        /// </summary>
        /// <returns></returns>
        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Duracion de orbita: " + this.duracionOrbita);
            sb.AppendLine("Duracion de rotacion: " + this.duracionRotacion);
            return sb.ToString();
        }

        /// <summary>
        /// Método abstracto
        /// </summary>
        /// <returns></returns>
        public abstract string Orbitar();

        /// <summary>
        ///  Método virtual que retorna un mensaje 
        /// </summary>
        /// <returns></returns>
        public virtual string Rotar()
        {
            return String.Format($"\nRotando. Tiempo estimado: {this.duracionRotacion}");
        }

        /// <summary>
        /// Conversor explícito de Astro a String que retorna el atributo nombre
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator string(Astro a)
        {
            return a.nombre.ToString();
        }

    }
}
