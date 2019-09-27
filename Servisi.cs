using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APVarazdin
{
    public partial class Servisi : Form
    {
        public Servisi()
        {
            InitializeComponent();
        }

        private void Servisi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apVarazdinDataSet3.vServisi' table. You can move, or remove it, as needed.
            this.vServisiTableAdapter.Fill(this.apVarazdinDataSet3.vServisi);
            // TODO: This line of code loads data into the 'apVarazdinDataSet1.ServisiAutobusa' table. You can move, or remove it, as needed.
            this.servisiAutobusaTableAdapter.Fill(this.apVarazdinDataSet1.ServisiAutobusa);

        }
    }
}
