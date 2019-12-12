using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Satelite : Astro
    {
        public string Nombre
        {
            get
            {
                return base.nombre;
            }
        }

        public Satelite(int duracionOrbita, int duraRotacion, string nombre) : base(duracionOrbita, duraRotacion, nombre)
        {

        }

        public override string Orbitar()
        {
            return String.Format($"Orbitar el satelite : {this.Nombre}");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n" + base.Mostrar() );
            return sb.ToString();
        }

    }
}
