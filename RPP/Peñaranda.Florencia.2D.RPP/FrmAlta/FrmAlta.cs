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

namespace FrmAlta
{
    public partial class FrmAlta : Form
    {
        public static FrmAlta frmAlta_Instancia;
        Estacionamiento estacionamiento;

        public FrmAlta(Estacionamiento e)
        {
            InitializeComponent();
            estacionamiento = e;
        }

        public static FrmAlta CrearInstancia(Estacionamiento e)
        {
            if (frmAlta_Instancia is null)
            {
                frmAlta_Instancia = new FrmAlta(e);
            }
            return frmAlta_Instancia;
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            comboBoxColor.DataSource = Enum.GetValues(typeof(Vehiculo.eColores));
            comboBoxTransmision.DataSource = Enum.GetValues(typeof(Auto.eTransmision));
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            Auto a = null;
            Moto m = null;
            if (radioButtonAuto.Checked is true)
            {
                //int.TryParse(textBoxDni.Text, out int dni);
                a  = new Auto(textBoxPatente.Text, textBoxNombre.Text, int.Parse(textBoxDni.Text), comboBoxTransmision.SelectedItem.ToString(), comboBoxColor.SelectedItem.ToString());
            }
            if (radioButtonMoto.Checked is true)
            {
                //int.TryParse(textBoxDni.Text, out int dni);
                //int.TryParse(textBoxCilindrada.Text, out int cilin);
                m = new Moto(textBoxPatente.Text, textBoxNombre.Text, int.Parse(textBoxDni.Text), int.Parse(textBoxCilindrada.Text), comboBoxColor.SelectedItem.ToString());
            }
            if (estacionamiento + a || estacionamiento + m)
            {
                MessageBox.Show("Vehículo fue agregado satisfactoriamente");
            }
            else
            {
                MessageBox.Show("El vehículo no pudo ser agregado. Reintente");
            }
            frmAlta_Instancia = null;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            frmAlta_Instancia = null;
            this.Close();
        }

        private void FrmAlta_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAlta_Instancia = null;
        }

        private void RadioButtonAuto_CheckedChanged(object sender, EventArgs e)
        {
            labelCilindrada.Visible = false;
            textBoxCilindrada.Visible = false;
            labelTransmision.Visible = true;
            comboBoxTransmision.Visible = true;
        }

        private void RadioButtonMoto_CheckedChanged(object sender, EventArgs e)
        {
            labelCilindrada.Visible = true;
            textBoxCilindrada.Visible = true;
            labelTransmision.Visible = false;
            comboBoxTransmision.Visible = false;
        }
    }
}