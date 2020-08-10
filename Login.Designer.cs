namespace SistemScolardeInregistrare
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Utilizator = new System.Windows.Forms.Label();
            this.Parola = new System.Windows.Forms.Label();
            this.txt_Utilizator = new System.Windows.Forms.TextBox();
            this.txt_Parola = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.check);
            this.groupBox1.Controls.Add(this.btnlogin);
            this.groupBox1.Controls.Add(this.txt_Parola);
            this.groupBox1.Controls.Add(this.txt_Utilizator);
            this.groupBox1.Controls.Add(this.Parola);
            this.groupBox1.Controls.Add(this.Utilizator);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(47, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 513);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // Utilizator
            // 
            this.Utilizator.AutoSize = true;
            this.Utilizator.Location = new System.Drawing.Point(33, 113);
            this.Utilizator.Name = "Utilizator";
            this.Utilizator.Size = new System.Drawing.Size(71, 20);
            this.Utilizator.TabIndex = 0;
            this.Utilizator.Text = "Utilizator";
            // 
            // Parola
            // 
            this.Parola.AutoSize = true;
            this.Parola.Location = new System.Drawing.Point(33, 195);
            this.Parola.Name = "Parola";
            this.Parola.Size = new System.Drawing.Size(54, 20);
            this.Parola.TabIndex = 1;
            this.Parola.Text = "Parola";
            // 
            // txt_Utilizator
            // 
            this.txt_Utilizator.Location = new System.Drawing.Point(148, 107);
            this.txt_Utilizator.Name = "txt_Utilizator";
            this.txt_Utilizator.Size = new System.Drawing.Size(100, 26);
            this.txt_Utilizator.TabIndex = 2;
            // 
            // txt_Parola
            // 
            this.txt_Parola.Location = new System.Drawing.Point(148, 192);
            this.txt_Parola.Name = "txt_Parola";
            this.txt_Parola.Size = new System.Drawing.Size(100, 26);
            this.txt_Parola.TabIndex = 3;
            this.txt_Parola.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(251, 297);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(175, 75);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = true;
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(322, 209);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(123, 24);
            this.check.TabIndex = 5;
            this.check.Text = "Arata Parola";
            this.check.UseVisualStyleBackColor = true;
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Parola;
        private System.Windows.Forms.TextBox txt_Utilizator;
        private System.Windows.Forms.Label Parola;
        private System.Windows.Forms.Label Utilizator;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.CheckBox check;
    }
}