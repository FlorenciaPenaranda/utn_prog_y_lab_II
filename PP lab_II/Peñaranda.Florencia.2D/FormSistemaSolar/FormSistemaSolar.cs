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

namespace FormSistemaSolar
{
    public partial class FormSistemaSolar : Form
    {
        private static List<Astro> planetas;

        static FormSistemaSolar()
        {
            planetas = new List<Astro>();
        }
        public FormSistemaSolar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombrePlaneta.Text != String.Empty &&
                txtOrbitaPlaneta.Text != String.Empty &&
                numRotacionPlaneta.Value >= 0 &&
                numLunas.Value >= 0 &&
                cmbTipo.Text != String.Empty)
            {
                Planeta p = new Planeta(int.Parse(txtOrbitaPlaneta.Text), (int)numRotacionPlaneta.Value, txtNombrePlaneta.Text, (int)numLunas.Value, (Tipo)cmbTipo.SelectedItem);
                
                planetas.Add(p);
                cmbPlaneta.Items.Add(txtNombrePlaneta.Text);
                MessageBox.Show("Planeta cargado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se puedo carga el Planeta. Asegurese de completar todo los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtNombrePlaneta.Text = String.Empty;
            txtOrbitaPlaneta.Text = String.Empty;
            numRotacionPlaneta.Value = 0;
            numLunas.Value = 0;
            cmbTipo.Text = String.Empty;
        }

        private void btnAgregarSatelite_Click(object sender, EventArgs e)
        {
            if (cmbPlaneta.Text != String.Empty &&
                txtNombreSatelite.Text != String.Empty &&
                numOrbitaSatelite.Value > 0 &&
                numRotacionSatelite.Value > 0)
            {
                Satelite s = new Satelite((int)numOrbitaSatelite.Value, (int)numRotacionSatelite.Value, txtNombreSatelite.Text);
                foreach (Planeta item in planetas)
                {
                    if (cmbPlaneta.SelectedItem.ToString() == (String)item)
                    {
                        item.Satelites.Add(s);
                        MessageBox.Show("Satelite cargado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puedo carga el Satelite. Asegurese de completar todo los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cmbPlaneta.Text = String.Empty;
            txtNombreSatelite.Text = String.Empty;
            numOrbitaSatelite.Value = 0;
            numRotacionSatelite.Value = 0;
        }

        private void btnMostrarInfo_Click(object sender, EventArgs e)
        {
            foreach (Astro item in planetas)
            {
                richTextBox.AppendText(item.ToString());
            }

        }

        private void btnMoverAstros_Click(object sender, EventArgs e)
        {
            richTextBox.Text = String.Empty;
            foreach (Planeta p in planetas)
            {
                if (p is Planeta)
                {
                    richTextBox.Text = String.Format(p.Rotar() + p.Orbitar());
                }
                foreach (Satelite s in p.Satelites)
                {
                    if (s is Satelite)
                    {
                        richTextBox.Text = String.Format(s.Orbitar() + s.Orbitar());
                    }
                }
            }
        }

        private void FormSistemaSolar_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add(Tipo.Gaseoso);
            cmbTipo.Items.Add(Tipo.Rocoso);
        }
    }
}
