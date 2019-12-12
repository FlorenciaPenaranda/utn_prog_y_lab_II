using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_38_
{
    abstract class SobreEscrito
    {
        protected string miAtributo;

        public SobreEscrito()
        {
            this.miAtributo = "Probar abstractos";
        }
        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Este es mi metodo to string sobreescrito!");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
           if(this.GetType() == obj.GetType())
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }

    }
}
