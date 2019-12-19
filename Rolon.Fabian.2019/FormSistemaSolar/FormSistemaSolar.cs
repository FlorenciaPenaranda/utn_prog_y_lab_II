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
        List<Astro> planetas;
        public FormSistemaSolar()
        {
            InitializeComponent();
            planetas = new List<Astro>();
        }
        /// <summary>
        /// Agrega al planeta a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarPlaneta_Click(object sender, EventArgs e)
        {
            if (txtNombrePlaneta.Text != "" && txtOrbitaPlaneta.Text != "" && numRotacion.Value > 0 && numSatelite.Value >= 0 && cmbTipo.Text != "")
            {
                Planeta planetaUno = new Planeta(int.Parse(txtOrbitaPlaneta.Text), (int)numRotacion.Value, txtNombrePlaneta.Text, (int)numSatelite.Value, (Tipo)cmbTipo.SelectedItem);
                bool flag = true;
                foreach (Planeta planeta in planetas)
                {
                    if (planetaUno == planeta)
                    {
                        MessageBox.Show("El planeta ya se encuentra en la lista", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flag = false;
                        break;
                    }
                    flag = true;     
                }
                if (flag)
                {
                    planetas.Add(planetaUno);
                    MessageBox.Show("Se agrego el planeta con exito", "Agregado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbPlanetas.Items.Add(txtNombrePlaneta.Text);
                }
                    
                txtNombrePlaneta.Text = "";
                txtOrbitaPlaneta.Text = "";
                numRotacion.Value = 0;
                numSatelite.Value = 0;
                cmbTipo.Text = "";
            }
            else
            {
                MessageBox.Show("Complete todos los campos para agregar", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Muestra todos los datos cargados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (Planeta planeta in planetas)
            {
                richTextBox1.AppendText(planeta.ToString());
            }          
        }
        /// <summary>
        /// Carga de datos en el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add(Tipo.Rocoso);
            cmbTipo.Items.Add(Tipo.Gaseoso);
        }
        /// <summary>
        /// Agrega un satelite a un planeta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarSatelite_Click(object sender, EventArgs e)
        {
            if (cmbPlanetas.Text != "") 
            {
                if(txtNombreSatelite.Text != "" && numOrbitaSatelite.Value > 0 && numRotacionSatelite.Value > 0)
                {
                    Satelite satelite = new Satelite((int)numOrbitaSatelite.Value, (int)numRotacionSatelite.Value, txtNombreSatelite.Text);

                    foreach (Planeta planet in planetas)
                    {                    
                        if ((string)planet == cmbPlanetas.Text)
                        {
                            if (planet + satelite)
                            {
                                MessageBox.Show("Se agrego el satelite con exito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("No se puedo agregar el satelite", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    cmbPlanetas.Text = "";
                    txtNombreSatelite.Text = "";
                    numOrbitaSatelite.Value = 0;
                    numRotacionSatelite.Value = 0; 
                }
                else
                {
                    MessageBox.Show("Debe completar todos los datos para agregar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe elegir un planeta, si no lo hay debe cargar uno correctamente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Mueve los astros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMoverAstros_Click(object sender, EventArgs e)
        {
            foreach (Planeta pl in planetas)
            {
                richTextBox1.AppendText(pl.Orbitar());             
                richTextBox1.AppendText(pl.Rotar());
                richTextBox1.AppendText(((Astro)pl).Rotar());
                if (pl.Satelites != null)
                {
                    foreach (Satelite sat in pl.Satelites)
                    {
                        richTextBox1.AppendText(sat.Orbitar());
                        richTextBox1.AppendText(sat.Rotar());
                    }
                }
            }
        }

        private void btnAbrirVnetana_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaNueva ventanaNueva = new VentanaNueva();
            ventanaNueva.Show();
        }
    }
}
