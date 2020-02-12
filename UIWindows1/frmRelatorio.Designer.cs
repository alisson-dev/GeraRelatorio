namespace UIWindows1
{
    partial class frmRelatorio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.FORMULARIO_SPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JUCESPONLINEDataSet = new UIWindows1.JUCESPONLINEDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FORMULARIO_SPTableAdapter = new UIWindows1.JUCESPONLINEDataSetTableAdapters.FORMULARIO_SPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FORMULARIO_SPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JUCESPONLINEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // FORMULARIO_SPBindingSource
            // 
            this.FORMULARIO_SPBindingSource.DataMember = "FORMULARIO_SP";
            this.FORMULARIO_SPBindingSource.DataSource = this.JUCESPONLINEDataSet;
            // 
            // JUCESPONLINEDataSet
            // 
            this.JUCESPONLINEDataSet.DataSetName = "JUCESPONLINEDataSet";
            this.JUCESPONLINEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsFormularioSp";
            reportDataSource1.Value = this.FORMULARIO_SPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UIWindows1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(965, 495);
            this.reportViewer1.TabIndex = 0;
            // 
            // FORMULARIO_SPTableAdapter
            // 
            this.FORMULARIO_SPTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 495);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FORMULARIO_SPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JUCESPONLINEDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FORMULARIO_SPBindingSource;
        private JUCESPONLINEDataSet JUCESPONLINEDataSet;
        private JUCESPONLINEDataSetTableAdapters.FORMULARIO_SPTableAdapter FORMULARIO_SPTableAdapter;
    }
}