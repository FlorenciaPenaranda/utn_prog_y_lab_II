﻿using System;
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
        //static List<Astro> planetas;
        static Estrella estrellas;

        static FormSistemaSolar()
        {
            //planetas = new List<Astro>();

        }
        public FormSistemaSolar()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Agrega un planeta a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgregarPlaneta_Click(object sender, EventArgs e)
        {
            if (estrellas == null)
            {
                buttonAgregarPlaneta.Enabled = false;
            }
            else
            {
                if (txtPlanetaNombre.Text != String.Empty &&
                    txtOrbitaPlaneta.Text != String.Empty &&
                    numericUpDownRotacionPlaneta.Value > 0 &&
                    numericUpDownLunas.Value >= 0 &&
                    comboBoxTipoPlaneta.Text != String.Empty)
                {
                    Planeta p = new Planeta(int.Parse(txtOrbitaPlaneta.Text), (int)numericUpDownRotacionPlaneta.Value, txtPlanetaNombre.Text, (int)numericUpDownLunas.Value, (Tipo)comboBoxTipoPlaneta.SelectedItem);
                    //planetas.Add(p);
                    estrellas.Planetas.Add(p);
                    comboBoxPlaneta.Items.Add(txtPlanetaNombre.Text);
                    MessageBox.Show("Planeta cargado correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("No se pudo cargar el planeta. Asegurese de completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtPlanetaNombre.Text = String.Empty;
            txtOrbitaPlaneta.Text = String.Empty;
            numericUpDownRotacionPlaneta.Value = 0;
            numericUpDownLunas.Value = 0;
            comboBoxTipoPlaneta.Text = String.Empty;
        }

        /// <summary>
        /// Agrega un satelite a un planeta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgregarSatelite_Click(object sender, EventArgs e)
        {
            if (estrellas == null)
            {
                buttonAgregarPlaneta.Enabled = false;
            }
            else
            {
                if (comboBoxPlaneta.Text != String.Empty &&
                   txtSateliteNombre.Text != String.Empty &&
                   numericUpDownOrbitaSatelite.Value > 0 &&
                   numericUpDownRotacionSatelite.Value > 0)
                {
                    Satelite s = new Satelite((int)numericUpDownOrbitaSatelite.Value, (int)numericUpDownRotacionSatelite.Value, txtSateliteNombre.Text);
                    foreach (Planeta item in estrellas.Planetas)
                    {
                        if (comboBoxPlaneta.SelectedItem.ToString() == (string)item)
                        {
                            item.Satelites.Add(s);
                            MessageBox.Show("Satelite cargado correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo cargar el Satelite. Asegurese de completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            comboBoxPlaneta.Text = String.Empty;
            txtSateliteNombre.Text = String.Empty;
            numericUpDownOrbitaSatelite.Value = 0;
            numericUpDownRotacionSatelite.Value = 0;
        }

        /// <summary>
        /// Muestra todos los datos cargados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMostrarInfo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (Astro item in estrellas.Planetas)
            {
                richTextBox1.AppendText(item.ToString());
            }
        }

        /// <summary>
        /// Mueve los astros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMoverAstros_Click(object sender, EventArgs e)
        {
            foreach (Planeta p in estrellas.Planetas)
            {
                if (p is Planeta)
                {
                    richTextBox1.Text = String.Format(p.Rotar());
                }

                foreach (Satelite s in p.Satelites)
                {
                    if (s is Satelite)
                    {
                        richTextBox1.Text = String.Format(s.Orbitar() + s.Rotar());
                    }
                }
            }

        }

        /// <summary>
        /// Carga los enum de Tipo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSistemaSolar_Load(object sender, EventArgs e)
        {
            comboBoxTipoPlaneta.Items.Add(Tipo.Gaseoso);
            comboBoxTipoPlaneta.Items.Add(Tipo.Rocoso);
        }

        /// <summary>
        /// Agrega un nuevo formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEstrella ss = new FormEstrella();
            ss.ShowDialog();
        }
    }
}

