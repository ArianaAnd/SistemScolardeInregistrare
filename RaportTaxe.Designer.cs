namespace SistemScolardeInregistrare
{
    partial class RaportTaxe
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
            this.SistemScolarDataSet2 = new SistemScolardeInregistrare.SistemScolarDataSet2();
            this.rapTaxaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rapTaxaTableAdapter = new SistemScolardeInregistrare.SistemScolarDataSet2TableAdapters.rapTaxaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SistemScolarDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapTaxaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rapTaxaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemScolardeInregistrare.rapTaxecs.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-6, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1458, 452);
            this.reportViewer1.TabIndex = 0;
            // 
            // SistemScolarDataSet2
            // 
            this.SistemScolarDataSet2.DataSetName = "SistemScolarDataSet2";
            this.SistemScolarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rapTaxaBindingSource
            // 
            this.rapTaxaBindingSource.DataMember = "rapTaxa";
            this.rapTaxaBindingSource.DataSource = this.SistemScolarDataSet2;
            // 
            // rapTaxaTableAdapter
            // 
            this.rapTaxaTableAdapter.ClearBeforeFill = true;
            // 
            // RaportTaxe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RaportTaxe";
            this.Text = "RaportTaxe";
            this.Load += new System.EventHandler(this.RaportTaxe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SistemScolarDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapTaxaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rapTaxaBindingSource;
        private SistemScolarDataSet2 SistemScolarDataSet2;
        private SistemScolarDataSet2TableAdapters.rapTaxaTableAdapter rapTaxaTableAdapter;
    }
}