namespace SistemScolardeInregistrare
{
    partial class RaportStudenti
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
            this.SistemScolarDataSet1 = new SistemScolardeInregistrare.SistemScolarDataSet1();
            this.rapStudentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rapStudentiTableAdapter = new SistemScolardeInregistrare.SistemScolarDataSet1TableAdapters.rapStudentiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SistemScolarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapStudentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rapStudentiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemScolardeInregistrare.rapStudenti.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1487, 447);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // SistemScolarDataSet1
            // 
            this.SistemScolarDataSet1.DataSetName = "SistemScolarDataSet1";
            this.SistemScolarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rapStudentiBindingSource
            // 
            this.rapStudentiBindingSource.DataMember = "rapStudenti";
            this.rapStudentiBindingSource.DataSource = this.SistemScolarDataSet1;
            // 
            // rapStudentiTableAdapter
            // 
            this.rapStudentiTableAdapter.ClearBeforeFill = true;
            // 
            // RaportStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RaportStudenti";
            this.Text = "RaportStudenti";
            this.Load += new System.EventHandler(this.RaportStudenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SistemScolarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapStudentiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rapStudentiBindingSource;
        private SistemScolarDataSet1 SistemScolarDataSet1;
        private SistemScolarDataSet1TableAdapters.rapStudentiTableAdapter rapStudentiTableAdapter;
    }
}