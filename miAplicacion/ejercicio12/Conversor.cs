using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    class Conversor
    {
        public static string DecimalBinario (double numero)
        {
            string cadena = numero.ToString();
            Convert.ToByte(cadena);           
            
            return cadena;            
        }
        public static double BinarioDecimal(string cadena)
        {
            Convert.ToDecimal(cadena);
            double doble = double.Parse(cadena);

            return doble;            
        }
    }
}
