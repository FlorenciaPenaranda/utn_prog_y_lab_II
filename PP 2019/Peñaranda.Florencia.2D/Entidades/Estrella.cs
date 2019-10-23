using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estrella : Astro
    {
        private int cantPlanetas;
        private Clase clase;
        private List<Planeta> planetas;


        public Estrella(int duracionOrbita, int duracionRotacion, string nombre)
            : base(duracionOrbita, duracionRotacion, nombre)
        {
            this.planetas = new List<Planeta>();
        }

        public Estrella(int duracionOrbita, int duracionRotacion, string nombre, int cantidadPlanetas, Clase clase)
            : this(duracionOrbita, duracionRotacion, nombre)
        {
            this.cantPlanetas = cantidadPlanetas;
            this.clase = Clase;
        }

        public int CantidadPlanetas
        {
            get { return this.cantPlanetas; }
            set { cantPlanetas = value; }
        }

        public Clase Clase
        {
            get { return this.clase; }
            set { clase = (Clase)value; }
        }

        public List<Planeta> Planetas
        {
            get { return this.planetas; }
            set { Planetas = (List<Planeta>)value; }
        }

        public new string Rotar()
        {
            return String.Format($"Rotala estrella {this.Nombre}");
        }

        public override string Orbitar()
        {
            return String.Format("Orbita la estrella a un agujero negro supermasivo");
        }

        public static bool operator +(Estrella e, Planeta p)
        {
            foreach (Planeta item in e.planetas)
            {
                if (item.Nombre == p.Nombre)
                {
                    return false;
                }
            }
            e.planetas.Add(p);
            return true;
        }

        public static bool operator -(Estrella e, Planeta p)
        {
            foreach (Planeta item in e.planetas)
            {
                if (item.Nombre == p.Nombre)
                {
                    e.planetas.Remove(p);
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Estrella e, Planeta p)
        {
            foreach (Planeta item in e.planetas)
            {
                if (item.Nombre == p.Nombre)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Estrella e, Planeta p)
        {
            return !(e == p);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nEstrella");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Cantidad de planetas: " + this.cantPlanetas);
            sb.AppendLine("Clase: " + this.clase);
            foreach (Planeta item in planetas)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public static implicit operator List<Planeta>(Estrella e)
        {
            return e.planetas;
        }

        //public static explicit operator List<Satelite>(Estrella e)
        //{
        //    return e.planetas.ToString();
        //}
    }
}
