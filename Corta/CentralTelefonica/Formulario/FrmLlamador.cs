using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace Formulario
{
    public partial class FrmLlamador : Form
    {
        private Centralita centralita;
        public FrmLlamador(Centralita central)
        {
            InitializeComponent();
            this.centralita = central;
            this.cbFranja.Enabled = false;
            this.CenterToScreen();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Write('1');
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Write('2');
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Write('3');
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Write('4');
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Write('5');
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Write('6');
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Write('7');
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Write('8');
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Write('9');
        }

        private void ButtonNumeral_Click(object sender, EventArgs e)
        {
            this.Write('*');
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            this.Write('0');
        }

        private void ButtonHashtag_Click(object sender, EventArgs e)
        {
            this.Write('#');
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }

        private void Limpiar()
        {
            this.tbDestino.Text = "Nro Destino";
            this.tbOrigen.Text = "Nro Origen";
            this.cbFranja.Enabled = false;
        }
        private bool Write(char str)
        {
            if (this.tbDestino.Text == "Nro Destino")
            {
                this.tbDestino.Text = "";
                if (str == '#')
                {
                    this.cbFranja.Enabled = true;
                    this.tbDestino.Text += str;
                    return true;
                }
                else
                {
                    this.cbFranja.Enabled = false;
                    this.tbDestino.Text += str;
                    return false;
                }
            }
            this.tbDestino.Text += str;
            return false;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLlamar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (this.cbFranja.Enabled == false && this.tbDestino.Text.Length == 8 && this.tbOrigen.Text.Length == 8)
            {

                Llamada llamadaLocal = new Local(this.tbOrigen.Text, rnd.Next(1, 50), this.tbDestino.Text, rnd.Next(0, 5));
                this.centralita += llamadaLocal;
                if (this.centralita == llamadaLocal)
                {
                    MessageBox.Show ("Llamada Local agregada!","Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show( "Llamada local No se pudo agregar!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (this.cbFranja.Enabled == true && this.tbDestino.Text.Length == 8 && this.tbOrigen.Text.Length == 8)
            {
                Provincial.Franja franjas;
                Enum.TryParse<Provincial.Franja>(cbFranja.SelectedValue.ToString(), out franjas);
                Llamada llamadaProv = new Provincial(this.tbOrigen.Text, franjas, rnd.Next(1, 50), this.tbDestino.Text);
                this.centralita += llamadaProv;

                if (this.centralita == llamadaProv)
                {
                    MessageBox.Show("Llamada Provincial agregada!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show( "Llamada Provincial No se pudo agregar!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
