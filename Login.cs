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
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        private Utilizator obUtilizator;
        public Login()
        {
            InitializeComponent();
        }

        

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if(check.Checked)
            {
                txt_Parola.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Parola.UseSystemPasswordChar = true;
            }
        }
    }
}
