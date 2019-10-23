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

namespace FormaSistemaSolar
{
    public partial class FormEstrella : Form
    {
        Estrella estrella;
        public FormEstrella()
        {
            InitializeComponent();
        }

        public Estrella Estrella
        {
            get { return this.estrella; }
        }
        
        private void FormEstrella_Load(object sender, EventArgs e)
        {
            cmbClase.Items.Add(Clase.A);
            cmbClase.Items.Add(Clase.B);
            cmbClase.Items.Add(Clase.G);
            cmbClase.Items.Add(Clase.K);
            cmbClase.Items.Add(Clase.M);
            cmbClase.Items.Add(Clase.O);
        }

        private void btnAgregarEstrella_Click(object sender, EventArgs e)
        {
            if (txtNombreEstrella.Text != String.Empty &&
                txtOrbitaEstrella.Text != String.Empty &&
                numRotacionEstrella.Value > 0 &&
                numPlanetas.Value >= 0 &&
                cmbClase.Text != String.Empty)
            {
                estrella = new Estrella(int.Parse(txtOrbitaEstrella.Text), (int)numRotacionEstrella.Value, txtNombreEstrella.Text, (int)numPlanetas.Value, (Clase)cmbClase.SelectedItem);
                MessageBox.Show("Estrella cargada correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("No se pudo cargar la estrella. Asegurese de completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
