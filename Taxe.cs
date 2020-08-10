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
    public partial class Taxe : MaterialSkin.Controls.MaterialForm
    {
        SqlDataAdapter dataAdapter;
        DataTable dt;
        SqlCommand cmd;
        Connect conn = new Connect();
        public Taxe()
        {
            InitializeComponent();
            Nume();
            Prenume();
            Specializare();
            Luna();

        }

        public void Nume()
        {
            dataAdapter = new SqlDataAdapter("select * from Studenti", conn.Openconnection());
            dt = new DataTable();
            dataAdapter.Fill(dt);
            cmb_t_Nume.DataSource = dt;
            cmb_t_Nume.DisplayMember = "nume";
            cmb_t_Nume.ValueMember = "studentiID";


            conn.Closeconnection();
        }

        public void Prenume()
        {
            dataAdapter = new SqlDataAdapter("select * from Studenti", conn.Openconnection());
            dt = new DataTable();
            dataAdapter.Fill(dt);
            cmb_t_Prenume.DataSource = dt;
            cmb_t_Prenume.DisplayMember = "prenume";
            cmb_t_Prenume.ValueMember = "studentiID";

            conn.Closeconnection();
        }
        public void Specializare()
        {
            dataAdapter = new SqlDataAdapter("select * from Specializare", conn.Openconnection());
            dt = new DataTable();
            dataAdapter.Fill(dt);
            cmb_t_Specializare.DataSource = dt;
            cmb_t_Specializare.DisplayMember = "numeSpecializare";
            cmb_t_Specializare.ValueMember = "specializareID";

            conn.Closeconnection();
        }

        public void Luna()
        {
            dataAdapter = new SqlDataAdapter("select * from Luna", conn.Openconnection());
            dt = new DataTable();
            dataAdapter.Fill(dt);
            cmb_t_Luna.DataSource = dt;
            cmb_t_Luna.DisplayMember = "Luna";
            cmb_t_Luna.ValueMember = "LunaID";

            conn.Closeconnection();
        }
        private void dt_t_DataInregistrarii_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_t_Specializare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_t_Nume_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_t_Luna_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void btnAdugare_Click(object sender, EventArgs e)
        {
            cmb_t_Specializare.Text = "";
            cmb_t_Nume.Text = "";
            cmb_t_Prenume.Text = "";
            cmb_t_Luna.Text = "";
            cmb_t_Luna.Text = "";
            txt_t_Suma.Clear();
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            string DA = dt_t_DataAdmiterii.Value.ToString("MM-dd-yyyy");
            int specializareID = Convert.ToInt32(cmb_t_Specializare.SelectedValue.ToString());
            int NumeID = Convert.ToInt32(cmb_t_Nume.SelectedValue.ToString());
            int PrenumeID = Convert.ToInt32(cmb_t_Prenume.SelectedValue.ToString());
            int LunaID = Convert.ToInt32(cmb_t_Luna.SelectedValue.ToString());

           
                if (cmb_t_Specializare.Text != "" && cmb_t_Nume.Text != "" && cmb_t_Prenume.Text != ""
                        && cmb_t_Luna.Text != "" && txt_t_Suma.Text != "")
                {
                    cmd = new SqlCommand("insert into Taxa values ('" + specializareID + "','" + NumeID + "','" + PrenumeID + "','" +
                        "'" + DA + "','" + LunaID + "','" + txt_t_Suma.Text + "')", conn.Openconnection());
                    MessageBox.Show("Datele au fost salvate cu succes");
                }

                else
                {
                    MessageBox.Show("Completeaza spatiile goale!");
                }
          
            conn.Closeconnection();
            
                {

            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (cmb_t_Specializare.Text != "" && cmb_t_Nume.Text != "" && cmb_t_Prenume.Text != ""
                      && cmb_t_Luna.Text != "" && txt_t_Suma.Text != "")
            {
                cmd = new SqlCommand("delete from Taxa where taxaID = '" + FrmAfisareStudenti.studentiID + "'", conn.Openconnection());
                MessageBox.Show("Datele au fost salvate cu succes");
            }

            else
            {
                MessageBox.Show("Completeaza spatiile goale!");
            }
        }
    }
    }

