using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    ///  Clase pública que hereda de Astro
    /// </summary>
    public class Satelite : Astro
    {
        /// <summary>
        /// Propiedad que retorna el nombre del satélites
        /// </summary>
        public string Nombre
        {
            get { return base.Nombre; }
        }

        /// <summary>
        /// Constructor que recibe los mismos parámetros que el Base
        /// </summary>
        /// <param name="duracionOrbita"></param>
        /// <param name="duracionRotacion"></param>
        /// <param name="nombre"></param>
        public Satelite(int duracionOrbita, int duracionRotacion, string nombre)
            : base(duracionOrbita, duracionRotacion, nombre)
        {

        }

        /// <summary>
        ///  Método que sobreescribe el base y retorna un mensaje.
        /// </summary>
        /// <returns></returns>
        public override string Orbitar()
        {
            return String.Format($"Orbitar el satelite: {this.Nombre}");
        }
        /// <summary>
        /// Sobrecarga del ToString() que retorna la información del objeto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nSATELITE");
            sb.AppendLine(base.Mostrar());
            return sb.ToString();
        }
    }
}
