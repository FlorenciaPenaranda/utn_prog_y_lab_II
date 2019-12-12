using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string archivo, T datos)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (!string.IsNullOrEmpty(archivo) && datos != null)
            {
                bool append = File.Exists(Path.Combine(desktop, archivo));

                XmlSerializer xs = new XmlSerializer(typeof(T));
                try
                {
                    StreamWriter sw = new StreamWriter(Path.Combine(desktop, archivo), append);
                    xs.Serialize(sw, datos);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message, e);
                }


            }
        }

        public void Leer(string archivo, out T datos)
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader(archivo))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    datos = (T)ser.Deserialize(reader);
                }
                
            }
            catch (Exception e)
            {
                throw new Exception("Error al leer archivo XML", e);
            }

        }
    }
}
