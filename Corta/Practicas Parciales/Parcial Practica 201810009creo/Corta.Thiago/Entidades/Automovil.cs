using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;


        #region Constructores
        static Automovil()
        {
            valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color) : base(patente)
        {
            this.color = color;
        }

        public Automovil(string patente, ConsoleColor color, int valorHor) : base(patente)
        {
            this.color = color;
            valorHora = valorHor;
        }
        #endregion

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Automovil");
            sb.AppendLine($"Patente : {base.Patente}");
            sb.AppendLine($"Color {this.color}");
            sb.AppendLine($"Valor Estadia :  {(DateTime.Now.Hour - base.ingreso.Hour)*valorHora}");
            return sb.ToString();
            
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ImprimirTicket());
            sb.AppendLine(this.ConsultarDatos());
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if(obj is Automovil)
            {
                return true;
            }
            return false;
        }
    }
}
