using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej14
{
   public static  class CalculoDeArea
    {
        public static double CalcularCuadrado(double x)
        {
            return x * 2;
        }

        public static double CalcularTriangulo(double basee, double altura)
        {
            return basee * altura / 2;
        }

        public static double CalcularCirculo(double diametro)
        {
            double radio = diametro / 2;

            return 3.14 * Math.Pow(radio, 2);

        }
    }

}
