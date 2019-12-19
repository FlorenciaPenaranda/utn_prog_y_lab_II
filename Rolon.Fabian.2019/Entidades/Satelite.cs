using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Satelite : Astro
    {
        public Satelite(int duraOrbita, int duraRotacion, string nombre)
            :base(duraOrbita, duraRotacion, nombre)
        {
        }
        /// <summary>
        /// Retorna el atributo nombre del satelite
        /// </summary>
        public string Nombre
        {
            get
            {
                return base.nombre; 
            }
        }
        /// <summary>
        /// Sobreescribe Orbitar de la clase Madre e informa el nombre del satelite que esta orbitando
        /// </summary>
        /// <returns>Retorna un string</returns>
        public override string Orbitar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Orbitar el satelite: {0}\n", Nombre);
            return str.ToString();
        }
        /// <summary>
        /// Sobrecarga el operador string para que devuelva los datos del satelite
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>
        public override string ToString()
        {
           return base.Mostrar();
        }


    }
}
