﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmAdminEmpleados : Form
    {

        public Persona persona;
        public FrmAdminEmpleados()
        {
            InitializeComponent();            
        }

        private void FrmAdminEmpleados_Load(object sender, EventArgs e)
        {

            this.cmbTipoEmpleado.DataSource = Enum.GetValues(typeof(ETipoEmpleado));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                switch ((ETipoEmpleado)this.cmbTipoEmpleado.SelectedItem)
                {
                    case ETipoEmpleado.Empleado:
                        this.persona = new Empleado(this.txtNombre.Text, int.Parse(this.txtCuil.Text), float.Parse(this.txtSueldo.Text));
                        break;
                    case ETipoEmpleado.Jefe:
                        this.persona = new Jefe(this.txtNombre.Text, double.Parse(this.txtCuil.Text), float.Parse(this.txtSueldo.Text), int.Parse(this.txtBono.Text));
                        break;
                    case ETipoEmpleado.Vendedor:
                        this.persona = new Vendedor(this.txtNombre.Text, double.Parse(this.txtCuil.Text), float.Parse(this.txtSueldo.Text), int.Parse(this.txtObjetivo.Text));
                        break;
                }                
                this.DialogResult = DialogResult.OK;
            }            
            catch (FormatException ex)
            {
                MessageBox.Show("Los campos numericos no deben tener letras");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("El valor ingresado es demasiado grande");
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                this.limpiar();
            }
            
            
            

        }

        private void cmbTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblBono.Visible = ((ETipoEmpleado)this.cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Jefe;
            this.txtBono.Visible = ((ETipoEmpleado)this.cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Jefe;
            this.lblObjetivo.Visible = ((ETipoEmpleado)this.cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Vendedor;
            this.txtObjetivo.Visible = ((ETipoEmpleado)this.cmbTipoEmpleado.SelectedItem) == ETipoEmpleado.Vendedor;
        }
        private void limpiar()
        {
            this.limpiarControles(this.Controls);
        }

        private void limpiarControles(System.Windows.Forms.Control.ControlCollection c)
        {
            foreach (Control item in c)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = "";
                if (item is Panel)
                    this.limpiarControles(((Panel)item).Controls);

            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

         //   MessageBox.Show(this.persona.Mostrar());                
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
//            FrmAumentos frmAumentos = new FrmAumentos();
  //          frmAumentos.Show();
        }
    }
}
