using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class PlanetaEnano : Planeta
    {

        public PlanetaEnano(int duracionOrbita, int duracionRotacion, string nombre)
            : base(duracionOrbita, duracionRotacion, nombre)
        {
            base.Nombre = "Planton";
        }

        public PlanetaEnano(string nombre)
            : base(0, 0, nombre)
        {

        }

        public new string Rotar()
        {
            return String.Format($"Gira el planeta enano {base.Nombre}");
        }

        public override string Orbitar()
        {
            return String.Format($"Se traslada el planeta enano {base.Nombre}");
        }


    }
}
