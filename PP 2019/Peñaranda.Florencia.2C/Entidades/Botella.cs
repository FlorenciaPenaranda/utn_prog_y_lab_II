using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    abstract class Botella
    {
        protected int capacidadMl;
        protected int contenidoMl;
        protected string marca;


        public int PropCapacidadLitros
        {
            get { return this.capacidadMl / 1000; }
        }

        public int PropContenidoMl
        {
            get { return this.contenidoMl; }
            set { this.contenidoMl = value; }
        }

        public int PorcentajeContenido
        {
            get { return (this.contenidoMl * 100) / this.capacidadMl; }
        }

        protected Botella(string marca, int capacidadMl, int contenidoMl)
        {
            this.marca = marca;
            if (this.capacidadMl < this.contenidoMl)
            {
                this.contenidoMl = capacidadMl;
                this.capacidadMl = capacidadMl;
            }
            this.capacidadMl = capacidadMl;
            this.contenidoMl = contenidoMl;
        }

        protected string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Marca: " + this.marca);
            sb.AppendLine("Capacidad: " + this.capacidadMl);
            sb.AppendLine("Contenido: " + this.contenidoMl);
            return sb.ToString();
        }

        public override string toString()
        {
            return this.GenerarInforme();
        }

        public abstract int ServirMedida();

    }
}
