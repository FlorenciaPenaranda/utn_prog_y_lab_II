using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_38_
{
    class SobreEscritoo : SobreEscrito
    {
        public override string MiPropiedad { get { return base.miAtributo; } }
        public override string MiMetodo()
        {
            return "holaaaaaaaaaaaaaa";
        }
    }
}
