using System;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace Entidades
{
    public abstract class Astro
    {
        
        public event AstroDelegate AstroEvent;
        private Thread hiloRotacion;
        private Thread hiloOrbita;
        protected int duraOrbita;
        protected int duracionRotacion;
        protected string nombre;

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
        public Thread HiloOrbita { get { return this.hiloOrbita; } set { this.hiloOrbita = value; } }
        public Thread HiloRotacion { get { return this.hiloRotacion;  } set { this.hiloRotacion = value; } }

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

            retorno.AppendLine($"Nombre: {nombre}");
            retorno.AppendLine($"Duracion de la orbita: {duraOrbita}");
            retorno.AppendLine($"Duracion de la rotacion: {duracionRotacion}");
            return retorno.ToString();
        }

        public void InvocarEvento(string elemento)
        {
            if(this.AstroEvent != null)
            {
                this.AstroEvent.Invoke(elemento);
            }
           
        }

        public bool NececitaInvocacion()
        {
            if (!(this.AstroEvent is null) && this.AstroEvent.GetInvocationList() is null) return true;
            return false;
        }
    }
}
