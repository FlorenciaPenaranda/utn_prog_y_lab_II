using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estanteria<T> where T : Producto
    {
        private int tamaño;

        public int Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }

        private T[] productos;

        public Estanteria(int tamaño)
        {
            this.productos = new T[tamaño];
        }

        public T[] Productos
        {
            get
            {
                return this.productos;
            }

        }

        public static bool operator +(Estanteria<T> e, T p)
        {
            if(e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            
            return false;
        }

        public static bool operator -(Estanteria<T> e, T p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p)
                {
                    e.productos[i] = null;
                    return true;
                }
            }
            return false;
        }


        public static bool operator ==(Estanteria<T> e, T p)
        {
            foreach (T item in e.productos)
            {
                if (!(item is null) && item.IdProducto == p.IdProducto)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Estanteria<T> e, T p)
        {
            return !(e == p);
        }
    }
}
