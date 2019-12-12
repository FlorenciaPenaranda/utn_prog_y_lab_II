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
    public delegate void MostrarPatente(object patente);
    public delegate void FinExposicionPatente(VistaPatente vp);

    public partial class VistaPatente : UserControl
    {
        public event FinExposicionPatente finExposicion;
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
                    if (this.InvokeRequired)
                    {
                        MostrarPatente d = new MostrarPatente(this.MostrarPatente);
                        this.Invoke(d, new object[] { patente });
                    }
                    else
                    {
                       
                            this.lblPatenteNro.Text = patente.ToString(); ;
                        
                    }
                    Thread.Sleep(r.Next(2000, 5000));
                    //this.finExposicion.Invoke(this);
                }
                catch (Exception ex) {
                    throw new Exception(ex.Message, ex);
                }
            }
            else
            {
                picPatente.Image = fondosPatente.Images[(int)((Patente)patente).TipoCodigo];
                lblPatenteNro.Text = patente.ToString();
            }
        }
    }
}
