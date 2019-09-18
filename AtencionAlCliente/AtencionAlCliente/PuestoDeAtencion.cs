using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class PuestoDeAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        static PuestoDeAtencion()
        {
            PuestoDeAtencion.numeroActual = 0;    
        }

        public PuestoDeAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public static int MiNumeroActual { get { return numeroActual + 1; } }

        public enum Puesto
        {
            caja1,
            caja2
        }

        public bool Atender(Cliente cli)
        {
            System.Threading.Thread.Sleep(5000);  //duerme le programa en milisegundo.
            return true;
        }


    }
}
