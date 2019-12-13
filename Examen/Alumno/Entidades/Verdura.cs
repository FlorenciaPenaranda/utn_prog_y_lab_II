using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Verdura : ReinoVegetal, IVegetales<Verdura>
    {
        // Tipos del enumerado Semilla, Raíz, Tubérculo, Bulbo, Tallo, Hoja, Inflorescencia, Rizoma
        private TipoVerdura tipo;

        public enum TipoVerdura
        {
            Semilla,
            Raíz,
            Tubérculo,
            Bulbo,
            Tallo,
            Hoja,
            Inflorescencia,
            Rizoma
        }

        public TipoVerdura Tipo
        {
            get
            {
                return this.tipo;
            }

        }

        public Verdura(float valor, Gusto gusto, TipoVerdura tipo)
            :base(valor, gusto)
        {
            // Completar
            this.tipo = tipo;
        }


        public string MostrarDatos(IVegetales<Verdura> elemento)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Verdura Tipo" + this.tipo);
            return sb.ToString();
        }
    }
}
