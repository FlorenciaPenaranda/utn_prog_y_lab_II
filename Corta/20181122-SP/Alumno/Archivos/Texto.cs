using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (!string.IsNullOrEmpty(archivo) && !(datos is null))
            {
                bool append = File.Exists(Path.Combine(desktop, archivo));
                StreamWriter sw = new StreamWriter(Path.Combine(desktop, archivo), append);
                try
                {
                    foreach (Patente item in datos)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message, e);
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
            string[] aux;
            string data = "";
            if (!string.IsNullOrEmpty(archivo))
            {
                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                StreamReader sw = new StreamReader(Path.Combine(desktop, archivo));
                try
                {
                    while (!sw.EndOfStream)
                    {
                        data = sw.ReadToEnd();
                    }
                }
                catch (PatenteInvalidaException ex)
                {
                    throw new PatenteInvalidaException(ex.Message, ex);
                }
                catch (Exception ext)
                {
                    throw new Exception(ext.Message, ext);
                }
                finally
                {
                    sw.Close();
                }



            }

            aux = data.Split('\n');

            foreach (string item in aux)
            {
                try
                {
                    Patente p = item.ValidarPatente();
                    if(!(p.CodigoPatente is null)) datos.Enqueue(p);

                }
                catch (Exception)
                {

                }

            }


        }
    }
}
