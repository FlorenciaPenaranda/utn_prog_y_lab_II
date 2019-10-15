using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaSolar
    {
        private List<Planeta> planetas;
        public List<Planeta> Planetas
        {
            get { return this.planetas; }
        }

        public SistemaSolar()
        {
            this.planetas = new List<Planeta>();
        }

        public string MostrarInformacionAstros()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Planeta item in planetas)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
