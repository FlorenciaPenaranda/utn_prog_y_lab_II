using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        protected const int capacidad = 5;
        protected static Estacionamiento estacionamiento_singleton;
        protected string nombre;
        protected int precioAuto;
        protected int precioMoto;
        protected List<Vehiculo> vehiculos;

        public string Nombre
        {
            get { return this.nombre; }
        }

        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }

        private Estacionamiento(string nombre, int precioMoto, int precioAuto)
            : this()
        {
            this.nombre = nombre;
            this.precioMoto = precioMoto;
            this.precioAuto = precioAuto;
        }

        public static Estacionamiento InstanciarEstacionamiento(string nombre, int precioMoto, int precioAuto)
        {
            if (estacionamiento_singleton is null)
            {
                estacionamiento_singleton = new Estacionamiento(nombre, precioMoto, precioAuto);
            }
            return estacionamiento_singleton;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre : " + this.nombre);
            sb.AppendLine("Precio moto: " + this.precioMoto);
            sb.AppendLine("Precio auto: " + this.precioAuto);
            foreach (Vehiculo item in this.vehiculos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public static explicit operator int(Estacionamiento e)
        {
            return e.vehiculos.Count;
        }

        public static bool operator +(Estacionamiento e, Vehiculo v)
        {
            if (!(e is null) && !(v is null))
            {
                if ((int)e < capacidad)
                {
                    e.vehiculos.Add(v);
                    return true;
                }
            }
            return false;
        }




    }
}
