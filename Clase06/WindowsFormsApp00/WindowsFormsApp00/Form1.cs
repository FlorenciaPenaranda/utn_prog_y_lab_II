using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp00
{
    public partial class Carga : Form
    {
        public Carga()
        {
            InitializeComponent();
        }

        private void DNI_Click(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(this.textBoxNombre.Text, this.textBoxApellido.Text, this.textBoxDni.Text);


        }

        private void Cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
