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
    public partial class RaportStudenti : Form
    {
        public RaportStudenti()
        {
            InitializeComponent();
        }

        private void RaportStudenti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SistemScolarDataSet1.rapStudenti' table. You can move, or remove it, as needed.
            this.rapStudentiTableAdapter.Fill(this.SistemScolarDataSet1.rapStudenti);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
