using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IMensaje
    {
        string Usuario { get; set; }
        string Texto { get; set; }
        DateTime Hora { get; set; }

    }
}
