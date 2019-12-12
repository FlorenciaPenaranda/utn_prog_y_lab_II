using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_15
{
    public static class Calculadora
    {


        public static bool Validate(int num)
        {
            
            if (num != 0)
            {
                return true;

            }
            else
            {
                Console.WriteLine("No se puede dividir por cero");
                return false;
            }

            
        }


        public static int Calcular(int x, int y, char signo){
            int cuenta=0;
            switch (signo)
            {
                case '/':
                    if (Validate(y))
                    {
                        cuenta = x / y;
                    }
                    break;
                case '-':
                    cuenta = x - y;
                    break;
                case '+':
                    cuenta = x + y;
                    break;
                case '*':
                    cuenta = x * y;
                    break;
            }
            return cuenta;
        }
    }
}
