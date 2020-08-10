using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows;


namespace SistemScolardeInregistrare
{
    public partial class FrmStudenti : MaterialSkin.Controls.MaterialForm
    {
        
        SqlDataAdapter dataAdapter;
        //stocheaza tabelul din SqlServer(Judet) intr-un obiect
        DataTable dt;
        private SqlCommand cmd;
        Connect conn = new Connect();



        public FrmStudenti()
        {
            InitializeComponent();
            AfisareJudetelsd();
            AfisareSpecializare();
            //  AfisareMunincipiilsd();
            // AfisareOraslsd();
            btnActualizare.Enabled = false;
            btnStergere.Enabled = false;
           

        }

        //lsd=lista derulanta
        public void AfisareJudetelsd()
        {
            dataAdapter = new SqlDataAdapter("select * from Judet", conn.Openconnection());
            dt = new DataTable();
            dataAdapter.Fill(dt);
            cmbJudet.DataSource = dt;
            cmbJudet.DisplayMember = "numeJudet";
            cmbJudet.ValueMember = "judetID";

            conn.Closeconnection();
        }
        //Merge daca vrei sa afiseze Munincipiile si orasele in ordinea trecuta in tabel
        /*
        public void AfisareMunincipiilsd()
        {
            dataAdapter = new SqlDataAdapter("select * from Munincipiu", conn.Openconnection());
            dt = new DataTable();
            dataAdapter.Fill(dt);
            cmbMunincipiu.DataSource = dt;
            cmbMunincipiu.DisplayMember = "numeMunincipiu";
            cmbMunincipiu.ValueMember = "judetID";

        }
        
        public void AfisareOraslsd()
        {
            dataAdapter = new SqlDataAdapter("select * from Oras", conn.Openconnection());
            dt = new DataTable();
            dataAdapter.Fill(dt);
            cmbOras.DataSource = dt;
            cmbOras.DisplayMember = "numeOras";
            cmbOras.ValueMember = "oradID";
             

        } */

            



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        // Afisare si conectare lsd Oras si Munincipiu, utilizand cheia primara si cheia secundara care creaza relatiile dintre tabele si care sunt identice cu indexurile lsd

        private void cmbJudet_SelectedIndexChanged(object sender, EventArgs e)
        {
            //stocheaza o valoare de tip intreg
            int value;
            try
            {
                int.TryParse(cmbJudet.SelectedValue.ToString(), out value);
                dataAdapter = new SqlDataAdapter("select * from Munincipiu where judetID='" + value + "'", conn.Openconnection());
                dt = new DataTable();
                dataAdapter.Fill(dt);
                cmbMunincipiu.DataSource = dt;
                cmbMunincipiu.DisplayMember = "numeMunincipiu";
                cmbMunincipiu.ValueMember = "munincipiuID";

                
            }

            catch(Exception)
            {

            }
            conn.Closeconnection();
        }

        private void cmbMunincipiu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cand afisezi munincipiu sa apara automat orasele aferente
            int value;
            try
            {
                int.TryParse(cmbMunincipiu.SelectedValue.ToString(), out value);
                dataAdapter = new SqlDataAdapter("select * from Oras where munincipiuID='" + value + "'", conn.Openconnection());
                dt = new DataTable();
                dataAdapter.Fill(dt);
                cmbOras.DataSource = dt;
                cmbOras.DisplayMember = "numeOras";
                cmbOras.ValueMember = "oradID";

                
            }

            catch (Exception)
            {

            }
            conn.Closeconnection();
        }

        public void AfisareSpecializare()
        {
            try
            {

                dataAdapter = new SqlDataAdapter("select * from Specializare", conn.Openconnection());
                dt = new DataTable();
                dataAdapter.Fill(dt);
                cmbSpecializare.DataSource = dt;
                cmbSpecializare.DisplayMember = "numeSpecializare";
                cmbSpecializare.ValueMember = "specializareID";

               
            }
            catch(Exception)
            {

            }
            conn.Closeconnection();
        }


        private void rdMasculin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAdugare_Click(object sender, EventArgs e)
        {
            cmbSpecializare.Text ="";
            txtNume.Clear();
            txtPrenume.Clear();
            txtAdresa.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            cmbJudet.Text = "";
            cmbMunincipiu.Text = "";
            cmbOras.Text = "";
        }

        private void btnSalvare_Click_1(object sender, EventArgs e)
        {
            
            int specializareID = Convert.ToInt32(cmbSpecializare.SelectedValue);
            int judetID = Convert.ToInt32(cmbJudet.SelectedValue);
            int munincipiuID = Convert.ToInt32(cmbMunincipiu.SelectedValue);
            int oradID = Convert.ToInt32(cmbOras.SelectedValue);

            try
            {
                string sex = "Feminin";

                if (rdMasculin.Checked)
                {
                    sex = "Masculin";

                }
                if (txtNume.Text != "" && txtPrenume.Text != "" && txtAdresa.Text != ""
                    && txtTelefon.Text != "" && txtEmail.Text != "" && cmbJudet.Text != ""
                    && cmbMunincipiu.Text != "" && cmbOras.Text != "")
                {
                    cmd = new SqlCommand("insert into Studenti values('" + sex + "', '" + txtNume.Text + "' , '" + txtPrenume.Text
                        + "' , '" + txtAdresa.Text + "' , '" + txtTelefon.Text + "' , '" + txtEmail.Text + "' , '"
                        + dtDataNasterii.Text + "' , '" + dtDataInregistrarii.Text + "' , '" + specializareID + "' , '"
                        + judetID + "' , '" + munincipiuID + "' , '" + oradID + "') ", conn.Openconnection());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost salvate cu succes");

                }
                else
                {
                    MessageBox.Show("Va rog completati toate campurile");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Closeconnection();

        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            FrmAfisareStudenti studenti = new FrmAfisareStudenti();
            studenti.Show();
            Hide();
            
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
                string sex = "";

                if (rdMasculin.Checked)
                {
                    sex = "Masculin";

                }
                else
                {
                    sex = "Feminin";
                }
            try {
                //in sql DN si DI sunt de tip varchar
                string DN = dtDataNasterii.Value.ToString("MM-dd-yyyy");
                string DI = dtDataInregistrarii.Value.ToString("MM-dd-yyyy");
                int specializareID = Convert.ToInt32(cmbSpecializare.SelectedValue);
                int judetID = Convert.ToInt32(cmbJudet.SelectedValue);
                int munincipiuID = Convert.ToInt32(cmbMunincipiu.SelectedValue);
                int oradID = Convert.ToInt32(cmbOras.SelectedValue);

                if (txtNume.Text != "" && txtPrenume.Text != "" && txtAdresa.Text != ""
                    && txtTelefon.Text != "" && txtEmail.Text != "" && cmbJudet.Text != ""
                    && cmbMunincipiu.Text != "" && cmbOras.Text != "")
                {
                    cmd = new SqlCommand("update Studenti set sex='" + sex + "',nume='" + txtNume.Text +
                        "',prenume='" + txtPrenume.Text + "',adresa='" + txtAdresa.Text + "',telefon='" + txtTelefon.Text + "',email='" + txtEmail.Text +
                        "',dataNasterii='" + DN + "', dataInregistrarii='" + DI + "',specilaizareID='" + specializareID + "',judetID'" +
                        judetID + "', munincipiuID='" + munincipiuID + "', oradID='" + oradID +
                        "' where studentiID='" + FrmAfisareStudenti.studentiID + "'", conn.Openconnection());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost actualizate cu succes!");

                }
                else
                {
                    MessageBox.Show("Va rog completati toate campurile!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Closeconnection();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            try
            {
                string sex = "Feminin";

                if (rdMasculin.Checked)
                {
                    sex = "Masculin";

                }
                if (txtNume.Text != "" && txtPrenume.Text != "" && txtAdresa.Text != ""
                    && txtTelefon.Text != "" && txtEmail.Text != "" && cmbJudet.Text != ""
                    && cmbMunincipiu.Text != "" && cmbOras.Text != "")
                {
                    cmd = new SqlCommand("delete from Studenti where studentiID= '" + FrmAfisareStudenti.studentiID + "'", conn.Openconnection());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost sterse cu succes!");

                }
                else
                {
                    MessageBox.Show("Va rog completati toate campurile!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Closeconnection();
        }

        private void dtDataNasterii_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}
