using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPonssaIEFI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sOCIOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sOCIOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eL_CLUBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'eL_CLUBDataSet.SOCIOS' Puede moverla o quitarla según sea necesario.
            this.sOCIOSTableAdapter.Fill(this.eL_CLUBDataSet.SOCIOS);

        }
    }
}
