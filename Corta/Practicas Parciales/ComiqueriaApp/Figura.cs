using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorniqueriaLogic
{
    public class Figura : Producto
    {
        private double altura;

        public Figura(int stock, double precio, double altura) : base(String.Format($"Figura {altura} cm"), stock, precio) {
            this.altura = altura;
        }

        public Figura(string descripcion, int stock, double precio, double altura) : base(descripcion, stock, precio) {
            this.altura = altura;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Altura : {this.altura} cm");
            return sb.ToString();
        }

    }
}
