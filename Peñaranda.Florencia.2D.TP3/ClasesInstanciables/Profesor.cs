using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> claseDelDia;
        private static Random random;

        static Profesor() 
        {
            random = new Random();
        }
        public Profesor()
            : base()
        {
            this.claseDelDia = new Queue<Universidad.EClases>();
            
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(id, nombre, apellido, dni, nacionalidad)
        {

        }

        static void RandomClases() 
        {
            
        }

        protected override string ParticipaEnClase()
        {
            return string.Format($"CLASE DEL DIA {this.claseDelDia}");
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ParticipaEnClase());
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }


    }
}
