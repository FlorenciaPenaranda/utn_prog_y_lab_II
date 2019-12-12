using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Divisiones division;
        private int legajo;


        public Alumno(string nombre, string apellido, string documento,int legajo, short anio, Divisiones division) : base(nombre, apellido, documento)
        {
            this.anio = anio;
            this.division = division;
            this.legajo = legajo;
        }
        public string AnioDivision
        {
            get
            {
                return String.Format("Anio : {0} \n Division {1}", this.anio, this.division);
            }
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            if(doc.Length == 9)
            {
                return true;
            }
            return false;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine(this.AnioDivision);
            sb.AppendLine($"Legajo : {this.legajo}");
            return sb.ToString();
        }

    }
}
