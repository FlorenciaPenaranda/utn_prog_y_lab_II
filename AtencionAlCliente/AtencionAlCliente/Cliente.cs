using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionAlCliente
{
    public class Cliente
    {
        private string nombre;
        private int numero;


        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) 
            : this(numero)
        {
            this.nombre = nombre;
        }



        public string MiNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int MiNumero
        {
            get { return numero; }
        }

        public static bool operator ==(Cliente C1, Cliente C2)
        {
            if (C1.numero == C2.numero)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Cliente C1, Cliente C2)
        {
            return !(C1.numero == C2.numero);
        }



    }
}
