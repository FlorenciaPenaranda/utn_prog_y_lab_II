using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows
{
  public class Persona
  {
    private string nombre;
    private string apellido;
    private string dni;
    private string sexo;
    private bool vive;
    private string provincia;

    public Persona()
    {

    }

    public Persona(string nombre, string apellido, string dni, string sexo, bool vive, string provincia)
    {
      this.nombre = nombre;
      this.apellido = apellido;
      this.dni = dni;
      this.sexo = sexo;
      this.vive = vive;
      this.provincia = provincia;

    }

    public string Mostrar()
    {
     return String.Format($"Nombre : {this.nombre} - Apellido : {this.apellido} - DNI : {this.dni} - Sexo : {this.sexo} - Vive {this.vive} - Provincia : {this.provincia}");

    }
  }
}
