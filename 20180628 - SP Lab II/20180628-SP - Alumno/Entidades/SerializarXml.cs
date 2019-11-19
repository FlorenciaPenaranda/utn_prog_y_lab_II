using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Entidades
{
    public class SerializarXml<T> : IArchivo<T>
    {
        public T Leer(string archivo)
        {
            try
            {
                XmlTextReader reader = new XmlTextReader(archivo);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                T datos = (T)ser.Deserialize(reader);
                reader.Close();
                return datos;
            }
            catch (Exception innerException)
            {
                throw new ErrorArchivoException(innerException);
            }
        }

        public bool Guardar(string archivo, T datos)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, datos);
                writer.Close();
                return true;
            }
            catch (Exception innerException)
            {
                throw new ErrorArchivoException(innerException);
            }
        }

    }
}
