using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private List<T> lista;

        public Torneo(string nombre)
        {
            this.nombre = nombre;
            this.lista = new List<T>();
        }

        public string JugarPartido
        {
            get
            {
                Random rnd = new Random();
                int aux = rnd.Next(1, this.lista.Count);
                int aux1 = rnd.Next(1, this.lista.Count);
                while (aux1 == aux)
                {
                    aux1 = rnd.Next(1, this.lista.Count);
                }
                return this.CalcularPartido(this.lista.ElementAt(aux), this.lista.ElementAt(aux1));
            }
        }
        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            if (torneo.lista.Contains(equipo))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }
        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if (torneo != equipo)
            {
                torneo.lista.Add(equipo);
                
            }
            return torneo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre torneo : {this.nombre}");
            sb.AppendLine($"Cantidad de equipos anotados : {this.lista.Count}");
            foreach (Equipo item in this.lista)
            {
                sb.AppendLine(item.Ficha());
            }
            return sb.ToString();
        }

        private string CalcularPartido(T e, T c)
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{e.Ficha()} {rnd.Next(0, 10)} - {c.Ficha()} {rnd.Next(0, 10)}");
            return sb.ToString();

        }




    }
}
