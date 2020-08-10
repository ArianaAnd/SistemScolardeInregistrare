using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace SistemScolardeInregistrare
{
    public class Utilizator
    {

        SqlDataAdapter adapter;
       System.Data.DataSet ds;
        //Campuri Membre
        private string numeUtilizator;
        private string parola;
        private string pozitie;


        

        //Constructor implicit
        public Utilizator()
        {

        }
        public string NumeUtilizator
        {
            get { return numeUtilizator; }
            set { numeUtilizator = value; }
        }

        public string Parola
        {
            get { return parola; }
            set { parola = value; }
        }

        public string Pozitie
        {
            get { return pozitie; }
            set { pozitie = value; }
        }

        public object UtilizatorID { get; private set; }

        //Metoda care adauga utilizatorii in baza de date
        public void Adauga()
        {
            //Sirul de conectare
            string connect = ConfigurationManager.ConnectionStrings["SistemScolarConnectionString"].ConnectionString;

            //Creare obiect pentru conectare
            SqlConnection obSqlConectare = new SqlConnection(connect);

            try
            {

                //Creare obiect SqlCommand
                SqlCommand ObjSqlCommandsVerificare = new SqlCommand("AdaugareUtilizator", obSqlConectare);
                ObjSqlCommandsVerificare.CommandType = System.Data.CommandType.StoredProcedure;
                ObjSqlCommandsVerificare.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
                ObjSqlCommandsVerificare.Parameters.AddWithValue("@Parola", Parola);
                obSqlConectare.Open();


                adapter = new SqlDataAdapter(ObjSqlCommandsVerificare);
                ds = new System.Data.DataSet();
                adapter.Fill(ds);

                if(ds.Tables[0].Rows.Count >= 1)
                {
                    MessageBox.Show("Numele de utilizator/parola exista in baza de date.");
                    return;
                }
                else
                {
                    
                    MessageBox.Show("Utilizator adaugat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Eroare" + ex.Message, "Eroare adaugare Valori SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                obSqlConectare.Close();

            }
        }

     






        //Metoda care actualizeaza utilizatorii in baza de date
        public void Actualizeaza(int id)
        {
            //Sirul de conectare
            string connect = ConfigurationManager.ConnectionStrings["SistemScolarConnectionString"].ConnectionString;

            //Creare obiect pentru conectare
            SqlConnection obSqlConectare = new SqlConnection(connect);

            try
            {

                //Creare obiect SqlCommand
                SqlCommand ObjSqlCommandsVerificare = new SqlCommand("ActualizareUtilizatori", obSqlConectare);
                ObjSqlCommandsVerificare.CommandType = System.Data.CommandType.StoredProcedure;
                ObjSqlCommandsVerificare.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
                ObjSqlCommandsVerificare.Parameters.AddWithValue("@Parola", Parola);
                obSqlConectare.Open();


                adapter = new SqlDataAdapter(ObjSqlCommandsVerificare);
                ds = new System.Data.DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count >= 1)
                {
                    MessageBox.Show("Numele de utilizator/parola exista in baza de date.");
                    return;
                }
                else
                {
                    SqlCommand ObjSqlCommands = new SqlCommand("AdaugareUtilizator", obSqlConectare);
                    ObjSqlCommands.CommandType = System.Data.CommandType.StoredProcedure;
                    ObjSqlCommands.Parameters.AddWithValue("@UtilizatorID", id);
                    ObjSqlCommands.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
                    ObjSqlCommands.Parameters.AddWithValue("@Parola", Parola);
                    ObjSqlCommands.Parameters.AddWithValue("@Pozitia", Pozitie);
                    ObjSqlCommands.ExecuteNonQuery();
                    MessageBox.Show("Utilizator actualizat cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Eroare" + ex.Message, "Eroare Actualizare Valori SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                obSqlConectare.Close();

            }
        }





        //Metoda care sterge utilizatorii din baza de date
        public void Sterge(int id)
        {
            //Sirul de conectare
            string connect = ConfigurationManager.ConnectionStrings["SistemScolarConnectionString"].ConnectionString;

            //Creare obiect pentru conectare
            SqlConnection obSqlConectare = new SqlConnection(connect);
            //Creare obiect SqlCommand
            SqlCommand ObjSqlCommands = new SqlCommand("StergereUtilizator", obSqlConectare);
            ObjSqlCommands.CommandType = System.Data.CommandType.StoredProcedure;
            ObjSqlCommands.Parameters.AddWithValue("@UtilizatorID", id);
         


            

            try
            {

               
                obSqlConectare.Open();
                ObjSqlCommands.ExecuteNonQuery();
                

            }

            catch (Exception ex)
            {
                MessageBox.Show("Eroare" + ex.Message, "Eroare Stergere Valori SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                obSqlConectare.Close();

            }
            MessageBox.Show("Utilizator sters cu succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal void DateUtilizator()
        {
            throw new NotImplementedException();
        }
    }
}
