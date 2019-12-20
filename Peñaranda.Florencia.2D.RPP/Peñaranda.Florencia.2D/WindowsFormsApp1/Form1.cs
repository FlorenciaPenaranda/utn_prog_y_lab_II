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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Factura factura;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTamanio.DataSource = Enum.GetValues(typeof(ProductoB.Tamaños));
            //factura = new Factura();
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
                //richTextBox1.AppendText(factura.);           
        }

        private void buttonAgregarA_Click(object sender, EventArgs e)
        {
            ProductoA a = new ProductoA(textBoxCodigoA.Text, textBoxDescrpcionA.Text, int.Parse(textBoxPrecioA.Text), dateTimePicker.Value);
        }

        private void buttonAgregarB_Click(object sender, EventArgs e)
        {
            ProductoB a = new ProductoB(textBoxCodigoA.Text, textBoxDescrpcionA.Text, int.Parse(textBoxPrecioA.Text), (ProductoB.Tamaños)cmbTamanio.SelectedItem);
            //falta agregar un messagebox si lo agrego o no 
        }

    }
}
