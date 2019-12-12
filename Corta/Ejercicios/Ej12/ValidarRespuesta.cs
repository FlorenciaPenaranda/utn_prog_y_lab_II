using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej12
{
    public static class ValidarRespuesta
    {
         public static bool ValidateChar(char c)
        {

            bool x = false;
            if (c == 's')
            {
                x = true;
            }

            return x;


        }
    }
}
