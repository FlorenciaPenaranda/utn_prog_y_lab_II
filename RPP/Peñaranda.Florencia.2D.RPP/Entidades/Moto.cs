using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        protected int cilindrada;

        public Moto(string patente, string dueño, int dni, int cilindrada, string color) 
            : base(patente, dueño, dni, color)
        {
            this.cilindrada = cilindrada;
        }

        public override string Seguridad()
        {
            return "Estimado cliente: Recuerde utilizar casco y mantener las luces encendidas al circular por el garage.".ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Cilindrada: " + this.cilindrada);
            sb.AppendLine(this.Seguridad());
            return sb.ToString();
        }


    }
}
