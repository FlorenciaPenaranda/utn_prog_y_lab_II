using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string documento;
        private string nombre;


        public Persona(string nombre, string apellido, string documento)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.Documento = documento;
        }

        #region Propiedades

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public string Documento
        {
            get
            {
                return this.documento;
            }
            set
            {
                if (this.ValidarDocumentacion(value))
                {
                    this.documento = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        #endregion

        public virtual string ExponerDatos()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre : {this.nombre}");
            sb.AppendLine($"Apellido : {this.apellido}");
            sb.AppendLine($"Documento : {this.documento}");
            return sb.ToString();
        }

        protected abstract bool ValidarDocumentacion(string doc);




    }
}
