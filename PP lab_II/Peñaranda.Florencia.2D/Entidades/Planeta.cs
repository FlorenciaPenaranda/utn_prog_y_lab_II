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
        private List<Astro> satelites;

        public List<Astro> Satelites
        {
            get
            {
                return this.satelites;
            }
        }
        public Planeta(int duracionOrbita, int duracionRotacion, string nombre)
            : base(duracionOrbita, duracionRotacion, nombre)
        {
            satelites = new List<Astro>();
        }

        public Planeta(int duracionOrbita, int duracionRotacion, string nombre, int cantidadSatelites, Tipo tipo)
            : this(duracionOrbita, duracionRotacion, nombre)
        {
            this.cantidadSatelites = cantidadSatelites;
            this.tipo = tipo;
        }

        public override string Orbitar()
        {
            return string.Format($"Orbita el planeta: {base.nombre}");
        }
        public new string Rotar()
        {
            return string.Format($"Rotando el planeta: {base.nombre}");
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PLANETA");
            sb.AppendLine(base.Mostar());
            sb.AppendLine("Cantidad de satelites: " + this.cantidadSatelites);
            sb.AppendLine("Tipo: " + this.tipo);
            sb.AppendLine("\nSATELITE");
            foreach (Satelite item in satelites)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
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
            else
            {
                return false;
            }
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

    }
}

