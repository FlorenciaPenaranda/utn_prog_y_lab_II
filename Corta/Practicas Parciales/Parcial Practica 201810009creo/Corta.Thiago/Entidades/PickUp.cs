using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private static int valorHora;


        #region Constructores
        static PickUp()
        {
            valorHora = 70;
        }

        public PickUp(string patente, string modelo) : base(patente)
        {
            this.modelo = modelo;
        }

        public PickUp(string patente, string modelo, int valorHor) : base(patente)
        {
            this.modelo = modelo;
            valorHora = valorHor;
        }
        #endregion

        #region Metodos
        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PickUp");
            sb.AppendLine($"Patente : {base.Patente}");
            sb.AppendLine($"Modelo {this.modelo}");
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
            if(obj is PickUp)
            {
                return true;
            }
            return false;
        }



        #endregion




    }
}
