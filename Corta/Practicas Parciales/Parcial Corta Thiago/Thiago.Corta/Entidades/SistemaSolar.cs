using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaSolar
    {
        static List<Astro> planetas;


        public List<Astro> Planetas
        {
            get
            {
                return planetas;
            }
        }

        static SistemaSolar()
        {
            planetas = new List<Astro>();
        }

        public string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Astro item in planetas)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();

        }
    }
}
