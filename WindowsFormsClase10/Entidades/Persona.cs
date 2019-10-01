using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona// clase abtracta se declara Pensona p; no se instancia(NO new)
    {
        public double cuil;
        public string Nombre { get; set; }
        
        public double Cuil
        {
            get { return this.cuil; }
            set {
                    if (validarCuil(value) == true)
                    {
                    this.cuil = value;
                    }
                    else
                    {
                    throw new Exception("Cuil invalido."); 
                    }
                }
        }

        public Persona (string nombre, double cuil)
        {
            this.Nombre = nombre;
            this.cuil = cuil;
        }

        public abstract string Mostrar(); 

        public string Mostrar2()
        {
            return this.Nombre + this.cuil;
        }

        public bool validarCuil(double cuil)
        {
            char[] ponderador = { '5', '4', '3', '2', '7', '6', '5', '4', '3', '2' };
            int i;
            double suma = 0;
            char[] numero = cuil.ToString("00000000000").ToCharArray();
            for (i = 0; i < 10; i++)
            {
                suma += (int.Parse(ponderador[i].ToString()) * int.Parse(numero[i].ToString()));
            }

            suma = suma % 11;
            suma = 11 - suma;

            suma = suma == 10 ? 0 : suma == 11 ? 1 : suma;

            return suma == int.Parse(numero[10].ToString());
        }

    }
}


