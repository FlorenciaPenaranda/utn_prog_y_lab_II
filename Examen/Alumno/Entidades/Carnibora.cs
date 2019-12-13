using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carnibora : ReinoVegetal, IVegetales<Carnibora>
    {
        // Tipos del enumerado: Pinzas, Pelos, Caída, Mecánicas, Combinada
        private Captura tipo;
        private int tamanio;

        public enum Captura
        {
            Pinzas,
            Pelos,
            Caída,
            Mecánicas,
            Combinada
        }

        public Captura Tipo
        {
            get
            {
                return this.tipo;
            }

        }

        public int Tamanio
        {
            get
            {
                return this.tamanio;
            }

        }

        public Carnibora(float valor, Gusto gusto, Captura tipo)
            :base(valor, gusto)
        {
            // Completar
            this.tipo = tipo;
        }

        public Carnibora(float valor, Gusto gusto, Captura tipo, int tamanio)
            :this(valor, gusto, tipo)
        {
            // Completar
            this.tamanio = tamanio;
        }

        public string MostrarDatos(IVegetales<Carnibora> elemento)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Tamaño: " + this.tamanio);
            sb.AppendLine("Carnivora Tipo : " + this.tipo);
            return sb.ToString();
        }
    }
}
