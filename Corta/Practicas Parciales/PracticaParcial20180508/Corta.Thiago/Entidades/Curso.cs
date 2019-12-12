using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short anio;
        private Divisiones division;
        private Profesor profe;

        public string AnioDivision
        {
            get
            {
                return String.Format("Anio : {0} \n Division {1}", this.anio, this.division);
            }
        }

        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor) : this()
        {
            this.anio = anio;
            this.division = division;
            this.profe = profesor;
        }

        public static explicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(c.AnioDivision);
            c.alumnos.ForEach(item => sb.AppendLine(item.ExponerDatos()));
            return sb.ToString();
        }

        public static bool operator ==(Curso c, Alumno a)
        {
            if (c.AnioDivision == a.AnioDivision)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        public static Curso operator +(Curso c, Alumno a)
        {
            if(c == a)
            {
                c.alumnos.Add(a);
                return c;
            }
            return c;
        }
    }
}
