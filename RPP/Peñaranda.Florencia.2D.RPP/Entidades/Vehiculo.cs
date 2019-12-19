using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected string color;
        protected int dniDueño;
        protected string nombreDueño;
        protected string patente;

        public enum eColores
        {
            Seleccionar,
            Azul,
            Rojo,
            Blanco,
            Negro
        }

        private Vehiculo()
        {
            this.patente = string.Empty;
            this.nombreDueño = string.Empty;
            this.color = string.Empty;
        }

        public Vehiculo(string patente, string dueño, int dni, string color) : this()
        {
            this.patente = patente;
            this.nombreDueño = dueño;
            this.dniDueño = dni;
            this.color = color;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Patente: " + this.patente);
            sb.AppendLine("Dueño: " + this.nombreDueño);
            sb.AppendLine("DNI: " + this.dniDueño.ToString());
            sb.AppendLine("Color: " + this.color);
            return sb.ToString();
        }

        public abstract string Seguridad();      

    }
}
