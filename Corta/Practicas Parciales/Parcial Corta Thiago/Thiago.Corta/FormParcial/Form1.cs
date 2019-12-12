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
namespace FormParcial
{
    public partial class Form1 : Form
    {
        static List<Astro> planetas;

        static Form1()
        {
            planetas = new List<Astro>();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarPlaneta_Click(object sender, EventArgs e)
        {
            if (txtNombrePlaneta.Text != String.Empty && txtTiempoOrbitaPlaneta.Text != String.Empty &&
                numCantLunasPlaneta.Value >= 0 && numRotacionPlaneta.Value >=0)
            {
                Astro p;
                if (cmbPlaneta.SelectedText == "Rocoso")
                {
                     p = new Planeta(Convert.ToInt16(txtTiempoOrbitaPlaneta.Text), (int)numRotacionPlaneta.Value, txtNombrePlaneta.Text, (int)numCantLunasPlaneta.Value, Tipo.Rocoso);
                }
                else
                {
                     p = new Planeta(Convert.ToInt16(txtTiempoOrbitaPlaneta.Text), (int)numRotacionPlaneta.Value, txtNombrePlaneta.Text, (int)numCantLunasPlaneta.Value, Tipo.Gaseoso);
                }
                
                planetas.Add(p);
                if (planetas.Contains(p))
                {
                    MessageBox.Show("Planeta Agregado", "Atencion", MessageBoxButtons.OK);
                    cmbPlaneta.Items.Clear();
                    foreach (Astro item in planetas)
                    {
                        if(item is Planeta)
                        {
                            cmbPlaneta.Items.Add((string)item);
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Error al agregar un planeta", "Atencion", MessageBoxButtons.OK);
                }
            }

        }

        private void btnAgregarSatelite_Click(object sender, EventArgs e)
        {
            if (txtNombreSatelite.Text != String.Empty && numTiempoCompOrbitaSat.Value >= 0&&
                  numTiempoRotacSatelite.Value >= 0)
            {
                Astro s = new Satelite((int)numTiempoRotacSatelite.Value, (int)numTiempoCompOrbitaSat.Value, txtNombreSatelite.Text);
                planetas.Add(s);
                if (planetas.Contains(s))
                {
                    MessageBox.Show("Satelite Agregado", "Atencion", MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show("Error al agregar un Satelite", "Atencion", MessageBoxButtons.OK);
                }
            }
        }

        private void btnInfo_Click_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            foreach (Astro item in planetas)
            {
                richTextBox1.Text += item.ToString(); 
            }
        }

        private void btnMoverAstros_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            foreach (Astro item in planetas)
            {
                if(item is Satelite)
                {
                    richTextBox1.Text += String.Format(item.Orbitar() + "\n");
                }
              
                if(item is Planeta)
                {
                    
                    richTextBox1.Text += String.Format(item.Orbitar() + item.Rotar() + "\n"); 
                }
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipoPlaneta.DataSource = Enum.GetValues(typeof(Tipo));

        }
    }
}
