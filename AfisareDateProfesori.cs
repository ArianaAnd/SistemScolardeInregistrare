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
    public partial class AfisareDateProfesori : MaterialSkin.Controls.MaterialForm
    {
        Connect conn = new Connect();
        SqlDataAdapter dataAdapter;
        DataTable dt;
        SqlCommand cmd;

        public static int profesoiID;
        

        public AfisareDateProfesori()
        {
            InitializeComponent();
           
        }

        private void GDAfisareProfesori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void AfisareDateProfesori_Load(object sender, EventArgs e)
        {

            dataAdapter = new SqlDataAdapter("select Profesori.profesoiID, Profesori.Nume, Profesori.Prenume, Profesori.Sex, " +
                                          "Profesori.Telefon, Profesori.Adresa, Profesori.Email, Profesori.DataNasterii, " +
                                          "Experienta.experientaID, Judet.numeJudet, Munincipiu.numeMunincipiu, Oras.numeOras from Profesori " +
                                          "inner join Experienta on Profesori.experientaID = Experienta.experientaID inner join Judet on " +
                                          "Profesori.judetID = Judet.judetID inner join Munincipiu on " +
                                          "Profesori.munincipiuID = Munincipiu.munincipiuID inner join Oras on " +
                                          "Profesori.oradID = Oras.oradID", conn.Openconnection());



            //DataTable preia tot ce am scris mai sus
            dt = new DataTable();
            dataAdapter.Fill(dt);
            GDAfisareProfesori.DataSource = dt;




            conn.Closeconnection();
        }

        private void GDAfisareProfesori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmProfesori loadProfesorData = new FrmProfesori();
            profesoiID = Convert.ToInt32(GDAfisareProfesori.Rows[e.RowIndex].Cells[0].Value.ToString());
            loadProfesorData.txt_pr_Nume.Text = (GDAfisareProfesori.Rows[e.RowIndex].Cells[1].Value.ToString());
            loadProfesorData.txt_pr_Prenume.Text = (GDAfisareProfesori.Rows[e.RowIndex].Cells[2].Value.ToString());
            loadProfesorData.rd_pr_Masculin.Checked = true;
            loadProfesorData.rd_pr_Feminin.Checked = false;

            if (GDAfisareProfesori.Rows[e.RowIndex].Cells[3].Value.ToString() == "Feminin")
            {
                loadProfesorData.rd_pr_Masculin.Checked = false;
                loadProfesorData.rd_pr_Feminin.Checked = true;
            }

            loadProfesorData.txt_pr_Adresa.Text = (GDAfisareProfesori.Rows[e.RowIndex].Cells[4].Value.ToString());
            loadProfesorData.txt_pr_Telefon.Text = (GDAfisareProfesori.Rows[e.RowIndex].Cells[5].Value.ToString());
            loadProfesorData.txt_pr_Email.Text = (GDAfisareProfesori.Rows[e.RowIndex].Cells[6].Value.ToString());
            loadProfesorData.dt_pr_DataNasterii.Text = (GDAfisareProfesori.Rows[e.RowIndex].Cells[7].Value.ToString());
            loadProfesorData.cmbExperienta.Text = (GDAfisareProfesori.Rows[e.RowIndex].Cells[8].Value.ToString());
            loadProfesorData.cmb_pr_Judet.Text = (GDAfisareProfesori.Rows[e.RowIndex].Cells[9].Value.ToString());
            loadProfesorData.cmb_pr_Munincipiu.Text = (GDAfisareProfesori.Rows[e.RowIndex].Cells[10].Value.ToString());
            loadProfesorData.cmb_pr_Oras.Text = (GDAfisareProfesori.Rows[e.RowIndex].Cells[11].Value.ToString());

            loadProfesorData.Show();
            loadProfesorData.btnActualizare.Enabled = true;
            loadProfesorData.btnStergere.Enabled = true;


        }

        public void CautarePrenumeProf(string Prenume)
        {
            string cautare = "select * from Profesori where Prenume like '%" + Prenume + "%'";
            cmd = new SqlCommand(cautare, conn.Openconnection());
            dataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            GDAfisareProfesori.DataSource = dt;
        }
        public void CautareNumeProf(string Nume)
        {
            string cautare = "select * from Profesori where Nume like '%" + Nume + "%'";
            cmd = new SqlCommand(cautare, conn.Openconnection());
            dataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dataAdapter.Fill(dt);
            GDAfisareProfesori.DataSource = dt;
        }

        private void txt_pr_CautarePrenume_TextChanged(object sender, EventArgs e)
        {
            CautarePrenumeProf(txt_pr_CautarePrenume.Text);
        }

        private void txt_pr_CautareNume_TextChanged(object sender, EventArgs e)
        {
            CautareNumeProf(txt_pr_CautareNume.Text);
        }
    }
    }

