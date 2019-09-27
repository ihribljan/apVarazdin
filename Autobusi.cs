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
    public partial class Autobusi : Form
    {
        public Autobusi()
        {
            InitializeComponent();
        }

        private void Autobusi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apVarazdinDataSet2.vAutobusi' table. You can move, or remove it, as needed.
            this.vAutobusiTableAdapter.Fill(this.apVarazdinDataSet2.vAutobusi);
            // TODO: This line of code loads data into the 'apVarazdinDataSet2.Autobusi' table. You can move, or remove it, as needed.
            this.autobusiTableAdapter2.Fill(this.apVarazdinDataSet2.Autobusi);
            // TODO: This line of code loads data into the 'apVarazdinDataSet1.Autobusi' table. You can move, or remove it, as needed.
            this.autobusiTableAdapter1.Fill(this.apVarazdinDataSet1.Autobusi);
            // TODO: This line of code loads data into the 'apVarazdinDataSet.Autobusi' table. You can move, or remove it, as needed.
            this.autobusiTableAdapter.Fill(this.apVarazdinDataSet.Autobusi);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
