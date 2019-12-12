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
        static SistemaSolar sistSolar;

        static Form1()
        {
            
            sistSolar = new SistemaSolar();
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
                Planeta p;
                if (cmbPlaneta.SelectedText == "Rocoso")
                {
                     p = new Planeta(Convert.ToInt16(txtTiempoOrbitaPlaneta.Text), (int)numRotacionPlaneta.Value, txtNombrePlaneta.Text, (int)numCantLunasPlaneta.Value, Tipo.Rocoso);
                }
                else
                {
                     p = new Planeta(Convert.ToInt16(txtTiempoOrbitaPlaneta.Text), (int)numRotacionPlaneta.Value, txtNombrePlaneta.Text, (int)numCantLunasPlaneta.Value, Tipo.Gaseoso);
                }
                
                
                sistSolar.Planetas.Add(p);

                if (sistSolar.Planetas.Find(data => data == p) == p)
                {
                    MessageBox.Show("Planeta Agregado", "Atencion", MessageBoxButtons.OK);
                    cmbPlaneta.Items.Clear();
                    foreach (Astro item in sistSolar.Planetas)
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
                Satelite s = new Satelite((int)numTiempoRotacSatelite.Value, (int)numTiempoCompOrbitaSat.Value, txtNombreSatelite.Text);

                foreach (Planeta item in sistSolar.Planetas)
                {
                    if((string)item == this.cmbPlaneta.Text)
                    {
                        item.Satelites.Add(s);
                        MessageBox.Show("Satelite Agregado", "Atencion", MessageBoxButtons.OK);
                    }
                }
               
            }
        }

        private void btnInfo_Click_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Planeta aux;
            //foreach (Astro item in planetas)
            //{
            //    richTextBox1.Text += item.ToString(); 
            //}
            richTextBox1.Text += sistSolar.MostrarInformacion();
            if(this.cmbPlaneta.Text != "")
            {
                aux = sistSolar.Planetas.Find(data => (string)data == this.cmbPlaneta.Text);
                richTextBox1.Text += String.Format($"Satelites del planeta : {(string)aux}");
                foreach (Satelite item in aux.Satelites)
                {
                    richTextBox1.Text += item.ToString();
                }
                    
                
            }
           
        }

        private void btnMoverAstros_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StringBuilder sb = new StringBuilder();
            foreach (Planeta item in sistSolar.Planetas)
            {
                sb.AppendLine(item.Orbitar());
                sb.AppendLine(item.Rotar());
                
                foreach (Satelite satelite in item.Satelites)
                {
                    sb.AppendLine(satelite.Rotar());
                    sb.AppendLine(satelite.Orbitar());
                }
            }
            richTextBox1.Text += sb.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipoPlaneta.DataSource = Enum.GetValues(typeof(Tipo));

        }
    }
}
