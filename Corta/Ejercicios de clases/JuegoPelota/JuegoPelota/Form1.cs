using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace JuegoPelota
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPelota_Click(object sender, EventArgs e)
        {
            Mapa mapita = new Mapa();
            Random rnd = new Random();
            this.Controls.Add(mapita);
            mapita.setBackgroundImg(Properties.Resources.pelota);
            Thread t1 = new Thread(mapita.MoverImagen);
            mapita.Hilo = t1;

            mapita.Top = rnd.Next(0, this.Height);

            t1.Start(this.Width);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.mapa;
            
            
        }
    }
}
