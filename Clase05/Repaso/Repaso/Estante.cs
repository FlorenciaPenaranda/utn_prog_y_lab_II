using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Estante
    {
        Producto[] producto;
        int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.producto = new Producto[capacidad];
        }

        public Estante(int capacidad, int estante) : this(capacidad) // sobrecarga el metodo anterior.
        {
            this.ubicacionEstante = estante;
        }

        public Producto[] GetProducto()
        {
            return this.producto;
        }

        public string MostrarEstante(Estante est)
        {
            StringBuilder concat = new StringBuilder();

            concat.AppendFormat("Ubicacion del estante: {0}", est.ubicacionEstante);

            //for (i= 0; i< est.producto.Length; i++)

            foreach (Producto prod in est.producto)
            {
                concat.AppendLine(Producto.MostrarProducto(prod));
            }

            return concat.ToString();
        }

        public static bool operator ==(Estante estante, Producto producto)
        {
            if (estante != null && !(producto is null))
            {
                foreach (Producto prod in estante.producto)
                {
                    if (prod == producto)
                    {
                        return true;
                    }
                }
            }
                return false;
        }

        public static bool operator !=(Estante est, Producto produc)
        {
            return !(est == produc);
        }

        public static bool operator ++(Estante estante, Producto producto)
        {
            if (estante != producto)
            {
                int i;
                for (i = 0; i < estante.producto.Length; i++)
                {
                    if (estante.producto is null)
                    {
                        estante.producto[i] = producto;
                        return true;
                    }
                    return false;
                }
            }



        }
    }
}
