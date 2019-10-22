using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Planeta : Astro
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
            :base(duracionOrbita, duracionRotacion, nombre)
        {
            satelites = new List<Astro>();
        }

        public Planeta(int duracionOrbita, int duracionRotacion, string nombre, int cantidadSatelites, Tipo tipo)
            : base(duracionOrbita, duracionRotacion, nombre)
        {
            this.cantidadSatelites = cantidadSatelites;
            this.tipo = tipo;
        }

        public override string Orbitar()
        {
            return string.Format($"Orbita el planeta: {base.nombre}");
        }
        public override string Rotar()
        {
            return string.Format($"Rotando el planeta: {base.nombre}");
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostar());
            sb.AppendLine("Cantidad de satelites: " + this.cantidadSatelites);
            sb.AppendLine("Tipo: " + this.tipo);
            return sb.ToString();
        }

        public static bool operator +()
        { }




    }
}

