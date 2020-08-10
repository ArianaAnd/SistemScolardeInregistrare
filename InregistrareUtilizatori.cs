using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemScolardeInregistrare
{
    public partial class InregistrareUtilizatori : MaterialSkin.Controls.MaterialForm
    {
        //Variabila tip clasa
        private Utilizator objutilizator;
        private static int UtilizatorID;
        public InregistrareUtilizatori()
        {
            InitializeComponent();
        }

        //Parola trebuie sa contina minumum 8 caractere
        //Parola trebuie sa contina cel putin o litera mare, mica si un numar

            private bool ValidareDateIntrare()
        {
            const int lungimeMinimaParola = 8;
             
            if(txt_Nume.Text.Length == 0)
            {
                MessageBox.Show("Introdu numele de utilizator" , "Eroare date intrare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Nume.Focus();

                return false;
            }

            if (txtParola.Text.Length == 0)
            {
                MessageBox.Show("Introdu parola", "Eroare date intrare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtParola.Focus();

                return false;
            }
            else
            {
                if(txtParola.Text.Length < lungimeMinimaParola || 
                    //verificam daca parola contine litere mari
                    VerificareCaractereMari(txtParola.Text) < 1|| 
                    //verificam daca parola contine litere mici
                    verificareCaractereMici(txtParola.Text) < 1 ||
                    //verificam daca parola contine numere
                    VerificareNumere(txtParola.Text) < 1)
                {
                    MessageBox.Show("Te rugam sa introduci o parola valida.\n" + "Parola trebuie sa contina o litera mare, o litera mica si un numar", "Eroare date de intrare",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtParola.Focus();

                    return false;

                }

            }

            if(txtParola.Text != txt_ConfParola.Text)
            {
                MessageBox.Show("Parolele introduse nu sunt identice", "Eroare date de intrare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtParola.Focus();


                return false;
            }

            if(txt_ConfParola.Text.Length == 0)
            {
                MessageBox.Show("Completeaza spatiile lipsa", "Eroare date de intrare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ConfParola.Focus();

                return false;
            }
            if(txt_Pozitia.Text.Length == 0)
            {
                MessageBox.Show("Completeaza spatiile lipsa", "Eroare date de intrare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Pozitia.Focus();
                return false;
            }


            return true;
       
           
        }

        private int VerificareNumere(string parola)
        {
            //Variabila care va soca numarul
            int numere = 0;
            //Numara cifrele din parola
            foreach(char ch in parola)
            {
                //Gaseste fiecare numar cautat
                if(char.IsNumber(ch))
                {
                    //Increenteaza numarul
                    numere++;

                }
             
            }
            return numere;

        }

        private int verificareCaractereMici(string parola)
        {
            //Variabila care va soca numarul
            int numereCaractereMici = 0;
            //Numara cifrele din parola
            foreach (char ch in parola)
            {
                //Gaseste fiecare numar cautat
                if (char.IsLower(ch))
                {
                    //Increenteaza numarul
                    numereCaractereMici++;

                }
               
            }
            return numereCaractereMici;
        }

        private int VerificareCaractereMari(string parola)
        {
            //Variabila care va soca numarul
            int numereCaractereMari = 0;
            //Numara cifrele din parola
            foreach (char ch in parola)
            {
                //Gaseste fiecare numar cautat
                if (char.IsUpper(ch))
                {
                    //Increenteaza numarul
                    numereCaractereMari++;

                }
                
            }
            return numereCaractereMari;
        }

        private void CurataControale()
        {
            txtParola.Clear();
            txt_ConfParola.Clear();
            txt_Nume.Clear();
            txt_Pozitia.Clear();
        }

        private void UtilizatoriInregistrati_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DateUtilizator();
            if (ValidareDateIntrare())
            {


                objutilizator.Adauga();
                
            }

            // TODO: This line of code loads data into the 'sistemScolarDataSet.tblUtilizatori' table. You can move, or remove it, as needed.
            this.tblUtilizatoriTableAdapter.Fill(this.sistemScolarDataSet.tblUtilizatori);
            CurataControale();
        }

        private void DateUtilizator()
        {
            objutilizator = new Utilizator();
            objutilizator.NumeUtilizator = txt_Nume.Text;
            objutilizator.Parola = txtParola.Text;
            objutilizator.Pozitie = txt_Pozitia.Text;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InregistrareUtilizatori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemScolarDataSet.tblUtilizatori' table. You can move, or remove it, as needed.
            this.tblUtilizatoriTableAdapter.Fill(this.sistemScolarDataSet.tblUtilizatori);

        }

        private void btnResetare_Click(object sender, EventArgs e)
        {
            CurataControale();
            txt_Nume.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection celule = dataGridView1.CurrentRow.Cells;
            //UtilizatorID = Convert.ToInt32(celule[0].Value.ToString());
            txt_Nume.Text = celule[1].Value.ToString();

            txtParola.Text =celule[2].Value.ToString();
            txt_ConfParola.Text = celule[2].Value.ToString();
            txt_Pozitia.Text = celule[3].Value.ToString();
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            this.DateUtilizator();
            if (ValidareDateIntrare())
            {


                objutilizator.Actualizeaza(UtilizatorID);

            }

            // TODO: This line of code loads data into the 'sistemScolarDataSet.tblUtilizatori' table. You can move, or remove it, as needed.
            this.tblUtilizatoriTableAdapter.Fill(this.sistemScolarDataSet.tblUtilizatori);
            CurataControale();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            this.DateUtilizator();
            if (ValidareDateIntrare())
            {


                objutilizator.Sterge(UtilizatorID);

            }

            // TODO: This line of code loads data into the 'sistemScolarDataSet.tblUtilizatori' table. You can move, or remove it, as needed.
            this.tblUtilizatoriTableAdapter.Fill(this.sistemScolarDataSet.tblUtilizatori);
            CurataControale();
        }

        private void txtParola_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtParola_Enter(object sender, EventArgs e)
        {
            txtParola.Text = "";

            txtParola.ForeColor = Color.Black;

            txtParola.UseSystemPasswordChar = true;
        }
    }
}
