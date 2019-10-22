using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    class Estanteria<T> where T : Producto
    {
        private int tamaño;
        private T[] productos;

        public Estanteria(int tamaño)
        {
            this.tamaño = tamaño;
            this.productos = new T[this.tamaño];
        }

        public static bool operator +(Estanteria<T> e, T p)
        {
            foreach (T item in e.productos)
            {
                if (item.Id == p.Id)
                {
                    return false;
                }

            }
            for (int i = 0; 0 < e.tamaño; i++)
            {
                if (e.productos[i] == null)
                {
                    e.productos[i] = p;
                    return true;
                }
            }

        }

        public static bool operator -(Estanteria<T> e, T p)
        {
            foreach (T item in e.productos)
            {
                if (item.Id != p.Id)
                {
                    return false;
                }

            }
            for (int i = 0; 0 < e.tamaño; i++)
            {
                if (e.productos[i] == p)
                {
                    e.productos[i] = null;
                    return true;
                }
            }

        }

    }
}