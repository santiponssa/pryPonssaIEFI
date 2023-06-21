using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryPonssaIEFI
{
    public class clsManejo
    {
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader rdr;

        public string RutaBD;
        public void ConectarBD()
        {
            RutaBD = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\EL_CLUB.accdb";
            try
            {
                conn.ConnectionString = RutaBD;
                conn.Open();
                //MessageBox.Show("Base de Datos conectada");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }
        public void RegistrarBD()
        {
            
        }
    }
}
