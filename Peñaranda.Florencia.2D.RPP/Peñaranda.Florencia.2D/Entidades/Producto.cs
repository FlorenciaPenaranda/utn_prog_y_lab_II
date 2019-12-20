using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        #region Atributos
        protected string codigo;
        protected string descripcion;
        protected float precio;
        #endregion

        #region Propiedades

        public string Codigo
        {
            get { return this.codigo; }
        }

        public string Descripcion
        {
            get { return this.descripcion; }
        }

        public float PorcentajeIntereses
        {
            get;
        } 
            
        public float Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        #endregion

        #region Constructor
        public Producto(string codigo, string descripcion,float precio)
        {

        }
        #endregion

        #region Metodos
        public abstract float CalcularInteres();

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Código: " + this.codigo);
            sb.AppendLine("Descripción: "+ this.descripcion);
            sb.AppendLine("Precio: " + this.Precio);
            return sb.ToString();
        }
        #endregion




    }
}
