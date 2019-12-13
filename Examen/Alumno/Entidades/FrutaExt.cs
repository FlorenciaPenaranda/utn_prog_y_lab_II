using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    public static class FrutaExt 
    {
        public static String MostrarElemento(this Fruta fruta)//o canasta y que el tipo sea fruta ?
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (!(fruta is null))
            {
                bool append = File.Exists(Path.Combine(desktop, "datos.txt"));
                StreamWriter sw = new StreamWriter(Path.Combine(desktop, "datos.txt"), append);
                try
                {
                    sw.WriteLine(fruta.ToString());
                    return fruta.MostrarDatos();
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
            return fruta.MostrarDatos();
        }

        public static string guardarXML(this Fruta fruta)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (fruta != null)
            {
                bool append = File.Exists(Path.Combine(desktop, "datos.xml"));
                StreamWriter sw = new StreamWriter(Path.Combine(desktop, "datos.xml"), append);
                XmlSerializer xs = new XmlSerializer(typeof(Fruta));
                try
                {
                    xs.Serialize(sw, fruta);
                    return fruta.MostrarDatos();
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
            return fruta.MostrarDatos();
        }
    }
}
