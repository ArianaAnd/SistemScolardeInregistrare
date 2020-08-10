namespace SistemScolardeInregistrare
{
    partial class InregistrareUtilizator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Utilizator = new System.Windows.Forms.GroupBox();
            this.UtilizatorInreg = new System.Windows.Forms.GroupBox();
            this.numeUt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pozitia = new System.Windows.Forms.Label();
            this.confPar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.DGVUtilInreg = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Actualizare = new System.Windows.Forms.Button();
            this.Stergere = new System.Windows.Forms.Button();
            this.Resetare = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Utilizator.SuspendLayout();
            this.UtilizatorInreg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUtilInreg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Resetare);
            this.panel1.Controls.Add(this.Stergere);
            this.panel1.Controls.Add(this.Actualizare);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.UtilizatorInreg);
            this.panel1.Controls.Add(this.Utilizator);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1417, 501);
            this.panel1.TabIndex = 0;
            // 
            // Utilizator
            // 
            this.Utilizator.Controls.Add(this.textBox4);
            this.Utilizator.Controls.Add(this.textBox3);
            this.Utilizator.Controls.Add(this.textBox2);
            this.Utilizator.Controls.Add(this.textBox1);
            this.Utilizator.Controls.Add(this.confPar);
            this.Utilizator.Controls.Add(this.pozitia);
            this.Utilizator.Controls.Add(this.label2);
            this.Utilizator.Controls.Add(this.numeUt);
            this.Utilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Utilizator.Location = new System.Drawing.Point(67, 21);
            this.Utilizator.Name = "Utilizator";
            this.Utilizator.Size = new System.Drawing.Size(505, 316);
            this.Utilizator.TabIndex = 0;
            this.Utilizator.TabStop = false;
            this.Utilizator.Text = "Utilizatori";
            // 
            // UtilizatorInreg
            // 
            this.UtilizatorInreg.Controls.Add(this.DGVUtilInreg);
            this.UtilizatorInreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UtilizatorInreg.Location = new System.Drawing.Point(788, 21);
            this.UtilizatorInreg.Name = "UtilizatorInreg";
            this.UtilizatorInreg.Size = new System.Drawing.Size(505, 316);
            this.UtilizatorInreg.TabIndex = 1;
            this.UtilizatorInreg.TabStop = false;
            this.UtilizatorInreg.Text = "Utilizatori Inregistrati";
            // 
            // numeUt
            // 
            this.numeUt.AutoSize = true;
            this.numeUt.ForeColor = System.Drawing.Color.Black;
            this.numeUt.Location = new System.Drawing.Point(10, 41);
            this.numeUt.Name = "numeUt";
            this.numeUt.Size = new System.Drawing.Size(132, 20);
            this.numeUt.TabIndex = 0;
            this.numeUt.Text = "Nume Utilizator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // pozitia
            // 
            this.pozitia.AutoSize = true;
            this.pozitia.ForeColor = System.Drawing.Color.Black;
            this.pozitia.Location = new System.Drawing.Point(10, 181);
            this.pozitia.Name = "pozitia";
            this.pozitia.Size = new System.Drawing.Size(63, 20);
            this.pozitia.TabIndex = 2;
            this.pozitia.Text = "Pozitia";
            // 
            // confPar
            // 
            this.confPar.AutoSize = true;
            this.confPar.ForeColor = System.Drawing.Color.Black;
            this.confPar.Location = new System.Drawing.Point(10, 138);
            this.confPar.Name = "confPar";
            this.confPar.Size = new System.Drawing.Size(153, 20);
            this.confPar.TabIndex = 3;
            this.confPar.Text = "Confirmare Parola";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 26);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(169, 178);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(234, 26);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(169, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(234, 26);
            this.textBox4.TabIndex = 7;
            // 
            // DGVUtilInreg
            // 
            this.DGVUtilInreg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUtilInreg.Location = new System.Drawing.Point(7, 26);
            this.DGVUtilInreg.Name = "DGVUtilInreg";
            this.DGVUtilInreg.RowHeadersWidth = 62;
            this.DGVUtilInreg.RowTemplate.Height = 28;
            this.DGVUtilInreg.Size = new System.Drawing.Size(492, 284);
            this.DGVUtilInreg.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(102, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Inregistrare";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Actualizare
            // 
            this.Actualizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.Actualizare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizare.ForeColor = System.Drawing.Color.White;
            this.Actualizare.Location = new System.Drawing.Point(343, 422);
            this.Actualizare.Name = "Actualizare";
            this.Actualizare.Size = new System.Drawing.Size(127, 54);
            this.Actualizare.TabIndex = 3;
            this.Actualizare.Text = "Actualizare";
            this.Actualizare.UseVisualStyleBackColor = false;
            // 
            // Stergere
            // 
            this.Stergere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.Stergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stergere.Location = new System.Drawing.Point(830, 422);
            this.Stergere.Name = "Stergere";
            this.Stergere.Size = new System.Drawing.Size(126, 54);
            this.Stergere.TabIndex = 4;
            this.Stergere.Text = "Stergere";
            this.Stergere.UseVisualStyleBackColor = false;
            // 
            // Resetare
            // 
            this.Resetare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.Resetare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetare.Location = new System.Drawing.Point(567, 422);
            this.Resetare.Name = "Resetare";
            this.Resetare.Size = new System.Drawing.Size(135, 54);
            this.Resetare.TabIndex = 5;
            this.Resetare.Text = "Resetare";
            this.Resetare.UseVisualStyleBackColor = false;
            // 
            // InregistrareUtilizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 578);
            this.Controls.Add(this.panel1);
            this.Name = "InregistrareUtilizator";
            this.Text = "InregistrareUtilizator";
            this.panel1.ResumeLayout(false);
            this.Utilizator.ResumeLayout(false);
            this.Utilizator.PerformLayout();
            this.UtilizatorInreg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUtilInreg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox UtilizatorInreg;
        private System.Windows.Forms.GroupBox Utilizator;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label confPar;
        private System.Windows.Forms.Label pozitia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numeUt;
        private System.Windows.Forms.Button Resetare;
        private System.Windows.Forms.Button Stergere;
        private System.Windows.Forms.Button Actualizare;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGVUtilInreg;
    }
}