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
    public partial class FormSistemaSolar : Form
    {
        static List<Astro> planetas;

        static FormSistemaSolar()
        {
            planetas = new List<Astro>();
        }
        public FormSistemaSolar()
        {
            InitializeComponent();

        }

        private void buttonAgregarPlaneta_Click(object sender, EventArgs e)
        {
            if (txtPlanetaNombre.Text != String.Empty &&
                txtOrbitaPlaneta.Text != String.Empty &&
                numericUpDownRotacionPlaneta.Value < 0 &&
                numericUpDownLunas.Value < 0 &&
                comboBoxTipoPlaneta.Text != String.Empty)
            {
                Planeta p = new Planeta(int.Parse(txtOrbitaPlaneta.Text), (int)numericUpDownRotacionPlaneta.Value, txtPlanetaNombre.Text, (int)numericUpDownLunas.Value, (Tipo)comboBoxTipoPlaneta.SelectedItem);
                planetas.Add(p);
                comboBoxPlaneta.Items.Add(txtPlanetaNombre.Text);
            }
            else
            {
                MessageBox.Show("No se pudo cargar el planeta. Asegurese de completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAgregarSatelite_Click(object sender, EventArgs e)
        {
            if (comboBoxPlaneta.Text == String.Empty &&
               txtSateliteNombre.Text == String.Empty &&
               numericUpDownOrbitaSatelite.Value < 0 &&
               numericUpDownRotacionSatelite.Value < 0)
            {
                Satelite s = new Satelite((int)numericUpDownOrbitaSatelite.Value, (int)numericUpDownRotacionSatelite.Value, lblSateliteNombre.Text);
            }
            else
            {
                MessageBox.Show("No se pudo cargar el Satelite. Asegurese de completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMostrarInfo_Click(object sender, EventArgs e)
        {
            foreach (Astro item in planetas)
            {
                richTextBox1.AppendText(item.ToString());
            }
        }

        private void buttonMoverAstros_Click(object sender, EventArgs e)
        {
            foreach (Planeta item in planetas)
            {
                if (item is Planeta)
                {
                    richTextBox1.Text = String.Format(item.Rotar());
                }
                else
                {
                    richTextBox1.Text = String.Format(item.Orbitar() + item.Rotar());
                }

            }

        }
    }
}

