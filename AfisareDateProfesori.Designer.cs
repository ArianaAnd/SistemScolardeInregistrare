namespace SistemScolardeInregistrare
{
    partial class AfisareDateProfesori
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
            this.txt_pr_CautareNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pr_CautarePrenume = new System.Windows.Forms.TextBox();
            this.cautarePrenume = new System.Windows.Forms.Label();
            this.GDAfisareProfesori = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GDAfisareProfesori)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pr_CautareNume
            // 
            this.txt_pr_CautareNume.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pr_CautareNume.Location = new System.Drawing.Point(1052, 139);
            this.txt_pr_CautareNume.Multiline = true;
            this.txt_pr_CautareNume.Name = "txt_pr_CautareNume";
            this.txt_pr_CautareNume.Size = new System.Drawing.Size(319, 26);
            this.txt_pr_CautareNume.TabIndex = 13;
            this.txt_pr_CautareNume.TextChanged += new System.EventHandler(this.txt_pr_CautareNume_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(896, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cautare dupa nume";
            // 
            // txt_pr_CautarePrenume
            // 
            this.txt_pr_CautarePrenume.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pr_CautarePrenume.Location = new System.Drawing.Point(251, 133);
            this.txt_pr_CautarePrenume.Multiline = true;
            this.txt_pr_CautarePrenume.Name = "txt_pr_CautarePrenume";
            this.txt_pr_CautarePrenume.Size = new System.Drawing.Size(319, 26);
            this.txt_pr_CautarePrenume.TabIndex = 11;
            this.txt_pr_CautarePrenume.TextChanged += new System.EventHandler(this.txt_pr_CautarePrenume_TextChanged);
            // 
            // cautarePrenume
            // 
            this.cautarePrenume.AutoSize = true;
            this.cautarePrenume.Location = new System.Drawing.Point(72, 138);
            this.cautarePrenume.Name = "cautarePrenume";
            this.cautarePrenume.Size = new System.Drawing.Size(173, 20);
            this.cautarePrenume.TabIndex = 10;
            this.cautarePrenume.Text = "Cautare dupa prenume";
            // 
            // GDAfisareProfesori
            // 
            this.GDAfisareProfesori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GDAfisareProfesori.Location = new System.Drawing.Point(3, 181);
            this.GDAfisareProfesori.Name = "GDAfisareProfesori";
            this.GDAfisareProfesori.RowHeadersWidth = 62;
            this.GDAfisareProfesori.RowTemplate.Height = 28;
            this.GDAfisareProfesori.Size = new System.Drawing.Size(1507, 319);
            this.GDAfisareProfesori.TabIndex = 9;
            this.GDAfisareProfesori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GDAfisareProfesori_CellContentClick);
            this.GDAfisareProfesori.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GDAfisareProfesori_CellDoubleClick);
            // 
            // AfisareDateProfesori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 500);
            this.Controls.Add(this.txt_pr_CautareNume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pr_CautarePrenume);
            this.Controls.Add(this.cautarePrenume);
            this.Controls.Add(this.GDAfisareProfesori);
            this.Name = "AfisareDateProfesori";
            this.Text = "AfisareDateProfesori";
            this.Load += new System.EventHandler(this.AfisareDateProfesori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GDAfisareProfesori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_pr_CautareNume;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_pr_CautarePrenume;
        private System.Windows.Forms.Label cautarePrenume;
        private System.Windows.Forms.DataGridView GDAfisareProfesori;
    }
}