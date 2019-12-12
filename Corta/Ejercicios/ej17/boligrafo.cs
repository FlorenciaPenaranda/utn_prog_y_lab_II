using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej17
{
    class Boligrafo
    {
        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private short SetTinta(short tinta)
        {
            short aux = 0;
            if(tinta>0)
            {
                if (this.tinta + tinta >99)
                {
                    this.tinta = 100;
                }
                else
                {
                    this.tinta += tinta;
                }
            }
            else
            {
                if (this.tinta + tinta <= 0)
                {
                    aux += this.tinta;
                    this.tinta = 0;
                }
                else
                {
                    aux = tinta;
                    this.tinta += tinta;
                }

            }
            return aux;
        }

        public void Recargar()
        {
            while(this.tinta < 100)
            {
                this.SetTinta((short)1);
            }
        }

        public bool Pintar(short tinta, out string pintar)
        {
            pintar = "";
            int gasto = tinta * -1;
            short cant = SetTinta((short)gasto);
            bool aux = false;

            for (short i = 0; i < (cant * -1); i++)
            {
                pintar += "*";
                aux = true;
            }
            return aux;

        }




    }
}
