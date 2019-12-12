using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        private int x;
        private int y;


        public int GetX() {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }
    }
}
