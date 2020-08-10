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
    public partial class RaportTaxe : Form
    {
        public RaportTaxe()
        {
            InitializeComponent();
        }

        private void RaportTaxe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SistemScolarDataSet2.rapTaxa' table. You can move, or remove it, as needed.
            this.rapTaxaTableAdapter.Fill(this.SistemScolarDataSet2.rapTaxa);

            this.reportViewer1.RefreshReport();
        }
    }
}
