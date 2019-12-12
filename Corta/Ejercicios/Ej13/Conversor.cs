using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13
{
    public static class Conversor
    {
        public static string DecimalBinario(double x)
        {
            long m = BitConverter.DoubleToInt64Bits(x);
            return Convert.ToString(m,2);
        }

        public static double BinarioDecimal(string x)
        {
            return BitConverter.Int64BitsToDouble(Convert.ToInt64(x, 2));

        }
    }
}
