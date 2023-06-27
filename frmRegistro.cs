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

        //creo el objeto aca "afuera" para usarlo en todo el codigo
        clsManejoBD objCls = new clsManejoBD();

        //estado inicial del form
        public void Inicializar()
        {
            txtNombre.Text = null;
            txtApellido.Text = null;
            lstPais.SelectedIndex = -1;
            mtxtEdad.Text = null;
            optHombre.Checked = false;
            optMujer.Checked = false;
            txtNombre.Focus();
        }

        //conectar la BD ni bien abre el form
        private void frmRegistro_Load(object sender, EventArgs e)
        {
            try
            {
                objCls.ConectarBD();
                objCls.CargarLstPais(lstPais);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //verificar que todos los datos estan ingresados correctamente
        public bool ChequearDatos()
        {
            bool resultado;
            resultado = false;
            if (txtNombre.Text != null)
            {
                if (txtApellido.Text != null)
                {
                    if (lstPais.SelectedIndex == -1)
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
            //antes de registrar chequea que todos los datos esten ingresados correctamente
            ChequearDatos();

            //booleano para determinar el tipo de sexo utilizando el boton de opcion
            bool sexo = true;
            if (optHombre.Checked == true)
            {
                sexo = true;
            }
            else
            {
                if (optMujer.Checked == true)
                {
                    sexo = false;
                }
            }
            objCls.RegistrarBD(txtNombre.Text, txtApellido.Text, lstPais.Text, Convert.ToInt16(mtxtEdad.Text), sexo, "$ 1.000");
            //reinicio todos los datos para poder seguir registrando otros miembros
            Inicializar();
        }

        //abrir el otro form para registrar un nuevo pais
        private void btnAgregarPais_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAgregarPais frm = new frmAgregarPais();
            frm.ShowDialog();
        }
    }
}
