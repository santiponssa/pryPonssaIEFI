using System;
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
        public bool ChequearDatos()
        {
            bool resultado;
            resultado = false;
            if (txtNombre.Text != null)
            {
                if (txtApellido.Text != null)
                {
                    if (txtPais.Text != null)
                    {
                        if (mtxtEdad.Text != null)
                        {
                            if (optHombre.Checked == false)
                            {
                                if (optMujer.Checked == false)
                                {
                                    resultado = true;
                                }
                            }
                        }
                    }
                }
            }
            if (resultado == true)
            {
                MessageBox.Show("Ingresar todos los datos del miembro");
            }
            else
            {
                MessageBox.Show("Datos guardados");
                Inicializar();
            }
            return resultado;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ChequearDatos() == false)
            {
                Inicializar();
            }
        }
    }
}
