using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase abstracta no se puede instanciar
    /// </summary>
    public abstract class Astro
    {
        int duracionOrbita;
        int duracionRotacion;
        protected string nombre;

        protected Astro(int duracionOrbita, int duracionRotacion, string nombre)
        {
            this.duracionOrbita = duracionOrbita;
            this.duracionRotacion = duracionRotacion;
            this.nombre = nombre;
        }
        /// <summary>
        /// Metodo abstracto
        /// </summary>
        /// <returns></returns>
        public abstract string Orbitar();

        public static explicit operator string(Astro astro)
        {
            return astro.nombre.ToString();
        }
        /// <summary>
        /// Metodo que muestra los valores de los atributos
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>
        protected string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Nombre: {0}\nOrbita: {1}\nRotacion: {2}", nombre, duracionOrbita, duracionRotacion);
            return str.ToString();
        }
        /// <summary>
        /// Informa la curacion de rotacion
        /// </summary>
        /// <returns>Retorna un string con el tiempor de rotacion</returns>
        public virtual string Rotar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Rotando. Tiempo  estimado: {0}\n", duracionRotacion);
            return str.ToString();
        }
    }
}
