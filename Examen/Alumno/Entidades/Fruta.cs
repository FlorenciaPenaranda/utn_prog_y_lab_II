using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{    
    public class Fruta : ReinoVegetal, IVegetales<Fruta>
    {
        private ConsoleColor color;

        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }
           
        }

        public Fruta(float valor, Gusto gusto, ConsoleColor color)
            :base(valor, gusto)
        {
            // Completar
            this.color = color;
        }

        public string MostrarDatos(IVegetales<Fruta> elemento)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Color" + this.color);
            return sb.ToString();
        }
    }
}
