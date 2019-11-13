using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Patente
    {
        private string codPatente;
        private Tipo tipoCodigo;

        public enum Tipo
        {
            Vieja,
            Mercosur
        }


        public string CodigoPAtente
        {
            get
            {
                return this.codPatente;
            }
            set
            {
                this.codPatente = value;
            }
        }

        public Tipo TipoCodigo
        {
            get
            {
                return this.tipoCodigo;
            }
            set
            {
                this.tipoCodigo = value;
            }
        }

        public Patente()
        {

        }

        public Patente(string codPatente, Tipo tipoCodigo)
            : this()
        {

        }


    }
}
