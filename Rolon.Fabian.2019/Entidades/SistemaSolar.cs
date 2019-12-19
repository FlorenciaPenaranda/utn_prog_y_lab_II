using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaSolar
    {
        List<Astro> planetas;

        public SistemaSolar()
        {
            planetas = new List<Astro>();
        }

        public List<Astro> Planetas
        {
            get
            {
                return planetas;
            }
        }

        public string MostrarInformacionAstros()
        {
            StringBuilder str = new StringBuilder();
            foreach (Planeta planetas in Planetas)
            {
               str.AppendLine(planetas.ToString());
                foreach (Satelite satelites in planetas.Satelites)
                {
                    str.AppendLine(satelites.ToString());
                }
            }
            return str.ToString();
        }
    }
}
