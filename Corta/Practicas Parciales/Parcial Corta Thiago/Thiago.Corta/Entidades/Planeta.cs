using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planeta : Astro
    {
        private int cantSatelites;
        private Tipo tipo;
        private List<Astro> satelites;


        public List<Astro> Satelites
        {
            get
            {
                return satelites;
            }
        }

        public Planeta(int duraOrbita, int duraRot,string nombre) : base(duraOrbita, duraRot, nombre)
        {
            satelites = new List<Astro>();
        }

        public Planeta(int duraOrbita, int duraRot, string nombre, int cantSatelites,Tipo tipo) : this(duraOrbita, duraRot, nombre)
        {
            this.cantSatelites = cantSatelites;
            this.tipo = tipo;
        }

        #region Operadores
        public static bool operator ==(Planeta planeta1, Planeta planeta2)
        {
            if (planeta1.nombre == planeta2.nombre)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Planeta planeta1, Planeta planeta2)
        {
            return !(planeta1 == planeta2);
        }

        public static Planeta operator +(Planeta planeta, Astro satelite)
        {
            if(satelite is Satelite)
            {
                if (planeta.Satelites.Contains(satelite))
                {
                    planeta.Satelites.Add(satelite);
                    return planeta;
                }
            }
            return planeta;
            
        }

        public static bool operator ==(Planeta planeta, Satelite satelite)
        {
            foreach (Satelite item in planeta.Satelites)
            {
                if(item.Nombre == satelite.Nombre)
                {

                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Planeta planeta, Satelite satelite)
        {
            return !(planeta == satelite);
        }

        #endregion

        public override string Orbitar()
        {
            return String.Format($"Orbita el planeta : {base.nombre}");
        }

        public new string Rotar()
        {
            return String.Format($"Rotando  el planeta {base.nombre}");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Tipo : {this.tipo}");
            sb.AppendLine($"Cantidad Satelites : {this.cantSatelites}");
            return sb.ToString();
        }
    }
}
