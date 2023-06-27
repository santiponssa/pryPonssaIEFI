using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace pryPonssaIEFI
{
    public class clsManejoBD

    {

        OleDbConnection conn = new OleDbConnection();
        OleDbCommand comm = new OleDbCommand();
        OleDbDataReader rdr;

        public string RutaBD;
        public void ConectarBD()
        {
            RutaBD = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\EL_CLUB.accdb";
            try
            {
                conn.ConnectionString = RutaBD;
                conn.Open();
                MessageBox.Show("Base de Datos conectada");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }
        public void CargarLstPais(ComboBox lstPais)
        {
            //string query sql
            string cargarLst = "SELECT LUGAR_NACIMIENTO from SOCIOS ORDER BY LUGAR_NACIMIENTO ASC";

            try
            {
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = cargarLst;
                rdr = comm.ExecuteReader();

                while (rdr.Read())
                {
                    //agrego los paises de la tabla en el combo box
                    lstPais.Items.Add(rdr[0].ToString());
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        public void RegistrarBD(string Nombre, string Apellido, string LugarNac, int Edad, bool Sexo, string Ingreso)
        {
            string consultaSql = "INSERT INTO SOCIOS (NOMBRE, APELLIDO, LUGAR_NACIMIENTO, EDAD, SEXO, INGRESO)" +
                     "VALUES (@Nombre, @Apellido, @LugarNac, @Edad, @Sexo, @Ingreso)";

            try
            {
                //llamo los objetos conexion y command para escribir la base de datos
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = consultaSql;
                comm.Parameters.AddWithValue("@Nombre", Nombre);
                comm.Parameters.AddWithValue("@Apellido", Apellido);
                comm.Parameters.AddWithValue("@LugarNac", LugarNac);
                comm.Parameters.AddWithValue("@Edad", Edad);
                comm.Parameters.AddWithValue("@Sexo", Sexo);
                comm.Parameters.AddWithValue("@Ingreso", Ingreso);
                comm.ExecuteNonQuery();

                MessageBox.Show("Miembro registrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }
    }
}
