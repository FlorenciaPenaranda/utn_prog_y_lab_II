using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Canasta<T> where T : ReinoVegetal
    {
        private List<T> plantas;
        private short capacidad;

        private Canasta()
        {
            plantas = new List<T>();
        }

        public Canasta(short capacidad) 
            : this()
        {
            this.capacidad = capacidad;
        }

        /* Lógica operador +
            if (reinoVegetal is ...)
            {
                if (c.plantas.Count < c.capacidad)
                {
                    ... aux = (...)Convert.ChangeType(reinoVegetal, typeof(T));
                    c.plantas.Add(aux);

                    return c;
                }
                else
                {
                    // Lanzar excepción con el mensaje "Capacidad excedida."
                }
            }
            else
            {
                // Lanzar excepción con el mensaje "El elemento es del tipo {0}. Se esperaba {1}."
            }
        */

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Capacidad: " + this.capacidad);
            foreach (ReinoVegetal reinoVegetal in this.plantas)
            {
                sb.AppendLine(reinoVegetal.MostrarDatos());
            }
            return sb.ToString();
        }

        public static Canasta<T> operator +(Canasta<T> c,ReinoVegetal reinoVegetal)
        {
            if (reinoVegetal is T)//ReinoVegetal
            {
                if (c.plantas.Count < c.capacidad)
                {
                    T aux = (T)Convert.ChangeType(reinoVegetal, typeof(T));
                    c.plantas.Add(aux);

                    return c;
                }
                else
                {
                    // Lanzar excepción con el mensaje "Capacidad excedida."
                    throw new NoAgregaException("Capacidad excedida.");
                }
            }
            else
            {
                // Lanzar excepción con el mensaje "El elemento es del tipo {0}. Se esperaba {1}."
                string st = string.Format("El elemento es del tipo {0}. Se esperaba {1}.", reinoVegetal.GetType().Name, typeof(T).Name);
                throw new NoAgregaException(st);
            }
        }
    }
}
