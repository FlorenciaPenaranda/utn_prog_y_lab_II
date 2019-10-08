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


namespace VistaForm
{
    public partial class FormDT : Form
    {
        private DirectoTecnico dt;
        public FormDT()
        {
            InitializeComponent();
        }

        private void ButtonCrear_Click(object sender, EventArgs e)
        {
            dt = new DirectoTecnico(textBoxNombre.Text, textBoxApellido.Text, int.Parse(numericUpDownDni.Value.ToString()) , int.Parse(numericUpDownEdad.Value.ToString()), int.Parse(numericUpDownExperiencia.Value.ToString()));
            MessageBox.Show("Se ha creado el DT!", "Creación del DT.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ButtonValidar_Click(object sender, EventArgs e)
        {
            if (dt == null)
            {
                MessageBox.Show("Aún no se ha creado el DT del formulario", "Creación del DT.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }else 
            if (dt.ValidarAptitud() == false)
            {
                MessageBox.Show("“El DT no es apto.", "Creación del DT.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("“El DT es apto.", "Creación del DT.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
    }
}
