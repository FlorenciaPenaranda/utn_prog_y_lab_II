using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        private const int MEDIDA = 400;

        public Agua(string marca, int capacidadMl, int contenidoMl)
            : base(marca, capacidadMl, contenidoMl)
        {

        }

        protected string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.toString());
            return sb.ToString();
        }

        public override int ServirMedida()
        {
            if (MEDIDA > base.contenidoMl)
            {
                return base.contenidoMl -= base.contenidoMl;
            }
            return base.contenidoMl -= MEDIDA;
        }

        public int ServirMedida(int medida)
        {
            return base.contenidoMl - medida;
        }
    }
}
