using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej19
{
    class Sumador
    {
        private int cantidadSumas;

        public Sumador()
        {

        }

        public Sumador(int aux)
        {
            this.cantidadSumas = aux;
        }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return String.Format("{0} {1}", a, b);
        }

        public static explicit operator int(Sumador p)
        {
            return p.cantidadSumas;
        }

        public static long operator +(Sumador p, Sumador q)
        {
            return p.cantidadSumas + q.cantidadSumas;
        }

        public static bool operator |(Sumador p, Sumador q)
        {
            if (p.cantidadSumas == q.cantidadSumas)
            {
                return true;
            }
            return false;
        }
    }
}
