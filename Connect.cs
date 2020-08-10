using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemScolardeInregistrare
{
    class Connect
    {
        SqlConnection connect;

        public Connect()
        {
            connect = new SqlConnection("Data Source=LAPTOP-IHQBO0UQ; Initial Catalog=SistemScolar; Integrated Security=True");
        }

        public SqlConnection Openconnection()
        {
            try
            {
                connect.Open();
                    
            }
            catch(Exception)
            {

            }

            return connect;
        }

        public void Closeconnection()
        {
            try
            {
                connect.Close();
            }
            catch(Exception)
            {

            }
          
        }
    }
}
