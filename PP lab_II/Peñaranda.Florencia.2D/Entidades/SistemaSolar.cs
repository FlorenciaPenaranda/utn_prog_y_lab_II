using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class SistemaSolar
    {
        private List<Astro> planetas;

        public List<Astro> Planetas
        {
            get
            {
                return this.planetas;
            }
        }

        private SistemaSolar()
        {
            planetas = new List<Astro>();
        }

        public string MostrarInformacionAstros()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Planeta p in planetas)
            {
                sb.AppendLine(p.ToString());
                foreach (Satelite s in p.Satelites)
                {
                    sb.AppendLine(s.ToString());
                }

            }
            return sb.ToString();
        }

    }
}

