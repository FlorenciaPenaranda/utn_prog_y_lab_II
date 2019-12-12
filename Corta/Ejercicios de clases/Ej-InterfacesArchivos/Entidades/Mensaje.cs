using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Mensaje : IMensaje
    {
        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private string texto;

        public string Texto
        {
            get { return texto; }
            set { texto = value; }
        }

        private DateTime hora;

        public DateTime Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public Mensaje()
        {

        }
        public Mensaje(string usuario, string texto, DateTime hora)
        {
            this.usuario = usuario;
            this.texto = texto;
            this.hora = hora;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Usuario : {this.usuario} ");
            sb.AppendLine($"Mensaje : {this.texto} ");
            sb.AppendLine($"Hora : {this.hora} ");
            return sb.ToString();
        }


        public void serializar()
        {
            XmlTextWriter xmlw = new XmlTextWriter(@"y:\Mensajes\" +
                this.Usuario + DateTime.Now.ToString("hhmmssttt") + ".xml",
                Encoding.ASCII);
            XmlSerializer ser = new XmlSerializer(typeof(Mensaje));
            ser.Serialize(xmlw, this);
            xmlw.Close();

        }

        public static List<Mensaje> deserializar()
        {
            List<Mensaje> salida = new List<Mensaje>();

            foreach (string item in Directory.GetFiles(@"y:\Mensajes"))
            {
                XmlTextReader xmlw = new XmlTextReader(item);
                XmlSerializer ser = new XmlSerializer(typeof(Mensaje));
                salida.Add((Mensaje)ser.Deserialize(xmlw));
                xmlw.Close();
            }

            return salida;


        }
    }
}
