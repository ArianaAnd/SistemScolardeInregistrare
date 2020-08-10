using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemScolardeInregistrare
{
    public partial class FrmAfisareStudenti : MaterialSkin.Controls.MaterialForm
    {
        Connect conn = new Connect();
        SqlDataAdapter dataAdapter;
        DataTable dt;
        private SqlCommand cmd;

        public static int studentiID;

        public FrmAfisareStudenti()
        {
            InitializeComponent();
        }

        private void FrmAfisareStudenti_Load(object sender, EventArgs e)
        {

            dataAdapter = new SqlDataAdapter("select Studenti.studentiID, Studenti.nume, Studenti.prenume, Studenti.sex, " +
                                            "Studenti.telefon, Studenti.adresa, Studenti.email, Studenti.dataInregistrarii, Studenti.dataNasterii, " +
                                            "Specializare.numeSpecializare, Judet.numeJudet, Munincipiu.numeMunincipiu, Oras.numeOras from Studenti " +
                                            "inner join Specializare on Studenti.specializareID = Specializare.specializareID inner join Judet on " +
                                            "Studenti.judetID = Judet.judetID inner join Munincipiu on " +
                                            "Studenti.munincipiuID = Munincipiu.munincipiuID inner join Oras on " +
                                            "Studenti.oradID = Oras.oradID", conn.Openconnection());



            //DataTable preia tot ce am scris mai sus
            dt = new DataTable();
                dataAdapter.Fill(dt);
                GDAfisareStudenti.DataSource = dt;
            
      

            conn.Closeconnection();
        }

        private void GDAfisareStudenti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmStudenti loadStudentData = new FrmStudenti();
            studentiID = Convert.ToInt32(GDAfisareStudenti.Rows[e.RowIndex].Cells[0].Value.ToString());
            loadStudentData.txtNume.Text = (GDAfisareStudenti.Rows[e.RowIndex].Cells[1].Value.ToString());
            loadStudentData.txtPrenume.Text = (GDAfisareStudenti.Rows[e.RowIndex].Cells[2].Value.ToString());
            loadStudentData.rdMasculin.Checked = true;
            loadStudentData.rdFeminin.Checked = false;

            if (GDAfisareStudenti.Rows[e.RowIndex].Cells[3].Value.ToString() == "Feminin")
            {
                loadStudentData.rdMasculin.Checked = false;
                loadStudentData.rdFeminin.Checked = true;
            }

            loadStudentData.txtAdresa.Text = (GDAfisareStudenti.Rows[e.RowIndex].Cells[4].Value.ToString());
            loadStudentData.txtTelefon.Text = (GDAfisareStudenti.Rows[e.RowIndex].Cells[5].Value.ToString());
            loadStudentData.txtEmail.Text = (GDAfisareStudenti.Rows[e.RowIndex].Cells[6].Value.ToString());
            loadStudentData.dtDataInregistrarii.Text = (GDAfisareStudenti.Rows[e.RowIndex].Cells[7].Value.ToString());
            loadStudentData.dtDataNasterii.Text = (GDAfisareStudenti.Rows[e.RowIndex].Cells[8].Value.ToString());
            loadStudentData.cmbSpecializare.Text = (GDAfisareStudenti.Rows[e.RowIndex].Cells[9].Value.ToString());
            loadStudentData.cmbJudet.Text = (GDAfisareStudenti.Rows[e.RowIndex].Cells[10].Value.ToString());
            loadStudentData.cmbMunincipiu.Text = (GDAfisareStudenti.Rows[e.RowIndex].Cells[11].Value.ToString());
            loadStudentData.cmbOras.Text = (GDAfisareStudenti.Rows[e.RowIndex].Cells[12].Value.ToString());

            loadStudentData.Show();
            loadStudentData.btnActualizare.Enabled = true;
            loadStudentData.btnStergere.Enabled = true;
        }

        public void CautarePrenume(string prenume)
        {
            string cautare = "select * from Studenti where Prenume like '%" + prenume + "%'";
            cmd = new SqlCommand(cautare, conn.Openconnection());
            dataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            GDAfisareStudenti.DataSource = dt;
        }
        public void CautareNume(string nume)
        {
            string cautare = "select * from Studenti where Nume like '%" + nume + "%'";
            cmd = new SqlCommand(cautare, conn.Openconnection());
            dataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            GDAfisareStudenti.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

  
        private void txtCautareNume_TextChanged(object sender, EventArgs e)
        {
            CautarePrenume(txtCautarePrenume.Text);
        }

        private void txtCautareNume_TextChanged_1(object sender, EventArgs e)
        {
            CautareNume(txtCautareNume.Text);
        }

        private void GDAfisareStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
