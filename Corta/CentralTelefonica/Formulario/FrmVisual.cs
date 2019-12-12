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
    public partial class FrmVisual : Form
    {
        private Centralita central;
        private Llamada.TipoLlamada tipo;
        public FrmVisual(Centralita central, Llamada.TipoLlamada llamada)
        {
            InitializeComponent();
            this.central = central;
            this.tipo = llamada;
            this.CenterToScreen();
        }

        private void RtbMostrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmVisual_Load(object sender, EventArgs e)
        {
            string local = "";
            string prov = "";
            string todas = "";
            foreach (Llamada item in this.central.Llamadas)
            {
                todas += item.ToString();
                if (item is Local) local += item.ToString();
                if (item is Provincial) prov += item.ToString();
            }
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    this.rtbMostrar.Text += local;
                    this.rtbMostrar.Text += "Ganancia total : "+ this.central.GananciasPorLocal.ToString();
                    break;
                case Llamada.TipoLlamada.Provincial:
                    this.rtbMostrar.Text += prov;
                    this.rtbMostrar.Text += "Ganancia total : " + this.central.GananciasPorProvincial.ToString();
                    break;
                case Llamada.TipoLlamada.Todas:
                    this.rtbMostrar.Text += todas;
                    this.rtbMostrar.Text += "Ganancia total : " +  this.central.GananciasPorTotal.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
