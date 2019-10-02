using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectoTecnico : Persona
    {
        private int añosExperiencia;

        public int AñosExperiencia
        {
            get { return this.añosExperiencia; }
            set { this.añosExperiencia = value; }
        }

        public DirectoTecnico(string nombre, string apellido, int dni, int edad, int añosExperiencia) : base(nombre, apellido, dni, edad)
        {
            this.añosExperiencia = añosExperiencia;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Años de experiencia: " + this.añosExperiencia);
            sb.AppendLine(base.Mostrar());
            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            if((base.Edad > 18 || base.Edad < 65) && this.añosExperiencia >= 2)
            {
                return true;
            }
            return false;
        }

    }
}
