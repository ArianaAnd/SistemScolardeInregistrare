namespace SistemScolardeInregistrare
{
    partial class FrmProfesori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfesori));
            this.btnDate = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.dt_pr_DataNasterii = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_pr_Oras = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_pr_Munincipiu = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_pr_Judet = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pr_Adresa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnAdugare = new System.Windows.Forms.Button();
            this.txt_pr_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pr_Prenume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pr_Nume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rd_pr_Feminin = new System.Windows.Forms.RadioButton();
            this.rd_pr_Masculin = new System.Windows.Forms.RadioButton();
            this.ExpLabel = new System.Windows.Forms.Label();
            this.cmbExperienta = new System.Windows.Forms.ComboBox();
            this.btnStergere = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_pr_Telefon = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDate.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDate.Image = ((System.Drawing.Image)(resources.GetObject("btnDate.Image")));
            this.btnDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDate.Location = new System.Drawing.Point(6, 347);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(205, 59);
            this.btnDate.TabIndex = 4;
            this.btnDate.Text = "Date";
            this.btnDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDate.UseVisualStyleBackColor = false;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnActualizare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizare.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizare.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizare.Image")));
            this.btnActualizare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizare.Location = new System.Drawing.Point(6, 192);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(205, 59);
            this.btnActualizare.TabIndex = 3;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizare.UseVisualStyleBackColor = false;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // dt_pr_DataNasterii
            // 
            this.dt_pr_DataNasterii.CustomFormat = "dd-MM-yyyy";
            this.dt_pr_DataNasterii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_pr_DataNasterii.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_pr_DataNasterii.Location = new System.Drawing.Point(146, 396);
            this.dt_pr_DataNasterii.Name = "dt_pr_DataNasterii";
            this.dt_pr_DataNasterii.Size = new System.Drawing.Size(200, 30);
            this.dt_pr_DataNasterii.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(404, 481);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 22);
            this.label12.TabIndex = 24;
            this.label12.Text = "Oras";
            // 
            // cmb_pr_Oras
            // 
            this.cmb_pr_Oras.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pr_Oras.FormattingEnabled = true;
            this.cmb_pr_Oras.Location = new System.Drawing.Point(468, 473);
            this.cmb_pr_Oras.Name = "cmb_pr_Oras";
            this.cmb_pr_Oras.Size = new System.Drawing.Size(208, 30);
            this.cmb_pr_Oras.TabIndex = 23;
            this.cmb_pr_Oras.SelectedIndexChanged += new System.EventHandler(this.cmb_pr_Oras_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Munincipiu";
            // 
            // cmb_pr_Munincipiu
            // 
            this.cmb_pr_Munincipiu.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pr_Munincipiu.FormattingEnabled = true;
            this.cmb_pr_Munincipiu.Location = new System.Drawing.Point(121, 473);
            this.cmb_pr_Munincipiu.Name = "cmb_pr_Munincipiu";
            this.cmb_pr_Munincipiu.Size = new System.Drawing.Size(203, 30);
            this.cmb_pr_Munincipiu.TabIndex = 21;
            this.cmb_pr_Munincipiu.SelectedIndexChanged += new System.EventHandler(this.cmbMunincipiu_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(404, 403);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "Judet";
            // 
            // cmb_pr_Judet
            // 
            this.cmb_pr_Judet.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pr_Judet.FormattingEnabled = true;
            this.cmb_pr_Judet.Location = new System.Drawing.Point(468, 403);
            this.cmb_pr_Judet.Name = "cmb_pr_Judet";
            this.cmb_pr_Judet.Size = new System.Drawing.Size(208, 30);
            this.cmb_pr_Judet.TabIndex = 19;
            this.cmb_pr_Judet.SelectedIndexChanged += new System.EventHandler(this.cmb_pr_Judet_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Data Nasterii";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Adresa";
            // 
            // txt_pr_Adresa
            // 
            this.txt_pr_Adresa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pr_Adresa.Location = new System.Drawing.Point(118, 225);
            this.txt_pr_Adresa.Multiline = true;
            this.txt_pr_Adresa.Name = "txt_pr_Adresa";
            this.txt_pr_Adresa.Size = new System.Drawing.Size(519, 26);
            this.txt_pr_Adresa.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(402, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email";
            // 
            // btnSalvare
            // 
            this.btnSalvare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnSalvare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvare.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvare.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvare.Image")));
            this.btnSalvare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvare.Location = new System.Drawing.Point(6, 114);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(205, 59);
            this.btnSalvare.TabIndex = 2;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvare.UseVisualStyleBackColor = false;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnAdugare
            // 
            this.btnAdugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnAdugare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdugare.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdugare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdugare.Image = ((System.Drawing.Image)(resources.GetObject("btnAdugare.Image")));
            this.btnAdugare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdugare.Location = new System.Drawing.Point(6, 38);
            this.btnAdugare.Name = "btnAdugare";
            this.btnAdugare.Size = new System.Drawing.Size(205, 59);
            this.btnAdugare.TabIndex = 1;
            this.btnAdugare.Text = "Adagare";
            this.btnAdugare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdugare.UseVisualStyleBackColor = false;
            this.btnAdugare.Click += new System.EventHandler(this.btnAdugare_Click);
            // 
            // txt_pr_Email
            // 
            this.txt_pr_Email.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pr_Email.Location = new System.Drawing.Point(468, 297);
            this.txt_pr_Email.Multiline = true;
            this.txt_pr_Email.Name = "txt_pr_Email";
            this.txt_pr_Email.Size = new System.Drawing.Size(268, 26);
            this.txt_pr_Email.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prenume";
            // 
            // txt_pr_Prenume
            // 
            this.txt_pr_Prenume.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pr_Prenume.Location = new System.Drawing.Point(452, 170);
            this.txt_pr_Prenume.Multiline = true;
            this.txt_pr_Prenume.Name = "txt_pr_Prenume";
            this.txt_pr_Prenume.Size = new System.Drawing.Size(268, 26);
            this.txt_pr_Prenume.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nume";
            // 
            // txt_pr_Nume
            // 
            this.txt_pr_Nume.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pr_Nume.Location = new System.Drawing.Point(118, 167);
            this.txt_pr_Nume.Multiline = true;
            this.txt_pr_Nume.Name = "txt_pr_Nume";
            this.txt_pr_Nume.Size = new System.Drawing.Size(231, 26);
            this.txt_pr_Nume.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sex";
            // 
            // rd_pr_Feminin
            // 
            this.rd_pr_Feminin.AutoSize = true;
            this.rd_pr_Feminin.Checked = true;
            this.rd_pr_Feminin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_pr_Feminin.Location = new System.Drawing.Point(270, 114);
            this.rd_pr_Feminin.Name = "rd_pr_Feminin";
            this.rd_pr_Feminin.Size = new System.Drawing.Size(106, 26);
            this.rd_pr_Feminin.TabIndex = 3;
            this.rd_pr_Feminin.TabStop = true;
            this.rd_pr_Feminin.Text = "Feminin";
            this.rd_pr_Feminin.UseVisualStyleBackColor = true;
            // 
            // rd_pr_Masculin
            // 
            this.rd_pr_Masculin.AutoSize = true;
            this.rd_pr_Masculin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_pr_Masculin.Location = new System.Drawing.Point(118, 114);
            this.rd_pr_Masculin.Name = "rd_pr_Masculin";
            this.rd_pr_Masculin.Size = new System.Drawing.Size(111, 26);
            this.rd_pr_Masculin.TabIndex = 2;
            this.rd_pr_Masculin.Text = "Masculin";
            this.rd_pr_Masculin.UseVisualStyleBackColor = true;
            // 
            // ExpLabel
            // 
            this.ExpLabel.AutoSize = true;
            this.ExpLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpLabel.Location = new System.Drawing.Point(17, 55);
            this.ExpLabel.Name = "ExpLabel";
            this.ExpLabel.Size = new System.Drawing.Size(107, 22);
            this.ExpLabel.TabIndex = 1;
            this.ExpLabel.Text = "Experienta";
            // 
            // cmbExperienta
            // 
            this.cmbExperienta.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExperienta.FormattingEnabled = true;
            this.cmbExperienta.Location = new System.Drawing.Point(157, 55);
            this.cmbExperienta.Name = "cmbExperienta";
            this.cmbExperienta.Size = new System.Drawing.Size(278, 30);
            this.cmbExperienta.TabIndex = 0;
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnStergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergere.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStergere.Image = ((System.Drawing.Image)(resources.GetObject("btnStergere.Image")));
            this.btnStergere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStergere.Location = new System.Drawing.Point(6, 264);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(205, 59);
            this.btnStergere.TabIndex = 2;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.dt_pr_DataNasterii);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmb_pr_Oras);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmb_pr_Munincipiu);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmb_pr_Judet);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_pr_Adresa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_pr_Email);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_pr_Telefon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_pr_Prenume);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_pr_Nume);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rd_pr_Feminin);
            this.groupBox1.Controls.Add(this.rd_pr_Masculin);
            this.groupBox1.Controls.Add(this.ExpLabel);
            this.groupBox1.Controls.Add(this.cmbExperienta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 530);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Personale";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_pr_Telefon
            // 
            this.txt_pr_Telefon.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pr_Telefon.Location = new System.Drawing.Point(118, 294);
            this.txt_pr_Telefon.Multiline = true;
            this.txt_pr_Telefon.Name = "txt_pr_Telefon";
            this.txt_pr_Telefon.Size = new System.Drawing.Size(278, 26);
            this.txt_pr_Telefon.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.btnDate);
            this.groupBox2.Controls.Add(this.btnActualizare);
            this.groupBox2.Controls.Add(this.btnSalvare);
            this.groupBox2.Controls.Add(this.btnStergere);
            this.groupBox2.Controls.Add(this.btnAdugare);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(773, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 609);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procesare";
            // 
            // FrmProfesori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 687);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmProfesori";
            this.Text = "FrmProfesori";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDate;
        public System.Windows.Forms.Button btnActualizare;
        public System.Windows.Forms.DateTimePicker dt_pr_DataNasterii;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox cmb_pr_Oras;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cmb_pr_Munincipiu;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox cmb_pr_Judet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_pr_Adresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnAdugare;
        public System.Windows.Forms.TextBox txt_pr_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_pr_Prenume;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_pr_Nume;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RadioButton rd_pr_Feminin;
        public System.Windows.Forms.RadioButton rd_pr_Masculin;
        private System.Windows.Forms.Label ExpLabel;
        public System.Windows.Forms.ComboBox cmbExperienta;
        public System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txt_pr_Telefon;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}