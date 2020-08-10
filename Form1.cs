using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemScolardeInregistrare
{
    public partial class FrmSistemScolarInregistrare : MaterialSkin.Controls.MaterialForm
    {
        public FrmSistemScolarInregistrare()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmProfesori profesori = new FrmProfesori();

            profesori.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnStudenti_Click(object sender, EventArgs e)
        {
            FrmStudenti studenti = new FrmStudenti();

            studenti.Show();
        }

        private void btnTaxa_Click(object sender, EventArgs e)
        {
            Taxe taxa = new Taxe();
            taxa.Show();
        }

        private void btnRapoarte_Click(object sender, EventArgs e)
        {
            Rapoarte raport = new Rapoarte();
            raport.Visible = true;
            raport.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            InregistrareUtilizatori objinregistrareUtilizatori = new InregistrareUtilizatori();
            objinregistrareUtilizatori.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void FrmSistemScolarInregistrare_Load(object sender, EventArgs e)
        {

        }
    }
}
