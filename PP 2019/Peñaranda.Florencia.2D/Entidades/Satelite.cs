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
            get { return base.nombre; }
        }

        public Satelite(int duracionOrbita, int duracionRotacion, string nombre)
            : base(duracionOrbita, duracionRotacion, nombre)
        {

        }

        public override string Orbitar()
        {
            return String.Format("$Orbitar el satelite: {base.nombre}");
        }

        public override string ToString()
        {
            return base.Mostrar();
        }
    }
}
