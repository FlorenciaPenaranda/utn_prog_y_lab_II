using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        public bool Guardar(string archivo, string datos)
        {
            datos = string.Empty;

            if (string.IsNullOrWhiteSpace(archivo))
            {
                return false;
            }
            try
            {
                using (StreamWriter file = new StreamWriter(archivo))
                {
                    file.WriteLine(datos);
                    file.Close();
                }
            }
            catch (Exception)
            {
                throw;

            }
            return true;
        }
        
        public bool Leer(string archivo, out string datos)
        {
            datos = string.Empty;

            if (string.IsNullOrWhiteSpace(archivo))
            {
                return false;
            }

            try
            {
                using (StreamReader file = new StreamReader(archivo))
                {
                    datos = file.ReadToEnd();
                    file.Close();
                }
            }
            catch (Exception)
            {
                throw;

            }

            return true;
        }
    }
}
