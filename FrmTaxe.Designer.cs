namespace SistemScolardeInregistrare
{
    partial class FrmTaxe
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
            this.GDAfisareStudenti = new System.Windows.Forms.DataGridView();
            this.txt_t_CautareNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_t_CautarePrenume = new System.Windows.Forms.TextBox();
            this.cautarePrenume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GDAfisareStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // GDAfisareStudenti
            // 
            this.GDAfisareStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDAfisareStudenti.Location = new System.Drawing.Point(12, 188);
            this.GDAfisareStudenti.Name = "GDAfisareStudenti";
            this.GDAfisareStudenti.RowHeadersWidth = 62;
            this.GDAfisareStudenti.RowTemplate.Height = 28;
            this.GDAfisareStudenti.Size = new System.Drawing.Size(1359, 367);
            this.GDAfisareStudenti.TabIndex = 14;
            // 
            // txt_t_CautareNume
            // 
            this.txt_t_CautareNume.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_t_CautareNume.Location = new System.Drawing.Point(1017, 133);
            this.txt_t_CautareNume.Multiline = true;
            this.txt_t_CautareNume.Name = "txt_t_CautareNume";
            this.txt_t_CautareNume.Size = new System.Drawing.Size(231, 26);
            this.txt_t_CautareNume.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(861, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cautare dupa nume";
            // 
            // txt_t_CautarePrenume
            // 
            this.txt_t_CautarePrenume.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_t_CautarePrenume.Location = new System.Drawing.Point(225, 133);
            this.txt_t_CautarePrenume.Multiline = true;
            this.txt_t_CautarePrenume.Name = "txt_t_CautarePrenume";
            this.txt_t_CautarePrenume.Size = new System.Drawing.Size(231, 26);
            this.txt_t_CautarePrenume.TabIndex = 11;
            // 
            // cautarePrenume
            // 
            this.cautarePrenume.AutoSize = true;
            this.cautarePrenume.Location = new System.Drawing.Point(46, 138);
            this.cautarePrenume.Name = "cautarePrenume";
            this.cautarePrenume.Size = new System.Drawing.Size(173, 20);
            this.cautarePrenume.TabIndex = 10;
            this.cautarePrenume.Text = "Cautare dupa prenume";
            // 
            // FrmTaxe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 567);
            this.Controls.Add(this.GDAfisareStudenti);
            this.Controls.Add(this.txt_t_CautareNume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_t_CautarePrenume);
            this.Controls.Add(this.cautarePrenume);
            this.Name = "FrmTaxe";
            this.Text = "FrmTaxe";
            ((System.ComponentModel.ISupportInitialize)(this.GDAfisareStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GDAfisareStudenti;
        public System.Windows.Forms.TextBox txt_t_CautareNume;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_t_CautarePrenume;
        private System.Windows.Forms.Label cautarePrenume;
    }
}