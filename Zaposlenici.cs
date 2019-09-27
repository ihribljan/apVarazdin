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
    public partial class Zaposlenici : Form
    {
        public Zaposlenici()
        {
            InitializeComponent();
        }

        private void Zaposlenici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apVarazdinDataSet4.vZaposlenici' table. You can move, or remove it, as needed.
            this.vZaposleniciTableAdapter1.Fill(this.apVarazdinDataSet11.vZaposlenici);
        }
    }
}
