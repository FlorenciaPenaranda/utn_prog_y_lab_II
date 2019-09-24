using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona// clase abtracta se declara Pensona p; no se instancia(NO new)
    {
        public int cuil { get; set; }
        public string Nombre { get; set; }

        public Persona (string nombre, int cuil)
        {
            this.Nombre = nombre;
            this.cuil = cuil;
        }

        public abstract string Mostrar(); 

        public string Mostrar2()
        {
            return this.Nombre + this.cuil;
        }

    }
}
