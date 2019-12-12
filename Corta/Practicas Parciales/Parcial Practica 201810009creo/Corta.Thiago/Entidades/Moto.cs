using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        
        private int cilindrada;
        private short ruedas;
        private static int valorHora;


        #region Constructores
        static Moto()
        {
            valorHora = 30;
            
        }

        public Moto(string patente, int cilindrada) : base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = 2;
        }

        public Moto(string patente, int cilindrada, short ruedas) : base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = ruedas;
        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHoras) : base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = ruedas;
            valorHora = valorHoras;
        }
        #endregion

        #region Metodos
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Moto");
            sb.AppendLine($"Patente : {base.Patente}");
            sb.AppendLine($"Cilindrada :{this.cilindrada}");
            sb.AppendLine($"Ruedas : {this.ruedas}");
            sb.AppendLine($"Valor Estadia :  {(DateTime.Now.Hour - base.ingreso.Hour) * valorHora}");
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
            if (obj is Moto)
            {
                return true;
            }
            return false;
        }



        #endregion

    }
}
