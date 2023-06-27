namespace pryPonssaIEFI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.eL_CLUBDataSet = new pryPonssaIEFI.EL_CLUBDataSet();
            this.sOCIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sOCIOSTableAdapter = new pryPonssaIEFI.EL_CLUBDataSetTableAdapters.SOCIOSTableAdapter();
            this.tableAdapterManager = new pryPonssaIEFI.EL_CLUBDataSetTableAdapters.TableAdapterManager();
            this.sOCIOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eL_CLUBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCIOSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // eL_CLUBDataSet
            // 
            this.eL_CLUBDataSet.DataSetName = "EL_CLUBDataSet";
            this.eL_CLUBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sOCIOSBindingSource
            // 
            this.sOCIOSBindingSource.DataMember = "SOCIOS";
            this.sOCIOSBindingSource.DataSource = this.eL_CLUBDataSet;
            // 
            // sOCIOSTableAdapter
            // 
            this.sOCIOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SOCIOSTableAdapter = this.sOCIOSTableAdapter;
            this.tableAdapterManager.UpdateOrder = pryPonssaIEFI.EL_CLUBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sOCIOSDataGridView
            // 
            this.sOCIOSDataGridView.AutoGenerateColumns = false;
            this.sOCIOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sOCIOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.sOCIOSDataGridView.DataSource = this.sOCIOSBindingSource;
            this.sOCIOSDataGridView.Location = new System.Drawing.Point(3, 12);
            this.sOCIOSDataGridView.Name = "sOCIOSDataGridView";
            this.sOCIOSDataGridView.Size = new System.Drawing.Size(849, 426);
            this.sOCIOSDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODIGO_SOCIO";
            this.dataGridViewTextBoxColumn1.HeaderText = "CODIGO_SOCIO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "APELLIDO";
            this.dataGridViewTextBoxColumn3.HeaderText = "APELLIDO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LUGAR_NACIMIENTO";
            this.dataGridViewTextBoxColumn4.HeaderText = "LUGAR_NACIMIENTO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EDAD";
            this.dataGridViewTextBoxColumn5.HeaderText = "EDAD";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "SEXO";
            this.dataGridViewCheckBoxColumn1.HeaderText = "SEXO";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "INGRESO";
            this.dataGridViewTextBoxColumn6.HeaderText = "INGRESO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PUNTAJE";
            this.dataGridViewTextBoxColumn7.HeaderText = "PUNTAJE";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.sOCIOSDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eL_CLUBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOCIOSDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EL_CLUBDataSet eL_CLUBDataSet;
        private System.Windows.Forms.BindingSource sOCIOSBindingSource;
        private EL_CLUBDataSetTableAdapters.SOCIOSTableAdapter sOCIOSTableAdapter;
        private EL_CLUBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sOCIOSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}