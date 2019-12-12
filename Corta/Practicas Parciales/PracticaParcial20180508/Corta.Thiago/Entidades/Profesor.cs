using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public int Antiguedad { get
            {
                return (DateTime.Now - this.fechaIngreso).Days;
            }
        }

        public Profesor(string nombre, string apellido, string documento) : base(nombre, apellido, documento)
        {

        }

        public Profesor(string nombre, string apellido, string documento, DateTime fechaing) : base(nombre, apellido, documento)
        {
            this.fechaIngreso = fechaing;
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            if(doc.Length == 8)
            {
                return true;
            }
            return false;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine($"Fecha ingreso : {this.fechaIngreso}");
            return sb.ToString();
             
        }

    }
}
