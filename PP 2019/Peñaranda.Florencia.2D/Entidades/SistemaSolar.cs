using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase pública
    /// </summary>
    public class SistemaSolar
    {
        private List<Planeta> planetas;

        /// <summary>
        /// Propiedad que retorna la lista de planetas
        /// </summary>
        public List<Planeta> Planetas
        {
            get { return this.planetas; }
        }

        /// <summary>
        ///  Constructor sin parámetros que instancia la lista.
        /// </summary>
        public SistemaSolar()
        {
            this.planetas = new List<Planeta>();
        }

        /// <summary>
        ///  Método que retorna toda la información de los planetas, y sus satélites
        /// </summary>
        /// <returns></returns>
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
