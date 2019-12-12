using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


namespace Entidades
{
    public static class AstroExtension
    {
        public static bool GuardarPlanTxt(this Planeta<Satelite> plan)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (!(plan is null))
            {
                bool append = File.Exists(Path.Combine(desktop, "planetas.txt"));
                StreamWriter sw = new StreamWriter(Path.Combine(desktop, "planetas.txt"), append);
                try
                {
                    sw.WriteLine(plan.ToString());
                    return true;
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
            return false;
        }

        public static bool guardarXML(this Satelite sat)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (sat != null)
            {
                bool append = File.Exists(Path.Combine(desktop, "planetas.xml"));
                StreamWriter sw = new StreamWriter(Path.Combine(desktop, "planetas.xml"), append);
                XmlSerializer xs = new XmlSerializer(typeof(Satelite));
                try
                {
                    xs.Serialize(sw, sat);
                    return true;
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
            return false;
        }
    }
}


//  StreamWriter file = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + archivo, true);
//  file.Write(texto);
//  file.Close();
//  return true;


