using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                    this.directorTecnico = value;
            }
        }
        public string Nombre { get { return this.nombre; } }

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            if (e.directorTecnico != null && e.directorTecnico.Nombre != String.Empty)
                sb.AppendLine($"Director Tenico : {e.directorTecnico.Nombre} {e.directorTecnico.Apellido}");
            else
                sb.AppendLine($"Director Tenico : Sin definir");

            foreach (Jugador item in e.jugadores)
            {
                sb.AppendLine(item.Mostrar());
            }
            return sb.ToString();

        }

        public static bool operator ==(Equipo e, Jugador j)
        {

            foreach (Jugador item in e.jugadores)
            {
                if (j == item)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static bool ValidarEquipo(Equipo e)
        {
            bool ret = false;
            if (e != null && e.directorTecnico != null && e.directorTecnico.Nombre != "" && e.jugadores.Count == cantidadMaximaJugadores)
            {
                int aux = 0;
                int central = 0;
                int defensor = 0;
                int delantero = 0;
                foreach (Jugador item in e.jugadores)
                {
                    if (item.Posicion.Equals(Posicion.Arquero))
                    {
                        aux++;
                    }
                    else if (item.Posicion.Equals(Posicion.Central)) {
                        central++;
                    }else if (item.Posicion.Equals(Posicion.Defensor))
                    {
                        defensor++;
                    }else if (item.Posicion.Equals(Posicion.Delantero))
                    {
                        delantero++;
                    }
                }
                if (aux != 1)
                {
                    ret = false;
                }
                else if (aux == 1 && delantero>=1 && defensor>=1 && central>=1)
                {
                    ret = true;
                }
            }
            return ret;
        }

        public static Equipo operator +(Equipo e, Jugador x)
        {
            if (e != x && e.jugadores.Count < cantidadMaximaJugadores && x.ValidarAptitud() && !ValidarEquipo(e))
            {
                e.jugadores.Add(x);
            }

            return e;
        }


    }
}
