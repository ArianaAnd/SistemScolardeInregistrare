namespace SistemScolardeInregistrare
{
    partial class InregistrareUtilizatori
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
            this.Utilizatori = new System.Windows.Forms.GroupBox();
            this.txt_ConfParola = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txt_Pozitia = new System.Windows.Forms.TextBox();
            this.txt_Nume = new System.Windows.Forms.TextBox();
            this.Pozitia = new System.Windows.Forms.Label();
            this.ConfParola = new System.Windows.Forms.Label();
            this.Parola = new System.Windows.Forms.Label();
            this.Nume = new System.Windows.Forms.Label();
            this.UtilizatoriInregistrati = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInreg = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnResetare = new System.Windows.Forms.Button();
            this.sistemScolarDataSet = new SistemScolardeInregistrare.SistemScolarDataSet();
            this.tblUtilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUtilizatoriTableAdapter = new SistemScolardeInregistrare.SistemScolarDataSetTableAdapters.tblUtilizatoriTableAdapter();
            this.utilizatoriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeUtilizatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozitiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utilizatori.SuspendLayout();
            this.UtilizatoriInregistrati.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistemScolarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUtilizatoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Utilizatori
            // 
            this.Utilizatori.Controls.Add(this.txt_ConfParola);
            this.Utilizatori.Controls.Add(this.txtParola);
            this.Utilizatori.Controls.Add(this.txt_Pozitia);
            this.Utilizatori.Controls.Add(this.txt_Nume);
            this.Utilizatori.Controls.Add(this.Pozitia);
            this.Utilizatori.Controls.Add(this.ConfParola);
            this.Utilizatori.Controls.Add(this.Parola);
            this.Utilizatori.Controls.Add(this.Nume);
            this.Utilizatori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Utilizatori.ForeColor = System.Drawing.Color.Black;
            this.Utilizatori.Location = new System.Drawing.Point(11, 16);
            this.Utilizatori.Name = "Utilizatori";
            this.Utilizatori.Size = new System.Drawing.Size(649, 412);
            this.Utilizatori.TabIndex = 0;
            this.Utilizatori.TabStop = false;
            this.Utilizatori.Text = "Utilizatori ";
            this.Utilizatori.Enter += new System.EventHandler(this.UtilizatoriInregistrati_Enter);
            // 
            // txt_ConfParola
            // 
            this.txt_ConfParola.Location = new System.Drawing.Point(230, 152);
            this.txt_ConfParola.Name = "txt_ConfParola";
            this.txt_ConfParola.Size = new System.Drawing.Size(309, 26);
            this.txt_ConfParola.TabIndex = 2;
            this.txt_ConfParola.UseSystemPasswordChar = true;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(230, 94);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(309, 26);
            this.txtParola.TabIndex = 1;
            this.txtParola.UseSystemPasswordChar = true;
            this.txtParola.TextChanged += new System.EventHandler(this.txtParola_TextChanged);
            // 
            // txt_Pozitia
            // 
            this.txt_Pozitia.Location = new System.Drawing.Point(230, 234);
            this.txt_Pozitia.Name = "txt_Pozitia";
            this.txt_Pozitia.Size = new System.Drawing.Size(309, 26);
            this.txt_Pozitia.TabIndex = 3;
            // 
            // txt_Nume
            // 
            this.txt_Nume.Location = new System.Drawing.Point(230, 38);
            this.txt_Nume.Name = "txt_Nume";
            this.txt_Nume.Size = new System.Drawing.Size(309, 26);
            this.txt_Nume.TabIndex = 0;
            // 
            // Pozitia
            // 
            this.Pozitia.AutoSize = true;
            this.Pozitia.Location = new System.Drawing.Point(7, 234);
            this.Pozitia.Name = "Pozitia";
            this.Pozitia.Size = new System.Drawing.Size(63, 20);
            this.Pozitia.TabIndex = 3;
            this.Pozitia.Text = "Pozitia";
            // 
            // ConfParola
            // 
            this.ConfParola.AutoSize = true;
            this.ConfParola.Location = new System.Drawing.Point(7, 155);
            this.ConfParola.Name = "ConfParola";
            this.ConfParola.Size = new System.Drawing.Size(153, 20);
            this.ConfParola.TabIndex = 2;
            this.ConfParola.Text = "Confirmare Parola";
            // 
            // Parola
            // 
            this.Parola.AutoSize = true;
            this.Parola.Location = new System.Drawing.Point(7, 94);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(60, 20);
            this.Parola.TabIndex = 1;
            this.Parola.Text = "Parola";
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Location = new System.Drawing.Point(7, 38);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(55, 20);
            this.Nume.TabIndex = 0;
            this.Nume.Text = "Nume";
            // 
            // UtilizatoriInregistrati
            // 
            this.UtilizatoriInregistrati.Controls.Add(this.dataGridView1);
            this.UtilizatoriInregistrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UtilizatoriInregistrati.ForeColor = System.Drawing.Color.Black;
            this.UtilizatoriInregistrati.Location = new System.Drawing.Point(747, 3);
            this.UtilizatoriInregistrati.Name = "UtilizatoriInregistrati";
            this.UtilizatoriInregistrati.Size = new System.Drawing.Size(767, 425);
            this.UtilizatoriInregistrati.TabIndex = 1;
            this.UtilizatoriInregistrati.TabStop = false;
            this.UtilizatoriInregistrati.Text = "Utilizatori Inregistrati";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.utilizatoriIDDataGridViewTextBoxColumn,
            this.numeUtilizatorDataGridViewTextBoxColumn,
            this.parolaDataGridViewTextBoxColumn,
            this.pozitiaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblUtilizatoriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(760, 374);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // btnInreg
            // 
            this.btnInreg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnInreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInreg.ForeColor = System.Drawing.Color.White;
            this.btnInreg.Location = new System.Drawing.Point(53, 434);
            this.btnInreg.Name = "btnInreg";
            this.btnInreg.Size = new System.Drawing.Size(138, 49);
            this.btnInreg.TabIndex = 2;
            this.btnInreg.Text = "Inregistrare";
            this.btnInreg.UseVisualStyleBackColor = false;
            this.btnInreg.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStergere);
            this.panel1.Controls.Add(this.btnActualizare);
            this.panel1.Controls.Add(this.btnResetare);
            this.panel1.Controls.Add(this.btnInreg);
            this.panel1.Controls.Add(this.UtilizatoriInregistrati);
            this.panel1.Controls.Add(this.Utilizatori);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1506, 504);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergere.ForeColor = System.Drawing.Color.White;
            this.btnStergere.Location = new System.Drawing.Point(776, 434);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(138, 49);
            this.btnStergere.TabIndex = 4;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnActualizare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizare.ForeColor = System.Drawing.Color.White;
            this.btnActualizare.Location = new System.Drawing.Point(307, 434);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(138, 49);
            this.btnActualizare.TabIndex = 3;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = false;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnResetare
            // 
            this.btnResetare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
            this.btnResetare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetare.ForeColor = System.Drawing.Color.White;
            this.btnResetare.Location = new System.Drawing.Point(535, 434);
            this.btnResetare.Name = "btnResetare";
            this.btnResetare.Size = new System.Drawing.Size(138, 49);
            this.btnResetare.TabIndex = 3;
            this.btnResetare.Text = "Resetare";
            this.btnResetare.UseVisualStyleBackColor = false;
            this.btnResetare.Click += new System.EventHandler(this.btnResetare_Click);
            // 
            // sistemScolarDataSet
            // 
            this.sistemScolarDataSet.DataSetName = "SistemScolarDataSet";
            this.sistemScolarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUtilizatoriBindingSource
            // 
            this.tblUtilizatoriBindingSource.DataMember = "tblUtilizatori";
            this.tblUtilizatoriBindingSource.DataSource = this.sistemScolarDataSet;
            // 
            // tblUtilizatoriTableAdapter
            // 
            this.tblUtilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // utilizatoriIDDataGridViewTextBoxColumn
            // 
            this.utilizatoriIDDataGridViewTextBoxColumn.DataPropertyName = "UtilizatoriID";
            this.utilizatoriIDDataGridViewTextBoxColumn.HeaderText = "UtilizatoriID";
            this.utilizatoriIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.utilizatoriIDDataGridViewTextBoxColumn.Name = "utilizatoriIDDataGridViewTextBoxColumn";
            this.utilizatoriIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // numeUtilizatorDataGridViewTextBoxColumn
            // 
            this.numeUtilizatorDataGridViewTextBoxColumn.DataPropertyName = "Nume Utilizator";
            this.numeUtilizatorDataGridViewTextBoxColumn.HeaderText = "Nume Utilizator";
            this.numeUtilizatorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numeUtilizatorDataGridViewTextBoxColumn.Name = "numeUtilizatorDataGridViewTextBoxColumn";
            this.numeUtilizatorDataGridViewTextBoxColumn.Width = 150;
            // 
            // parolaDataGridViewTextBoxColumn
            // 
            this.parolaDataGridViewTextBoxColumn.DataPropertyName = "Parola";
            this.parolaDataGridViewTextBoxColumn.HeaderText = "Parola";
            this.parolaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.parolaDataGridViewTextBoxColumn.Name = "parolaDataGridViewTextBoxColumn";
            this.parolaDataGridViewTextBoxColumn.Width = 150;
            // 
            // pozitiaDataGridViewTextBoxColumn
            // 
            this.pozitiaDataGridViewTextBoxColumn.DataPropertyName = "Pozitia";
            this.pozitiaDataGridViewTextBoxColumn.HeaderText = "Pozitia";
            this.pozitiaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pozitiaDataGridViewTextBoxColumn.Name = "pozitiaDataGridViewTextBoxColumn";
            this.pozitiaDataGridViewTextBoxColumn.Width = 150;
            // 
            // InregistrareUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 554);
            this.Controls.Add(this.panel1);
            this.Name = "InregistrareUtilizatori";
            this.Text = "InregistrareUtilizatori";
            this.Load += new System.EventHandler(this.InregistrareUtilizatori_Load);
            this.Utilizatori.ResumeLayout(false);
            this.Utilizatori.PerformLayout();
            this.UtilizatoriInregistrati.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sistemScolarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUtilizatoriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Utilizatori;
        private System.Windows.Forms.GroupBox UtilizatoriInregistrati;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_ConfParola;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txt_Pozitia;
        private System.Windows.Forms.TextBox txt_Nume;
        private System.Windows.Forms.Label Pozitia;
        private System.Windows.Forms.Label ConfParola;
        private System.Windows.Forms.Label Parola;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.Button btnInreg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnResetare;
        private SistemScolarDataSet sistemScolarDataSet;
        private System.Windows.Forms.BindingSource tblUtilizatoriBindingSource;
        private SistemScolarDataSetTableAdapters.tblUtilizatoriTableAdapter tblUtilizatoriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilizatoriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeUtilizatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozitiaDataGridViewTextBoxColumn;
    }
}