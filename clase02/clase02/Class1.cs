using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase02
//public es el nivel de accesibilidad.
{     //static, una sola instancia.
      //abstract, no tiene codigo, no se implementan, otras clases heredan las propiedad y la desarrollar.
      //out parametro por referencia. 
      //argumentos en empiezanConMinuscula, clases y metodos PrimerLetraMAyuscula.
    public static class Cuadrado
    {
        public static bool PotenciaCuadrado(int numero, out double potencia)
        {
            potencia = 0;
            if(numero <=0 )
            {
                return false;
            }
            else
            {
                potencia = Math.Pow(numero, 2);
                return true;
            
            }
        }
    }

    public static class Cubo
    {
        public static double PotenciaCubo(int numero)
        {
            return Math.Pow(numero, 3);
        }
    }
}
