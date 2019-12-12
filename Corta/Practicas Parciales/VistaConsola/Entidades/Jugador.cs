using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public float Altura { get { return this.altura; } }
        public float Peso { get { return this.peso; } }
        public Posicion Posicion { get { return this.posicion; } }

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion)
            : base(nombre, apellido, edad, dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Altura : {this.altura}");
            sb.AppendLine($"Peso : {this.peso}");
            sb.AppendLine($"Posicion : {this.posicion}");
            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            bool aux = false;
            if (ValidarEstadoFisico() && base.Edad < 40)
            {
                aux = true;
            }
            return aux;
        }


        public bool ValidarEstadoFisico()
        {
            float aux = this.peso / (float)Math.Pow(this.altura,2);
            bool ret = false;
            if (aux>=18.5 && aux<=25)
            {
                ret = true;
            }
            return ret;
        }

    }
}
