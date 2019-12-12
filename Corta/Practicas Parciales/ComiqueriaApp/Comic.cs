using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorniqueriaLogic
{
    public class Comic : Producto
    {

        public enum TipoComic {
            Occidental,
            Oriental
        }

        private string autor;
        private TipoComic tipoComic;

        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipocomic) : base(descripcion, stock, precio) {
            this.autor = autor;
            this.tipoComic = tipocomic;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Autor : {this.autor}");
            sb.AppendLine($"Tipo Comic : {this.tipoComic}");
            return sb.ToString();
            
        }
    }
}
