using System;
using System.Text;
using System.Threading;
using System.Xml.Serialization;


namespace Entidades
{
    public abstract class Astro
    {
        protected int duraOrbita;
        protected int duracionRotacion;
        protected string nombre;

        private Thread hiloOrbita;
        private Thread hiloRotacion;

        public delegate string AstroDelegate(string elemento);
        public event AstroDelegate AstroEvent;


        public Thread HiloOrbita
        {
            get
            {
                return this.HiloOrbita;
            }
            set
            {
                this.HiloOrbita = value;
            }
        }

        public Thread HiloRotacion
        {
            get
            {
                return this.HiloRotacion;
            }
            set
            {
                this.HiloRotacion = value;
            }
        }

        public int DuraOrbita
        {
            get
            {
                return duraOrbita;
            }
            set
            {
                duraOrbita = value;
            }
        }

        public int DuraRotacion
        {
            get
            {
                return duracionRotacion;
            }
            set
            {
                duracionRotacion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public Astro() { }


        public Astro(int duraOrbita, int duraRotacion, string nombre)
        {
            this.duraOrbita = duraOrbita;
            this.duracionRotacion = duraRotacion;
            this.nombre = nombre;
        }

        protected string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Nombre: {this.nombre}");
            retorno.AppendLine($"Duracion de la orbita: {this.duraOrbita}");
            retorno.AppendLine($"Duracion de la rotacion: {this.duracionRotacion}");
            return retorno.ToString();
        }

        protected void runEvent(string elemento)
        {
            if (this.AstroEvent != null)
            {  
                this.AstroEvent.Invoke(elemento);
            }
        }

        //public bool NececitaInvocacion()
        //{
        //    if (!(this.AstroEvent is null) && this.AstroEvent.GetInvocationList() is null) return true;
        //    return false;
        //}
    }
}
