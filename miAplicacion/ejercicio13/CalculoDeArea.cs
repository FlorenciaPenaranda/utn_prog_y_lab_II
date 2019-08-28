using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            return Math.Pow(lado, 2);
            
        }
        public static double CalcularTriangulo(double bas, double altura)
        {
            return (bas * altura) / 2 ;
        }
        public static double CalcularCirculo(double radio)
        {
            return (3.14 * (Math.Pow(radio, 2)));
        }
    }
}
