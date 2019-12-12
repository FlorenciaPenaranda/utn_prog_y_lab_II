using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.IO;
using System.Xml;
using System.Xml.Serialization;



namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private List<Mensaje> mensajes;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (this.tbMensaje.Text != string.Empty && this.tbUsuario.Text != string.Empty) {
                this.mensajes.Add(new Mensaje(this.tbUsuario.Text, this.tbMensaje.Text, DateTime.Now));
                this.reload();
                MessageBox.Show("agregadooo");
                foreach (Mensaje item in this.mensajes)
                {
                    item.serializar();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.mensajes = new List<Mensaje>();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("archivos.log", true);
            sw.WriteLine(DateTime.Now.ToString());
            sw.Close();
            this.reload();
        }

        private void reload()
        {
            
            this.lbTexto.DataSource = null;
            this.lbTexto.DataSource = this.mensajes;
        }

        

    }
}
