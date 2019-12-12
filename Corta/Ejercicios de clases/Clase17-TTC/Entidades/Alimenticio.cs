using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alimenticio : Producto
    {
        private DateTime vencimiento;

        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }
            set
            {
                this.vencimiento = value;
            }
        }

        public Alimenticio(int id, string desc, DateTime venc) : base(id, desc)
        {
            this.vencimiento = venc;
        }
    }
}
