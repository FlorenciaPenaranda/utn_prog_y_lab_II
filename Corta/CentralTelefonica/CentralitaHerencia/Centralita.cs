using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamada;
        private string razonSocial;


        public Centralita()
        {
            this.listaDeLlamada = new List<Llamada>();
        }
        public float GananciasPorLocal { get { return CalcularGanancia(Llamada.TipoLlamada.Local); } }
        public float GananciasPorProvincial { get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
        public float GananciasPorTotal { get { return CalcularGanancia(Llamada.TipoLlamada.Todas); } }
        public List<Llamada> Llamadas { get { return listaDeLlamada; } }

        public Centralita(string empresa) : this()
        {
            this.razonSocial = empresa;
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamada.Sort(Llamada.OrdenarPorDuracion);
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Razon Social :  " + this.razonSocial);
            sb.AppendLine("Acumulado : " + this.CalcularGanancia(Llamada.TipoLlamada.Todas));
            sb.AppendLine("Locales : " + this.CalcularGanancia(Llamada.TipoLlamada.Local));
            sb.AppendLine("Provinciales : " + this.CalcularGanancia(Llamada.TipoLlamada.Provincial));
            sb.AppendLine("");
            foreach (Llamada item in listaDeLlamada)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float acum = 0;
            Local local;
            Provincial provincial;

            foreach (Llamada item in listaDeLlamada)
            {
                if (tipo == Llamada.TipoLlamada.Todas)
                {
                    if (item is Local)
                    {
                        local = (Local)item;
                        acum += local.CostoLlamada;
                    }
                    else
                    {
                        provincial = (Provincial)item;
                        acum += provincial.CostoLlamada;
                    }

                }
                else if (tipo == Llamada.TipoLlamada.Local)
                {
                    if (item is Local)
                    {
                        local = (Local)item;
                        acum += local.CostoLlamada;
                    }
                }
                else if (tipo == Llamada.TipoLlamada.Provincial)
                {
                    if (item is Provincial)
                    {
                        provincial = (Provincial)item;
                        acum += provincial.CostoLlamada;
                    }
                }

            }
            return acum;
        }

        private void AgregarLlamada(Llamada l1)
        {
            this.listaDeLlamada.Add(l1);
        }

        public static bool operator ==(Centralita cen, Llamada l1)
        {
            foreach (Llamada item in cen.listaDeLlamada)
            {
                if(item == l1)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Centralita cen, Llamada l1)
        {
            return !(cen == l1);
        }

        public static Centralita operator +(Centralita cen, Llamada l1)
        {
            try
            {
                if (cen != l1)
                {
                    cen.AgregarLlamada(l1);
                }
            }
            catch(Exception e)
            {
                throw new CentralitaException("La llamada ya existe", "nose", " +", e);
            }
           
            return cen;
        }


    }
}

