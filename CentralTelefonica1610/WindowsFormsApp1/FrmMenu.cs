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
  public partial class FrmMenu : Form
  {
    Centralita centralita;

    public FrmMenu()
    {
      InitializeComponent();
      centralita = new Centralita();
    }


  }
}
