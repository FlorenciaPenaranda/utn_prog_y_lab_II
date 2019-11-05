using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;


namespace ClasesAbstractas
{
    abstract class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }


        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

        public string StringToDni
        {
            set
            {
                this.dni = int.Parse(value);
            }
        }

        public Persona()
        {

        }
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
        }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.dni = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.dni = int.Parse(dni);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Apellido: " + this.Apellido);
            sb.AppendLine("Dni: " + this.Dni);
            sb.AppendLine("Nacionalidad: " + this.Nacionalidad);
            return sb.ToString();
        }

        protected int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int retorno = -1;
            if (this.nacionalidad == ENacionalidad.Argentino && (dato >= 1 || dato <= 89999999))
            {
                retorno = dato;
            }
            else if (this.nacionalidad == ENacionalidad.Extranjero && (dato >= 90000000 || dato <= 99999999))
            {
                retorno = dato;
            }
            else
            {
                throw new DniInvalidoException();
            }
            return retorno;
        }

    }

        protected int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int retorno = -1;
            if (this.nacionalidad == ENacionalidad.Argentino && (int.Parse(dato) >= 1 || int.Parse(dato) <= 89999999))
            {
                retorno = 0;
            }
            else if (this.nacionalidad == ENacionalidad.Extranjero && (int.Parse(dato) >= 90000000 || int.Parse(dato) <= 99999999))
            {
                retorno = 1;
            }
            else 
            {                
                throw new DniInvalidoException();
            }
            return retorno;
    }

        protected string ValidarNombreApellido(string dato)
        {

        }



    }
}
