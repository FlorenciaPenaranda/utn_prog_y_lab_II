using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoA : Producto
    {
        #region Atributos
        protected DateTime vencimiento;
        #endregion

        #region Propiedades

        public DateTime Vencimiento
        {
            get { return this.vencimiento; }
            set
            {
                if (ValidarVencimiento(this.vencimiento))
                {
                    this.vencimiento = value;
                }                
            }
        }

        public new float PorcentajeIntereses
        {
            get
            {
                return 21;
            }
        }
        #endregion

        #region Constructor
        public ProductoA(string codigo, string descripcion, float precio, DateTime vencimiento)
            : base(codigo, descripcion, precio)
        {
            this.vencimiento = vencimiento;
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

        protected bool ValidarVencimiento(DateTime vencimiento)
        {
            if ((vencimiento - DateTime.Now).Days < 30)
            {
                return true;
            }
            return false;
        }

        public override float CalcularInteres()
        {
            return base.precio + (base.precio * 0.21f);
        }
        #endregion
    }
}
