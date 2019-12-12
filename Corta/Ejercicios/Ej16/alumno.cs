using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej16
{
    public class Alumno
    {
        //constructor 
        public Alumno(string nombre, string apellido, int legajo)
        {
            if (nombre != "" && apellido != "" && (legajo > 1000 && legajo <9999))
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.legajo = legajo;
                this.nota1 = 0;
                this.nota2 = 0;
                this.notaFinal = 0;

            }
           
        }

        //datos alumno

        private byte nota1;
        private byte nota2;
        private float notaFinal;
        private string apellido;
        private int legajo;
        private string nombre;

        
        //metodos
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void CalcularFinal()
        {
            this.notaFinal = (this.nota1 + this.nota2) / 2;
        }

        public string MostrarAlumno()
        {
            string alumno = "Nombre:";
            alumno += this.nombre + "\n";
            alumno += "Apellido:";
            alumno += this.apellido + "\n";
            alumno += "Legajo: ";
            alumno += this.legajo.ToString() + "\n";
            alumno += "Nota Primer Parcial : ";
            alumno += this.nota1.ToString() + "\n";
            alumno += "Nota segundo parcial : ";
            alumno += this.nota2.ToString() + "\n";
            alumno += "Nota final : ";
            if (this.notaFinal <= 4)
            {
                alumno += this.notaFinal + " alumno desaprobado  \n\n";
            }
            else
            {
                alumno += this.notaFinal.ToString() + "\n\n";
            }
            return alumno;

        }

    }
}
