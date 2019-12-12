using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            this.fechaCreacion = fecha;
        }

        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Equipo : {this.nombre} Fundado el {this.fechaCreacion.ToString()}");
            return sb.ToString();
        }
    }
}
