using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using Entidades;

namespace Patentes
{
    delegate void FinExposicionPatente(VistaPatente vp);
    delegate void MostrarPatente(object patente);

    public partial class VistaPatente : UserControl
    { 
        
        public VistaPatente()
        {
            InitializeComponent();

            picPatente.Image = fondosPatente.Images[(int)Patente.Tipo.Mercosur];
        }

        public void MostrarPatente(object patente)
        {
            if (lblPatenteNro.InvokeRequired)
            {
                try
                {
                    Random r = new Random();


                    this.lblPatenteNro.Text = (string)patente;

                    Thread.Sleep(r.Next(2000, 5000));

                    // Agregar evento de que finalizó la exposición de la patente
                    // ALUMNO
                }
                catch (Exception) { }
            }
            else
            {
                picPatente.Image = fondosPatente.Images[(int)((Patente)patente).TipoCodigo];
                lblPatenteNro.Text = patente.ToString();
            }
        }
    }
}
