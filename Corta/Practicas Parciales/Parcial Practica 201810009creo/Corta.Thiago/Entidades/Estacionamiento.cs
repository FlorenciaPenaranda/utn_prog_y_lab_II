using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;


        #region constructores
        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
            this.nombre = nombre;
        }
        #endregion

        #region Operadores

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre : {e.nombre}");
            sb.AppendLine($"Espacio Disponible : {e.espacioDisponible}");
            foreach (Vehiculo item in e.vehiculos)
            {
                sb.AppendLine(item.ConsultarDatos());
            }
            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento e ,Vehiculo v1)
        {
            return (e.vehiculos.Exists(vehi => vehi == v1 && vehi.Equals(v1)));
            
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v1)
        {
            return !(e == v1);
        }

        public static string operator -(Estacionamiento e, Vehiculo v1)
        {
            StringBuilder sb = new StringBuilder();
            if(e == v1)
            {
                sb.AppendLine(v1.ImprimirTicket());
                e.vehiculos.Remove(v1);
            }
            else
            {
                sb.AppendLine("El vehiculo no es parte del estacionamiento");
            }
            return sb.ToString();
        }

        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v1)
        {
            if(v1.Patente != null &&  v1.Patente.Length == 6 &&  e.espacioDisponible > e.vehiculos.Count && e != v1)
            {
                e.vehiculos.Add(v1);
                return e;
            }
            return e;
        }
        #endregion




    }
}
