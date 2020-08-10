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
    public partial class FrmProfesori : MaterialSkin.Controls.MaterialForm
    {

        SqlDataAdapter dataAdapter;
        //stocheaza tabelul din SqlServer(Judet) intr-un obiect
        DataTable dt;
        private SqlCommand cmd;
        Connect conn = new Connect();
        private static string profesoiID;

        public FrmProfesori()
        {
            InitializeComponent();
            AfisareJudete();
            Experinta();
            //  AfisareMunincipiilsd();
            // AfisareOraslsd();
            
    

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void AfisareJudete()
        {
            dataAdapter = new SqlDataAdapter("select * from Judet", conn.Openconnection());
            dt = new DataTable();
            dataAdapter.Fill(dt);
            cmb_pr_Judet.DataSource = dt;
            cmb_pr_Judet.DisplayMember = "numeJudet";
            cmb_pr_Judet.ValueMember = "judetID";

            conn.Closeconnection();
        }

        private void cmbMunincipiu_SelectedIndexChanged(object sender, EventArgs e)
        {       //cand afisezi munincipiu sa apara automat orasele aferente
                int value;
                try
                {
                    int.TryParse(cmb_pr_Munincipiu.SelectedValue.ToString(), out value);
                    dataAdapter = new SqlDataAdapter("select * from Oras where munincipiuID='" + value + "'", conn.Openconnection());
                    dt = new DataTable();
                    dataAdapter.Fill(dt);
                    cmb_pr_Oras.DataSource = dt;
                    cmb_pr_Oras.DisplayMember = "numeOras";
                    cmb_pr_Oras.ValueMember = "oradID";


                }

                catch (Exception)
                {

                }
                conn.Closeconnection();
            }

        private void cmb_pr_Oras_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value;
            try
            {
                int.TryParse(cmb_pr_Judet.SelectedValue.ToString(), out value);
                dataAdapter = new SqlDataAdapter("select * from Munincipiu where orasID='" + value + "'", conn.Openconnection());
                dt = new DataTable();
                dataAdapter.Fill(dt);
                cmb_pr_Munincipiu.DataSource = dt;
                cmb_pr_Munincipiu.DisplayMember = "numeMunincipiu";
                cmb_pr_Munincipiu.ValueMember = "munincipiuID";


            }

            catch (Exception)
            {

            }
            conn.Closeconnection();
        }

        private void cmb_pr_Judet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value;
            try
            {
                int.TryParse(cmb_pr_Judet.SelectedValue.ToString(), out value);
                dataAdapter = new SqlDataAdapter("select * from Munincipiu where judetID='" + value + "'", conn.Openconnection());
                dt = new DataTable();
                dataAdapter.Fill(dt);
                cmb_pr_Munincipiu.DataSource = dt;
                cmb_pr_Munincipiu.DisplayMember = "numeMunincipiu";
                cmb_pr_Munincipiu.ValueMember = "munincipiuID";


            }

            catch (Exception)
            {

            }
            conn.Closeconnection();
        }

        private void Experinta()
        {
            dataAdapter = new SqlDataAdapter("select * from Experienta", conn.Openconnection());
            dt = new DataTable();
            dataAdapter.Fill(dt);
            cmbExperienta.DataSource = dt;
            cmbExperienta.DisplayMember = "experienta";
            cmbExperienta.ValueMember = "experientaID";

            conn.Closeconnection();

        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            int experientaID = Convert.ToInt32(cmbExperienta.SelectedValue.ToString());
            int judetID = Convert.ToInt32(cmb_pr_Judet.SelectedValue.ToString());
            int munincipiuID = Convert.ToInt32(cmb_pr_Munincipiu.SelectedValue.ToString());
            int oradID = Convert.ToInt32(cmb_pr_Oras.SelectedValue.ToString());

            try
            {
                string sex = "Feminin";

                if (rd_pr_Masculin.Checked)
                {
                    sex = "Masculin";

                }
                if (txt_pr_Nume.Text != "" && txt_pr_Prenume.Text != "" && txt_pr_Adresa.Text != ""
                    && txt_pr_Telefon.Text != "" && txt_pr_Email.Text != "" && cmb_pr_Judet.Text != ""
                    && cmb_pr_Munincipiu.Text != "" && cmb_pr_Oras.Text != "")
                {
                    cmd = new SqlCommand("insert into Profesori values('"+txt_pr_Nume.Text+"','" + txt_pr_Prenume.Text+"','" + txt_pr_Adresa.Text +
                        "','" + txt_pr_Telefon.Text + "','" + txt_pr_Email.Text + "','"+sex +"','" + dt_pr_DataNasterii.Text+"','"+ experientaID + "','"+ judetID +
                        "','" + munincipiuID + "','" + oradID+"')", conn.Openconnection());
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

        private void btnAdugare_Click(object sender, EventArgs e)
        {
            cmbExperienta.Text = "";
            txt_pr_Nume.Clear();
            txt_pr_Prenume.Clear();
            txt_pr_Adresa.Clear();
            txt_pr_Telefon.Clear();
            txt_pr_Email.Clear();
            cmb_pr_Judet.Text = "";
            cmb_pr_Munincipiu.Text = "";
            cmb_pr_Oras.Text = "";
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            AfisareDateProfesori afProf = new AfisareDateProfesori();
            afProf.Show();
            Hide();
            
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            
            string Sex = "";

            if (rd_pr_Masculin.Checked)
            {
                Sex = "Masculin";

            }
            else
            {
                Sex = "Feminin";
            }
            try
            {
                //in sql DN si DI sunt de tip varchar
                string DN = dt_pr_DataNasterii.Value.ToString("MM-dd-yyyy");
                int experientaID = Convert.ToInt32(cmbExperienta.SelectedValue);
                int judetID = Convert.ToInt32(cmb_pr_Judet.SelectedValue);
                int munincipiuID = Convert.ToInt32(cmb_pr_Munincipiu.SelectedValue);
                int oradID = Convert.ToInt32(cmb_pr_Oras.SelectedValue);

                if (txt_pr_Nume.Text != "" && txt_pr_Prenume.Text != "" && txt_pr_Adresa.Text != ""
                    && txt_pr_Telefon.Text != "" && txt_pr_Email.Text != "" && cmb_pr_Judet.Text != ""
                    && cmb_pr_Munincipiu.Text != "" && cmb_pr_Oras.Text != "")
                {
                    cmd = new SqlCommand("update Profesori set Nume='" + txt_pr_Nume.Text + "',Prenume'" + txt_pr_Prenume.Text +
                        "', Adresa'" + txt_pr_Adresa.Text + "', Telefon'" + txt_pr_Telefon.Text + "', Email'" + txt_pr_Email.Text +
                        "', Sex='" + Sex + "', DataNasterii'" + DN + "', Experienta'" + experientaID + "', Judet'" + cmb_pr_Judet +
                        "', Munincipiu'" + cmb_pr_Munincipiu + "', Oras'" + oradID + "' where ProfesoiID='" + FrmProfesori.profesoiID + "'", conn.Openconnection());
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
                string Sex = "Feminin";

                if (rd_pr_Masculin.Checked)
                {
                    Sex = "Masculin";

                }
                if (txt_pr_Nume.Text != "" && txt_pr_Prenume.Text != "" && txt_pr_Adresa.Text != ""
                    && txt_pr_Telefon.Text != "" && txt_pr_Email.Text != "" && cmb_pr_Judet.Text != ""
                    && cmb_pr_Munincipiu.Text != "" && cmb_pr_Oras.Text != "")
                {
                    cmd = new SqlCommand("delete from Profesori where profesoiID= '" + FrmProfesori.profesoiID + "'", conn.Openconnection());
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
    }
    }

