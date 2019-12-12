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

namespace JuegoPelota
{
    public partial class Mapa : UserControl
    {
        private Thread hilo;
        private int pos = 5;
        public Mapa()
        {
            InitializeComponent();
        }

        public Thread Hilo { set
            {
                this.hilo = value;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.hilo.Abort();
            this.Hide();
        }

        public void setBackgroundImg(Bitmap img)
        {
            this.pictureBox1.BackgroundImage = img;
            this.BackColor = Color.White;
        }

        public void MoverImagen(object width)
        {
            Random rnd = new Random();
            while (true)
            {
                if (this.Left >= (int)width) {
                    this.pos *= -1;
                }

                if(this.Right <= 0)
                {
                    this.pos *= -1;
                }

                Thread.Sleep(50);
                if (this.InvokeRequired) {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        
                        this.Left += pos;
                    });
                }
                else
                {
                    
                    this.Left += pos;
                }
                
            }
            this.hilo.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
