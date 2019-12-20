using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoB : Producto
    {
        #region Atributos
        protected Tamaños tamaño;

        #endregion

        #region Enumerado
        public enum Tamaños
        {
            CHICO,
            MEDIANO,
            GRANDE,
            GENERICO
        }
        #endregion

        #region Propiedades
        public float PorcentajeInteres
        {
            get { return this.CalcularInteres(); }
        }

        public new float PorcentajeIntereses
        {
            get {
                float retorno;
                switch (this.tamaño)
                {
                    case Tamaños.CHICO:
                        retorno = 25;
                        break;
                    case Tamaños.MEDIANO:
                        retorno = 10;
                        break;
                    case Tamaños.GRANDE:
                        retorno = 15;
                        break;
                    default:
                        retorno = 21;
                        break;
                }
                return retorno;
            }
        }
        #endregion

        #region Constructores
        public ProductoB(string codigo, string descripcion, float precio)
            : base(codigo, descripcion, precio)
        {

        }
        public ProductoB(string codigo, string descripcion, float precio, Tamaños tamaño)
            :this(codigo, descripcion, precio)
        {
            this.tamaño = tamaño;
        }
        #endregion

        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Precio con interes: " + this.CalcularInteres());
            sb.AppendLine("Interes: " + this.PorcentajeIntereses);
            return sb.ToString();
        }

        public override float CalcularInteres()
        {
            float retorno;
            switch (this.tamaño)
            {
                case Tamaños.CHICO:
                    retorno = base.precio + (float)(base.precio * 0.25);
                    break;
                case Tamaños.MEDIANO:
                    retorno = base.precio + (base.precio * 0.10f);
                    break;
                case Tamaños.GRANDE:
                    retorno = base.precio + (base.precio * 0.15f);
                    break;
                default:
                    retorno = base.precio * this.PorcentajeInteres;

                    break;
            }
            return retorno;
        }
        #endregion

    }
}
