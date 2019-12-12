using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public int AñosExperiencia
        {
            get
            {
                return this.añosExperiencia;
            }
            set {
                this.añosExperiencia = value;
            }
        }

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosexp) : base(nombre, apellido, edad, dni)
        {
            this.añosExperiencia = añosexp;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Años experiencia : {this.añosExperiencia}");
            return sb.ToString();

        }

        public override bool ValidarAptitud()
        {
            bool aux = false;
            if (base.Edad <= 65 && this.añosExperiencia >= 2)
            {
                aux = true;
            }
            return aux;
        }


    }
}
