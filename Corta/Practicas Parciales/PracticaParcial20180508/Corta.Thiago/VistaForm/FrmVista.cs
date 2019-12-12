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
    public partial class FrmVista : Form
    {
        private Curso c;
        private Profesor profe;
        
        public FrmVista()
        {
            InitializeComponent();
        }

        private void BtnAgregarAlumno_Click(object sender, EventArgs e)
        {
            if(!(c is null))
            {
                Divisiones division;
                Enum.TryParse<Divisiones>(cbDivisionAlumno.SelectedValue.ToString(), out division);
                Alumno a = new Alumno(tbNombreAlumno.Text, tbApellidoAlumno.Text, tbDniAlumno.Text,Convert.ToInt32(tbLegajoAlumno.Text),(short)nUpDAnioAlumno.Value, division);
                if(!(a is null))
                {
                    c += a;
                    rtbDatos.Text = ((string)c);
                    MessageBox.Show("Se creo bien el alumno", "TodoOk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se creo mal el alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                MessageBox.Show("Primero crear curso antes de agregar alumnos !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCrearCurso_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cbDivCurso.SelectedValue.ToString(), out division);
            profe = new Profesor(tbNombreCurso.Text, tbApellidoCurso.Text, tbDniCurso.Text,dateTimePicker1.Value);
            if(!(profe is null))
            {
                MessageBox.Show("Se creo bien el profe", "TodoOk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                c = new Curso((short)Convert.ToInt32(nUpDCurso.Value), division, profe);
                if(!(c is null))
                {
                    MessageBox.Show("Se creo bien el curso", "TodoOk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("se creo mal el curso !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("se creo mal el profe !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnMostrarCurso_Click(object sender, EventArgs e)
        {
            rtbDatos.Text = null;
            rtbDatos.Text = ((string)c);
        }

        private void FrmVista_Load(object sender, EventArgs e)
        {
            cbDivCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            cbDivisionAlumno.DataSource = Enum.GetValues(typeof(Divisiones));
            
        }
    }
}
