using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    class Calculadora
    {
        public static double Calcular(double primerNumero, double segundoNumero, char operacion)
        {
            if(operacion == '+')
            {
                return primerNumero + segundoNumero;
            }
            else if (operacion == '-')
            {
                return primerNumero - segundoNumero;
            }
            else if (operacion == '*')
            {
                return primerNumero * segundoNumero;
            }
            else if (operacion == '/')
            {
                return primerNumero / segundoNumero;
                /*VALIDAR SEGUNDO PARAMETRO???????*/
            }else
            {
                return 0;//false
            }
        }

        static bool Validar(double segundoNumero)
        {
            if(segundoNumero < 0)
            {
                return false;
            }else
            {
                return true;
            }

        }
    }
}
