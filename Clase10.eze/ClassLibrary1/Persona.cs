﻿using System;

namespace Entidades
{
    public abstract class Persona
    {
        private double cuil;
        public double Cuil { get {
                return this.cuil;
            } set {
                if (validarCuil(value))
                {
                    this.cuil = value;
                }
                else                   
                    throw new Exception("El cuil es invalido");
            }
        }
        public string Nombre { get; set; }
        public Persona(string nombre, double cuil)
        {
            this.Cuil = cuil;
            this.Nombre = nombre;
        }

        public virtual string Mostrar()
        {
            return "nom:"+  this.Nombre + " cuil:" + this.Cuil;
        }

        public bool validarCuil(double cuil)
        {
            char[] ponderador = { '5', '4', '3' , '2', '7', '6', '5', '4', '3', '2' };
            int i;
            double suma=0;
            char[] numero = cuil.ToString("00000000000").ToCharArray();
            for(i=0;i<10;i++)
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
