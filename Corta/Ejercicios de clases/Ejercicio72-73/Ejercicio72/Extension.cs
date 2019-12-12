using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio72
{
    public static class Extension
    {
        public static int cantidadDeDigitos(this long dato)
        {
            string aux = dato.ToString();
            return aux.Length;
            
        }


        public static int cantidadDeComasPuntos(this string dato)
        {
            int contador = 0;
            for (int i = 0; i < dato.Length; i++)
            {
                if(dato[i] == '.' || dato[i]== ',' || dato[i] == ';'){
                    contador++;
                }
            }
            return contador;
        }
    }
}
