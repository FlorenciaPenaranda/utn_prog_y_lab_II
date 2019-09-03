using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase04
{
    class Empleado
    {
        string nombre;
        string apellido;
        double sueldoBruto;
        double sueldoNeto;
        double jubilacion;
        double ley19032;
        double obraSocial;
        double sindicato;

        public Empleado(string nombre, string apellido, double sueldoBruto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldoBruto = sueldoBruto;
        }

        public Empleado(string nombre, string apellido, double sueldoBruto, double sueldoNeto, double jubilacion, double ley19032, double obraSocial)
            : this(nombre, apellido, sueldoBruto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldoBruto = sueldoBruto;
            this.sueldoNeto = sueldoNeto;
            this.jubilacion = jubilacion;
            this.ley19032 = ley19032;
            this.obraSocial = obraSocial;
        }

        public void CalcularNeto()
        {
            this.jubilacion = this.sueldoBruto * 0.11;
            this.obraSocial = this.sueldoBruto * 0.3;
            this.ley19032 = this.sueldoBruto * 0.3;
            this.sueldoNeto = (this.sueldoBruto - this.jubilacion - this.obraSocial - this.ley19032);
        }

        public void Mostrar()
        {
            Console.WriteLine("Nombre: {0}\n apellido: {1}\n Sueldo Bruto: {2}\n Sueldo Neto: {3}\n Jubilacion: {4}\n Ley19032: {5}\n Obra Social: {6}\n", nombre, apellido, sueldoBruto, sueldoNeto, jubilacion, ley19032, obraSocial);
            Console.ReadKey();
        }

        public void CalcularNeto(bool sindicato)
        {
            if (sindicato)
            {
                this.sindicato = this.sueldoBruto - 0.20;
                this.sueldoNeto -= this.sindicato;
            }
        }

        public void Aumentar(float sueldoBruto)
        {
            this.sueldoBruto = sueldoBruto;
            this.CalcularNeto();
        }

        public void Aumentar(int porcentaje)
        {
            this.sueldoBruto += this.sueldoBruto * porcentaje * 0.01;
            this.CalcularNeto();
        }

    }
}
