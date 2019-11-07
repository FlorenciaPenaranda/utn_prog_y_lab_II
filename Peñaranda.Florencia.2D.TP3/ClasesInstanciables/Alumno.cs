using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;


namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        public enum EEstadoCuenta
        {
            Aldia,
            Deudor,
            Becado
        }

        public Alumno()
            : base()
        {
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.estadoCuenta = estadoCuenta;
        }

        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            foreach (Universidad.EClases item in a.claseQueToma)
            {
                if (a.claseQueToma)
            }
        }

        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return !(a == clase);
        }

        protected override string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ParticipaEnClase());
            sb.AppendLine("Estado de cuenta: " + this.estadoCuenta);
            return sb.ToString();
        }

        public override string ToString()
        {
            return base.MostrarDatos();
        }

        protected override string ParticipaEnClase()
        {
            return String.Format($"TOMA CLASE DE: {this.claseQueToma}");
        }
    }
}
