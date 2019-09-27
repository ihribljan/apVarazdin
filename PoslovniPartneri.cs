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
    public partial class PoslovniPartneri : Form
    {
        public PoslovniPartneri()
        {
            InitializeComponent();
        }

        private void PoslovniPartneri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apVarazdinDataSet9.vPoslovniPartneri' table. You can move, or remove it, as needed.
            this.vPoslovniPartneriTableAdapter3.Fill(this.apVarazdinDataSet9.vPoslovniPartneri);
        }
    }
}
