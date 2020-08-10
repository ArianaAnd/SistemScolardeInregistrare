namespace SistemScolardeInregistrare
{
    partial class FrmAfisareStudenti
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
            this.cautarePrenume = new System.Windows.Forms.Label();
            this.txtCautarePrenume = new System.Windows.Forms.TextBox();
            this.txtCautareNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GDAfisareStudenti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GDAfisareStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // cautarePrenume
            // 
            this.cautarePrenume.AutoSize = true;
            this.cautarePrenume.Location = new System.Drawing.Point(38, 114);
            this.cautarePrenume.Name = "cautarePrenume";
            this.cautarePrenume.Size = new System.Drawing.Size(173, 20);
            this.cautarePrenume.TabIndex = 1;
            this.cautarePrenume.Text = "Cautare dupa prenume";
            this.cautarePrenume.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCautarePrenume
            // 
            this.txtCautarePrenume.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCautarePrenume.Location = new System.Drawing.Point(217, 109);
            this.txtCautarePrenume.Multiline = true;
            this.txtCautarePrenume.Name = "txtCautarePrenume";
            this.txtCautarePrenume.Size = new System.Drawing.Size(231, 26);
            this.txtCautarePrenume.TabIndex = 6;
            this.txtCautarePrenume.TextChanged += new System.EventHandler(this.txtCautareNume_TextChanged);
            // 
            // txtCautareNume
            // 
            this.txtCautareNume.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCautareNume.Location = new System.Drawing.Point(1009, 109);
            this.txtCautareNume.Multiline = true;
            this.txtCautareNume.Name = "txtCautareNume";
            this.txtCautareNume.Size = new System.Drawing.Size(231, 26);
            this.txtCautareNume.TabIndex = 8;
            this.txtCautareNume.TextChanged += new System.EventHandler(this.txtCautareNume_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(853, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cautare dupa nume";
            // 
            // GDAfisareStudenti
            // 
            this.GDAfisareStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDAfisareStudenti.Location = new System.Drawing.Point(4, 164);
            this.GDAfisareStudenti.Name = "GDAfisareStudenti";
            this.GDAfisareStudenti.RowHeadersWidth = 62;
            this.GDAfisareStudenti.RowTemplate.Height = 28;
            this.GDAfisareStudenti.Size = new System.Drawing.Size(1359, 367);
            this.GDAfisareStudenti.TabIndex = 9;
            this.GDAfisareStudenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GDAfisareStudenti_CellContentClick);
            // 
            // FrmAfisareStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 543);
            this.Controls.Add(this.GDAfisareStudenti);
            this.Controls.Add(this.txtCautareNume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCautarePrenume);
            this.Controls.Add(this.cautarePrenume);
            this.Name = "FrmAfisareStudenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAfisareStudenti";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAfisareStudenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GDAfisareStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cautarePrenume;
        public System.Windows.Forms.TextBox txtCautarePrenume;
        public System.Windows.Forms.TextBox txtCautareNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GDAfisareStudenti;
    }
}