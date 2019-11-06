﻿using System;
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
                if (ValidarNombreApellido(value) != null)
                {
                    this.nombre = value;
                }
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
                if (ValidarNombreApellido(value) != null)
                {
                    this.apellido = value;
                }
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
                this.dni = ValidarDni(this.nacionalidad, value);
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
                this.dni = ValidarDni(this.nacionalidad, value);

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

            if (this.nacionalidad == ENacionalidad.Argentino && (dato >= 1 || dato <= 89999999))
            {
                return dato;
            }
            else if (this.nacionalidad == ENacionalidad.Extranjero && (dato >= 90000000 || dato <= 99999999))
            {
                return dato;
            }
            else
            {
                throw new DniInvalidoException();
            }
        }
        protected int ValidarDni(ENacionalidad nacionalidad, string dato)
        {

            if (int.TryParse(dato, out int dni))
            {
                return ValidarDni(nacionalidad, dni);
            }
            else
            {
                throw new DniInvalidoException();
            }

        }

        protected string ValidarNombreApellido(string dato)
        {
            foreach (char item in dato)
            {
                if (!char.IsLetter(item) || char.IsWhiteSpace(item))
                {
                    return null;//preguntar por la propiedad o carga de datos cuando retorna null
                }
            }
            return dato;
        }


    }
}

