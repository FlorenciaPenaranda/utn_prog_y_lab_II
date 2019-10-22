using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Calse pública que hereda de Astro
    /// </summary>
    public class Planeta : Astro
    {
        private int cantidadSatelites;
        private Tipo tipo;
        private List<Satelite> satelites;

        /// <summary>
        ///  Propiedad que retorna la lista de satélites
        /// </summary>
        public List<Satelite> Satelites
        {
            get { return this.satelites; }
        }

        /// <summary>
        /// Constructor que recibe los mismos parámetros que el constructor de Astro
        /// </summary>
        /// <param name="duracionOrbita"></param>
        /// <param name="duracionRotacion"></param>
        /// <param name="nombre"></param>
        public Planeta(int duracionOrbita, int duracionRotacion, string nombre)
            : base(duracionOrbita, duracionRotacion, nombre)
        {
            this.satelites = new List<Satelite>();
        }

        /// <summary>
        ///  constructor que agrega cantSatelites y el tipo
        /// </summary>
        /// <param name="duracionOrbita"></param>
        /// <param name="duracionRotacion"></param>
        /// <param name="nombre"></param>
        /// <param name="cantidadSatelites"></param>
        /// <param name="tipo"></param>
        public Planeta(int duracionOrbita, int duracionRotacion, string nombre, int cantidadSatelites, Tipo tipo)
            : this(duracionOrbita, duracionRotacion, nombre)
        {
            this.cantidadSatelites = cantidadSatelites;
            this.tipo = tipo;
        }

        /// <summary>
        /// Sobrecarga el operador + para agregar un satélite a la lista
        /// </summary>
        /// <param name="p"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool operator +(Planeta p, Satelite s)
        {
            if (s is Satelite)
            {
                p.satelites.Add(s);
                return true;
            }
            return false;
        }

        /// <summary>
        ///  Compara si dos planetas son igules por el nombre
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Planeta p1, Planeta p2)
        {
            if (p1.nombre == p2.nombre)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Compara si dos planetas son distintos por el nombre
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Planeta p1, Planeta p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        ///  chequea, buscando por le nombre, si el satélite se encuentra en la lista
        /// </summary>
        /// <param name="p"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool operator ==(Planeta p, Satelite s)
        {
            foreach (Satelite item in p.satelites)
            {
                if (item.Nombre == s.Nombre)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        ///  chequea si el satélite No se encuentra en la lista
        /// </summary>
        /// <param name="p"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool operator !=(Planeta p, Satelite s)
        {
            return !(p == s);
        }

        /// <summary>
        /// Método que sobreescribe el base y retorna un mensaje.
        /// </summary>
        /// <returns></returns>
        public override string Orbitar()
        {
            return String.Format($"Orbita el planeta: {base.nombre}");
        }

        /// <summary>
        ///  Método que no sobreescribe el base y retorna un mensaje.
        /// </summary>
        /// <returns></returns>
        public new string Rotar()
        {
            return String.Format($"Rotando el planeta {base.nombre}");
        }

        /// <summary>
        /// Sobrecarga del ToString() que retorna la información del objeto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nPLANETA");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Cantidad de satelites: " + this.cantidadSatelites);
            sb.AppendLine("Tipo: " + this.tipo);
            foreach (Satelite item in satelites)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
