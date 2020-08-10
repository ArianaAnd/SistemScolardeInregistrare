namespace SistemScolardeInregistrare
{
    partial class FrmStudenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudenti));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtDataInregistrarii = new System.Windows.Forms.DateTimePicker();
            this.dtDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbOras = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMunincipiu = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbJudet = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdFeminin = new System.Windows.Forms.RadioButton();
            this.rdMasculin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSpecializare = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnAdugare = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.dtDataInregistrarii);
            this.groupBox1.Controls.Add(this.dtDataNasterii);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbOras);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbMunincipiu);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbJudet);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAdresa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrenume);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNume);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdFeminin);
            this.groupBox1.Controls.Add(this.rdMasculin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbSpecializare);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 588);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Personale";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtDataInregistrarii
            // 
            this.dtDataInregistrarii.CustomFormat = "dd-MM-yyyy";
            this.dtDataInregistrarii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataInregistrarii.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataInregistrarii.Location = new System.Drawing.Point(526, 396);
            this.dtDataInregistrarii.Name = "dtDataInregistrarii";
            this.dtDataInregistrarii.Size = new System.Drawing.Size(200, 30);
            this.dtDataInregistrarii.TabIndex = 26;
            // 
            // dtDataNasterii
            // 
            this.dtDataNasterii.CustomFormat = "dd-MM-yyyy";
            this.dtDataNasterii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataNasterii.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataNasterii.Location = new System.Drawing.Point(146, 396);
            this.dtDataNasterii.Name = "dtDataNasterii";
            this.dtDataNasterii.Size = new System.Drawing.Size(200, 30);
            this.dtDataNasterii.TabIndex = 25;
            this.dtDataNasterii.ValueChanged += new System.EventHandler(this.dtDataNasterii_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 524);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 22);
            this.label12.TabIndex = 24;
            this.label12.Text = "Oras";
            // 
            // cmbOras
            // 
            this.cmbOras.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOras.FormattingEnabled = true;
            this.cmbOras.Location = new System.Drawing.Point(118, 521);
            this.cmbOras.Name = "cmbOras";
            this.cmbOras.Size = new System.Drawing.Size(208, 30);
            this.cmbOras.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(354, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Munincipiu";
            // 
            // cmbMunincipiu
            // 
            this.cmbMunincipiu.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMunincipiu.FormattingEnabled = true;
            this.cmbMunincipiu.Location = new System.Drawing.Point(486, 468);
            this.cmbMunincipiu.Name = "cmbMunincipiu";
            this.cmbMunincipiu.Size = new System.Drawing.Size(203, 30);
            this.cmbMunincipiu.TabIndex = 21;
            this.cmbMunincipiu.SelectedIndexChanged += new System.EventHandler(this.cmbMunincipiu_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 473);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "Judet";
            // 
            // cmbJudet
            // 
            this.cmbJudet.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJudet.FormattingEnabled = true;
            this.cmbJudet.Location = new System.Drawing.Point(118, 465);
            this.cmbJudet.Name = "cmbJudet";
            this.cmbJudet.Size = new System.Drawing.Size(208, 30);
            this.cmbJudet.TabIndex = 19;
            this.cmbJudet.SelectedIndexChanged += new System.EventHandler(this.cmbJudet_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(354, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 22);
            this.label10.TabIndex = 18;
            this.label10.Text = "Data Inregistrarii";
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
            this.label9.Click += new System.EventHandler(this.label9_Click);
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
            // txtAdresa
            // 
            this.txtAdresa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresa.Location = new System.Drawing.Point(118, 217);
            this.txtAdresa.Multiline = true;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(519, 34);
            this.txtAdresa.TabIndex = 13;
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
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(468, 289);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(268, 34);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.Location = new System.Drawing.Point(118, 286);
            this.txtTelefon.Multiline = true;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(278, 34);
            this.txtTelefon.TabIndex = 9;
            this.txtTelefon.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
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
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPrenume
            // 
            this.txtPrenume.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenume.Location = new System.Drawing.Point(452, 162);
            this.txtPrenume.Multiline = true;
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(268, 34);
            this.txtPrenume.TabIndex = 7;
            this.txtPrenume.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nume";
            // 
            // txtNume
            // 
            this.txtNume.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNume.Location = new System.Drawing.Point(118, 159);
            this.txtNume.Multiline = true;
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(231, 34);
            this.txtNume.TabIndex = 5;
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
            // rdFeminin
            // 
            this.rdFeminin.AutoSize = true;
            this.rdFeminin.Checked = true;
            this.rdFeminin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFeminin.Location = new System.Drawing.Point(270, 114);
            this.rdFeminin.Name = "rdFeminin";
            this.rdFeminin.Size = new System.Drawing.Size(106, 26);
            this.rdFeminin.TabIndex = 3;
            this.rdFeminin.TabStop = true;
            this.rdFeminin.Text = "Feminin";
            this.rdFeminin.UseVisualStyleBackColor = true;
            // 
            // rdMasculin
            // 
            this.rdMasculin.AutoSize = true;
            this.rdMasculin.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMasculin.Location = new System.Drawing.Point(118, 114);
            this.rdMasculin.Name = "rdMasculin";
            this.rdMasculin.Size = new System.Drawing.Size(111, 26);
            this.rdMasculin.TabIndex = 2;
            this.rdMasculin.Text = "Masculin";
            this.rdMasculin.UseVisualStyleBackColor = true;
            this.rdMasculin.CheckedChanged += new System.EventHandler(this.rdMasculin_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Specializare";
            // 
            // cmbSpecializare
            // 
            this.cmbSpecializare.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpecializare.FormattingEnabled = true;
            this.cmbSpecializare.Location = new System.Drawing.Point(168, 55);
            this.cmbSpecializare.Name = "cmbSpecializare";
            this.cmbSpecializare.Size = new System.Drawing.Size(278, 30);
            this.cmbSpecializare.TabIndex = 0;
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
            this.groupBox2.Location = new System.Drawing.Point(758, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 588);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procesare";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDate.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDate.Image = ((System.Drawing.Image)(resources.GetObject("btnDate.Image")));
            this.btnDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDate.Location = new System.Drawing.Point(6, 339);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(205, 67);
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
            this.btnActualizare.Location = new System.Drawing.Point(6, 184);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(205, 67);
            this.btnActualizare.TabIndex = 3;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizare.UseVisualStyleBackColor = false;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnSalvare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvare.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvare.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvare.Image")));
            this.btnSalvare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvare.Location = new System.Drawing.Point(6, 106);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(205, 67);
            this.btnSalvare.TabIndex = 2;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvare.UseVisualStyleBackColor = false;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click_1);
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnStergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergere.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStergere.Image = ((System.Drawing.Image)(resources.GetObject("btnStergere.Image")));
            this.btnStergere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStergere.Location = new System.Drawing.Point(6, 256);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(205, 67);
            this.btnStergere.TabIndex = 2;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnAdugare
            // 
            this.btnAdugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnAdugare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdugare.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdugare.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdugare.Image = ((System.Drawing.Image)(resources.GetObject("btnAdugare.Image")));
            this.btnAdugare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdugare.Location = new System.Drawing.Point(6, 30);
            this.btnAdugare.Name = "btnAdugare";
            this.btnAdugare.Size = new System.Drawing.Size(205, 67);
            this.btnAdugare.TabIndex = 1;
            this.btnAdugare.Text = "Adagare";
            this.btnAdugare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdugare.UseVisualStyleBackColor = false;
            this.btnAdugare.Click += new System.EventHandler(this.btnAdugare_Click);
            // 
            // FrmStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 687);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmStudenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studenti";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnAdugare;
        public System.Windows.Forms.TextBox txtNume;
        public System.Windows.Forms.TextBox txtPrenume;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtTelefon;
        public System.Windows.Forms.TextBox txtAdresa;
        public System.Windows.Forms.RadioButton rdFeminin;
        public System.Windows.Forms.RadioButton rdMasculin;
        public System.Windows.Forms.ComboBox cmbOras;
        public System.Windows.Forms.ComboBox cmbMunincipiu;
        public System.Windows.Forms.ComboBox cmbJudet;
        public System.Windows.Forms.DateTimePicker dtDataInregistrarii;
        public System.Windows.Forms.DateTimePicker dtDataNasterii;
        public System.Windows.Forms.ComboBox cmbSpecializare;
        public System.Windows.Forms.Button btnActualizare;
        public System.Windows.Forms.Button btnStergere;
    }
}