namespace pryPonssaIEFI
{
    partial class frmAgregarPais
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
            this.sOCIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eL_CLUBDataSet = new pryPonssaIEFI.EL_CLUBDataSet();
            this.sOCIOSTableAdapter = new pryPonssaIEFI.EL_CLUBDataSetTableAdapters.SOCIOSTableAdapter();
            this.tableAdapterManager = new pryPonssaIEFI.EL_CLUBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.sOCIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eL_CLUBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sOCIOSBindingSource
            // 
            this.sOCIOSBindingSource.DataMember = "SOCIOS";
            this.sOCIOSBindingSource.DataSource = this.eL_CLUBDataSet;
            // 
            // eL_CLUBDataSet
            // 
            this.eL_CLUBDataSet.DataSetName = "EL_CLUBDataSet";
            this.eL_CLUBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 278);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sOCIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eL_CLUBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EL_CLUBDataSet eL_CLUBDataSet;
        private System.Windows.Forms.BindingSource sOCIOSBindingSource;
        private EL_CLUBDataSetTableAdapters.SOCIOSTableAdapter sOCIOSTableAdapter;
        private EL_CLUBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}