using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class ReinoVegetal
    {
        // Tipos del enumerado Dulce, Salado, Toxica
        
        private static Random calcularValor;
        protected float valor;
        protected Gusto gusto;

        public enum Gusto
        {
            Dulce,
            Salado,
            Toxica
        }
        static ReinoVegetal()
        {
            calcularValor = new Random();
        }

        public ReinoVegetal(Gusto gusto)
        {            
            this.valor = calcularValor.Next(1, 100);
            //*this.gusto = gusto;
        }

        public ReinoVegetal(float valor, Gusto gusto)
        {
            this.valor = valor;
            this.gusto = gusto;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Valor: " + this.valor);
            sb.AppendLine("Gusto: " +  this.gusto);
            return sb.ToString();
        }

        public static bool operator ==(ReinoVegetal rV1, ReinoVegetal rV2)
        {
            if (rV1.GetType() == rV2.GetType() && rV1.gusto == rV2.gusto)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(ReinoVegetal rV1, ReinoVegetal rV2)
        {
            return !(rV1 == rV2);
        }
    }
}
