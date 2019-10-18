using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Centralita
{
    public class Centralita
    {
        private List<Llamada> llamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.llamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciaLocal
        {
            get { return CalcularGanancia(TipoLlamada.Local); }
        }

        public float GananciaProvincial
        {
            get { return CalcularGanancia(TipoLlamada.Provincial); }
        }

        public float GananciaTodas
        {
            get { return CalcularGanancia(TipoLlamada.Todas); }
        }
        public List<Llamada> Llamadas
        {
            get { return this.llamadas; }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0;

            foreach (Llamada item in llamadas)
            {
                if (tipo == TipoLlamada.Local)
                {
                    if (item is Local)
                    {
                        ganancia = +((Local)item).CostoLlamada;
                    }
                }
                if (tipo == TipoLlamada.Provincial)
                {
                    if (item is Provincial)
                    {
                        ganancia = +((Provincial)item).CostoLlamada;
                    }
                }
                if (tipo == TipoLlamada.Todas)
                {
                    ganancia = CalcularGanancia(TipoLlamada.Local) + CalcularGanancia(TipoLlamada.Provincial);
                }
            }
            return ganancia;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Razon social: "+ this.razonSocial);
            sb.AppendLine("Costo total de llamaas: " + this.GananciaTodas);
            if () ;
            return sb.ToString(); 
        }






    }


}
    
