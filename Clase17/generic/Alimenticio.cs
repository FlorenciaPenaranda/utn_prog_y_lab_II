using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    class Alimenticio : Producto
    {
        private DateTime vencimiento;

        public Alimenticio(int id, string descripcion, DateTime venc)
            : base(id, descripcion)
        {
            this.vencimiento = venc;
        }
    }
}
