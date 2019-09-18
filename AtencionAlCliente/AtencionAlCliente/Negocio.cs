using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class Negocio
    {
        PuestoDeAtencion puesto;
        Queue<Cliente> clientes; // instanciar las colecciones* 
        string nombre;
        
        public Queue<Cliente> Misclientes
        {
            get { return clientes; }
            set { clientes = value; }
        }

        private Negocio()
        {
            this.puesto = new PuestoDeAtencion(PuestoDeAtencion.Puesto.caja1);
            this.clientes = new Queue<Cliente>(); // *coleccion instanciada.            
        }

        public Negocio(PuestoDeAtencion puesto, Queue<Cliente> clientes, string nombre)
            :this()
        {
            this.nombre = nombre;         
        }






    }
}
