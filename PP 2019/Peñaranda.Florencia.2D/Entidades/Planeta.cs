using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planeta : Astro
    {
        private int cantidadSatelites;
        private Tipo tipo;
        private List<Satelite> satelites;

        public List<Satelite> Satelites
        {
            get { return this.satelites; }
        }

        public Planeta(int duracionOrbita, int duracionRotacion, string nombre)
            : base(duracionOrbita, duracionRotacion, nombre)
        {
            this.satelites = new List<Satelite>();
        }

        public Planeta(int duracionOrbita, int duracionRotacion, string nombre, int cantidadSatelites, Tipo tipo)
            : this(duracionOrbita, duracionRotacion, nombre)
        {
            this.cantidadSatelites = cantidadSatelites;
            this.tipo = tipo;
        }

        public static bool operator +(Planeta p, Satelite s)
        {
            if (s is Satelite)
            {
                p.satelites.Add(s);
                return true;
            }
            return false;
        }

        public static bool operator ==(Planeta p1, Planeta p2)
        {
            if (p1.nombre == p2.nombre)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Planeta p1, Planeta p2)
        {
            return !(p1 == p2);
        }

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

        public static bool operator !=(Planeta p, Satelite s)
        {
            return !(p == s);
        }

        public override string Orbitar()
        {
            return String.Format($"Orbita el planeta: {base.nombre}");
        }

        public new string Rotar()
        {
            return String.Format($"Rotando el planeta {base.nombre}");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nPLANETA");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Cantidad de satelites: " + this.cantidadSatelites);
            sb.AppendLine("Tipo: " + this.tipo);
            foreach(Satelite item in satelites)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
