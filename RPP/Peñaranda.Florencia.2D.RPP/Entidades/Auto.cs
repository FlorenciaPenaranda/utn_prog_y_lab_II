using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        protected string transmision;

        public enum eTransmision
        {
            Seleccionar,
            AT,
            Manual
        }

        public Auto(string patente, string dueño, int dniDueño, string transmision, string color)
             : base(patente, dueño, dniDueño, color)
        {
            this.transmision = transmision;
        }

        public override string Seguridad()
        {
            string retorno = "Estimado cliente: Recuerde utilizar el cinturón de seguridad, encender las luces bajas al entrar y salir del garage. ";
            if (this.transmision == "Manual")
            {
                retorno += "Dentro del garage, solo puede circular en primera marcha.";
            }
            return retorno.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();                        
            sb.AppendLine(base.ToString());
            sb.AppendLine("Transmision: " + this.transmision);
            sb.AppendLine(this.Seguridad());
            return sb.ToString();
        }
    }
}
