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

        public Jugador(string nombre, string apellido, int dni, int edad, float altura, float peso, Posicion posicion) : base(nombre, apellido, dni, edad)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }

        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        public float Peso
        {
            get
            {
                return this.peso;
            }
        }

        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }


        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Altura: " + this.altura);
            sb.AppendLine("Peso: " + this.peso);
            sb.AppendLine("Posicion: " + this.posicion);
            sb.AppendLine(base.Mostrar());
            return sb.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            if ((peso / (this.altura * this.altura)) <= 25 &&
                    (peso / (this.altura * this.altura)) <= 18.5)
            {
                return true;
            }
            return false;
        }

        public override bool ValidarAptitud()
        {
            if ((base.Edad > 18 || base.Edad <= 40) && ValidarEstadoFisico() == true)
            {
                return true;
            }
            return false;
        }









    }
}
