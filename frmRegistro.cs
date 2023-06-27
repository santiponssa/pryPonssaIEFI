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

        clsManejo objCls = new clsManejo();
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand comm = new OleDbCommand();
        OleDbDataReader rdr;

        public void Inicializar()
        {
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtPais.Text = null;
            mtxtEdad.Text = null;
            lstSexo.SelectedIndex = -1;
            txtNombre.Focus();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            
            try
            {
                objCls.ConectarBD();
            }
            catch (Exception exc)
            {
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
                            if (lstSexo.SelectedIndex == -1)
                            {
                                resultado = true;
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
            ChequearDatos();
            try
            {
                string agregar = "insert into SOCIOS values (" + txtNombre.Text + "','" + txtApellido.Text +
                "','" + txtPais.Text + "'," + mtxtEdad + ",'" + lstSexo.SelectedIndex + ")";

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
