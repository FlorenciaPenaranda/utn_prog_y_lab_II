using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej16
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            int legajo;
            string seguir = "si";

            List<Alumno> alumnos = new List<Alumno>();

            do
            {
                Console.WriteLine("Ingresar nombre del alumno");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingresar apellido del alumno");
                apellido = Console.ReadLine();

                Console.WriteLine("Ingresar legajo del alumno");
                while(!int.TryParse(Console.ReadLine(), out legajo))
                {
                    Console.WriteLine("Error ingresar legajo SOLO NUMEROS");
                    int.TryParse(Console.ReadLine(), out legajo);

                }

                alumnos.Add(new Alumno(nombre, apellido, legajo));
                Console.WriteLine("quiere ingresar otro alumno ? si para seguir no para frenar el programa");
                seguir = Console.ReadLine();

            } while (seguir == "si");

            foreach (Alumno alumno in alumnos)
            {
                alumno.Estudiar((byte)10, (byte)10);
                //alumno.Estudiar((byte)4, (byte)4);
                //alumno.Estudiar((byte)1, (byte)1);
                alumno.CalcularFinal();
                Console.WriteLine(alumno.MostrarAlumno()) ;

            }
            Console.ReadKey();



        }
    }
}
