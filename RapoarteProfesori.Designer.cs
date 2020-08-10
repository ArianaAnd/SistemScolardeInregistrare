namespace SistemScolardeInregistrare
{
    partial class RapoarteProfesori
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SistemScolarDataSet = new SistemScolardeInregistrare.SistemScolarDataSet();
            this.ProfesoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProfesoriTableAdapter = new SistemScolardeInregistrare.SistemScolarDataSetTableAdapters.ProfesoriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SistemScolarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProfesoriBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemScolardeInregistrare.RaportProf.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-4, 77);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1323, 373);
            this.reportViewer1.TabIndex = 0;
            // 
            // SistemScolarDataSet
            // 
            this.SistemScolarDataSet.DataSetName = "SistemScolarDataSet";
            this.SistemScolarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProfesoriBindingSource
            // 
            this.ProfesoriBindingSource.DataMember = "Profesori";
            this.ProfesoriBindingSource.DataSource = this.SistemScolarDataSet;
            // 
            // ProfesoriTableAdapter
            // 
            this.ProfesoriTableAdapter.ClearBeforeFill = true;
            // 
            // RapoarteProfesori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RapoarteProfesori";
            this.Text = "RapoarteProfesori";
            this.Load += new System.EventHandler(this.RapoarteProfesori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SistemScolarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesoriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProfesoriBindingSource;
        private SistemScolarDataSet SistemScolarDataSet;
        private SistemScolarDataSetTableAdapters.ProfesoriTableAdapter ProfesoriTableAdapter;
    }
}