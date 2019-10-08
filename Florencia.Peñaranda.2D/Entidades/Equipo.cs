using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Equipo
    {
        private string nombre;
        private DirectoTecnico directorTecnico;
        private List<Jugador> jugadores;
        private const int cantidadMaxJugadores = 6;

        public DirectoTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

        }

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            if (e.directorTecnico == null)
            {
                sb.AppendLine("Sin DT asignado");
            }
            else
            {
                sb.AppendLine("DT" + e.directorTecnico.Mostrar());
            }
            sb.AppendLine("JUGADORES"); //CONTROL KD!!!
            foreach (Jugador jugador in e.jugadores)
            {
                sb.AppendLine(jugador.Mostrar());
            }
            return sb.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            foreach (Jugador jugador in e.jugadores)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if (e != j && cantidadMaxJugadores > e.jugadores.Count && j.ValidarAptitud())
            {
                e.jugadores.Add(j);
                return true;
            }
            return false;
        }

        public static bool ValidarEquipo(Equipo e) // metodo de clase estatico 
        {
            int cantArquero = 0;
            int cantDefensor = 0;
            int cantCentral = 0;
            int cantDelantero = 0;
            
            foreach (Jugador jugadores in e.jugadores)
            {
                switch (jugadores.Posicion)
                {
                    case Posicion.Arquero:
                        cantArquero++;
                        break;
                    case Posicion.Defensor:
                        cantDefensor++;
                        break;
                    case Posicion.Central:
                        cantCentral++;
                        break;
                    case Posicion.Delantero:
                        cantDelantero++;
                        break;
                }

            }
            if (e.jugadores.Count == cantidadMaxJugadores && cantArquero == 1 && (cantDefensor > 0 || cantCentral > 0 || cantDelantero > 0))
                {
                return true;
                }
            return false;
        }




    }
}
