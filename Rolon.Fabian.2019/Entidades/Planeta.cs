using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planeta : Astro
    {
        int cantSatelites;
        Tipo tipo;
        List<Astro> satelites;

        public Planeta(int duraOrbita, int duraRotacion, string nombre)
            : base(duraOrbita, duraRotacion, nombre)
        {             
        }

        public Planeta(int duraOrbita, int duraRotacion, string nombre, int cantSatelites, Tipo tipo)
            : this(duraOrbita, duraRotacion, nombre)
        {
            this.cantSatelites = cantSatelites;
            if (this.cantSatelites > 0)
            {
                satelites = new List<Astro>(cantSatelites);
            }
            this.tipo = tipo;
        }
        /// <summary>
        /// Devuelve la lista de satelites
        /// </summary>
        public List<Astro> Satelites
        {
            get
            {
                return satelites;   
            }
        }
        /// <summary>
        /// Sobrecarga el operador suma para agregar un satelite a un planeta
        /// </summary>
        /// <param name="planeta"></param>
        /// <param name="satelite"></param>
        /// <returns>Devuleve true si se pudo agregar, false caso contrario</returns>
        public static bool operator +(Planeta planeta, Astro satelite)
        {
            if (satelite is Satelite && planeta.Satelites != null && planeta.Satelites.Count < planeta.Satelites.Capacity )  
            {
                planeta.Satelites.Add(satelite);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Sobrecarga del operador igualdad para saber si ya esta agregado un satelite en un planeta
        /// </summary>
        /// <param name="planeta"></param>
        /// <param name="satelite"></param>
        /// <returns>Devuelve true si ya esta, false caso contrario</returns>
        public static bool operator ==(Planeta planeta, Satelite satelite)
        {
            foreach (Satelite satelites in planeta.Satelites)
            {
                if(satelites.Nombre == satelite.Nombre)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador desigualdad para saber si no esta agregado un satelite en un planeta
        /// </summary>
        /// <param name="planeta"></param>
        /// <param name="satelite"></param>
        /// <returns>>Devuelve true si no esta, false caso contrario</returns>
        public static bool operator !=(Planeta planeta, Satelite satelite)
        {
            return !(planeta == satelite); 
        }
        /// <summary>
        /// Sobrecarga el operador igualdad para saber si dos planetas son iguales comparando el nombre
        /// </summary>
        /// <param name="planeta"></param>
        /// <param name="planeta2"></param>
        /// <returns>Devuelve true si son iguales, false caso contrario</returns>
        public static bool operator ==(Planeta planeta, Planeta planeta2)
        {
            if(planeta.nombre == planeta2.nombre)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Sobrecarga el operador desigualdad para saber si dos planetas no son iguales comparando el nombre
        /// </summary>
        /// <param name="planeta"></param>
        /// <param name="planeta2"></param>
        /// <returns>Devuelve true si no son iguales, false caso contrario</returns>
        public static bool operator !=(Planeta planeta, Planeta planeta2)
        {
            return !(planeta == planeta2);
        }
        /// <summary>
        /// No sobreescribe el metodo de la clase Madre y muestra que planeta esta rotando
        /// </summary>
        /// <returns>Devuelve un string con el nombre del planeta</returns>
        public new string Rotar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Rotar el planeta: {0}\n", nombre);
            /*str.AppendLine(base.Rotar());*/
            return str.ToString();
        }
        /// <summary>
        /// Sobreescritura del metodo de la clase Madre y devuelve el planeta que esta orbitando
        /// </summary>
        /// <returns>Retorna un string con el nombre del planeta</returns>
        public override string Orbitar()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Orbitar el planeta: {0}\n", nombre);
            return str.ToString();
        }
        /// <summary>
        /// Sobreescribe el metodo para que muestre todos los datos de un planeta y sus satelites
        /// </summary>
        /// <returns>Retorna un string con los datos</returns>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(base.Mostrar());
            str.AppendFormat("Cantidad de satelites: {0}\nTipo: {1}\n", cantSatelites, tipo);
            str.AppendLine("Satelites del planeta: ");
            if(Satelites != null)
            {
                foreach (Satelite sat in Satelites)
                {
                    str.AppendLine(sat.ToString());
                }
            }
            str.AppendLine("-------------");
            return str.ToString();
        }
    }
}
