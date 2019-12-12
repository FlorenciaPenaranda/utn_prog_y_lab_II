using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej11
{
   public static class Validar
    {
        public static bool validate(int valor, int min, int max)
        {
            if(valor >= min && valor <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
