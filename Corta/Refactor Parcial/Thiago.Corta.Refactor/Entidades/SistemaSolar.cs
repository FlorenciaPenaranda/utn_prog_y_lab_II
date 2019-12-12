using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaSolar
    {
        static List<Planeta> planetas;


        public List<Planeta> Planetas
        {
            get
            {
                return planetas;
            }
            set
            {
                if(!(value is null))
                {
                    planetas = value;
                }
            }
        }

        static SistemaSolar()
        {
            planetas = new List<Planeta>();
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
