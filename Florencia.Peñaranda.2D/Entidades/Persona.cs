using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;
        
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }         
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        public Persona (string nombre,string apellido,int dni,int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
        }
         
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("DNI: " + this.dni);
            sb.AppendLine("Edad: "+ this.edad);
            return sb.ToString();
        }

        public abstract bool ValidarAptitud();
        


    }
}
