﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace pryPonssaIEFI
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        public void Inicializar()
        {
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtPais.Text = null;
            mtxtEdad.Text = null;
            optHombre.Checked = false;
            optMujer.Checked = false;
            txtNombre.Focus();

        }
        private void frmRegistro_Load(object sender, EventArgs e)
        {
            clsManejo objCls = new clsManejo();
            try
            {
                objCls.ConectarBD();
                txtConexion.BackColor = Color.Green;

            }
            catch (Exception exc)
            {
                txtConexion.BackColor = Color.Red;
                MessageBox.Show(exc.Message);
            }
        }
        public void ChequearDatos()
        {
            if (txtNombre.Text != null)
            {
                if (txtApellido.Text != null)
                {
                    if (txtPais.Text != null)
                    {
                        if (mtxtEdad.Text != null)
                        {
                            if (optHombre.Checked = false)
                            {
                                if (optMujer.Checked = false)
                                {
                                    MessageBox.Show("Ingresar todos los datos del miembro");
                                }
                            }
                        }
                    }
                }
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
