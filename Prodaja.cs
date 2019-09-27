using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APVarazdin.DataLayer;

namespace APVarazdin
{
    public partial class Prodaja : Form
    {
        private DbHelper dbHelper;

        public Prodaja()
        {
            InitializeComponent();
        }

        private void ocistiFormu()
        {
            txtCijena.Clear();
            txtPopust.Clear();
            txtIznos.Clear();

            txtCijena.Text = "000,00";
            txtPopust.Text = "00,00";

            cijena = 0;
            popust = 0;
            iznos = 0;

            dteVrijemeIzdavanja.Value = DateTime.Now;

            txtBrojKarte.Text = (TableKarte.getMaxBrojKarte() + 1).ToString();

            cmbOdredista.Focus();
        }

        private void pripremiFormuZaNovuKartu()
        {
            dbHelper = new DbHelper();

            cmbZaposlenici.DataSource = TableZaposlenici.getAll();
            cmbZaposlenici.ValueMember = "Id";
            cmbZaposlenici.DisplayMember = "Ime";

            txtBrojKarte.Text = (TableKarte.getMaxBrojKarte() + 1).ToString();

            BindingList<TableKolodvori> listaPolazista = TableKolodvori.getAll();
            cmbPolazista.DataSource = listaPolazista;
            cmbPolazista.ValueMember = "Id";
            cmbPolazista.DisplayMember = "Naziv";

            BindingList<TableKolodvori> listaOdredista = TableKolodvori.getAll();
            cmbOdredista.DataSource = listaOdredista;
            cmbOdredista.ValueMember = "Id";
            cmbOdredista.DisplayMember = "Naziv";

            if (listaPolazista.Count > 1)
                cmbPolazista.SelectedIndex = 0;

            if (listaOdredista.Count > 1)
                cmbOdredista.SelectedIndex = 1;

            dohvatiMoguceVoznjeIzmedjuKolodvora();

            txtCijena.Text = "000,00";
            txtPopust.Text = "00,00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO: This line of code loads data into the 'apVarazdinDataSet1.Voznje' table. You can move, or remove it, as needed.
            this.voznjeTableAdapter.Fill(this.apVarazdinDataSet11.Voznje);
            //TODO: This line of code loads data into the 'apVarazdinDataSet1.Kolodvori' table. You can move, or remove it, as needed.
            this.kolodvoriTableAdapter.Fill(this.apVarazdinDataSet11.Kolodvori);
            //TODO: This line of code loads data into the 'apVarazdinDataSet1.Relacije' table. You can move, or remove it, as needed.
            this.relacijeTableAdapter.Fill(this.apVarazdinDataSet11.Relacije);
            //TODO: This line of code loads data into the 'apVarazdinDataSet1.Zaposlenici' table. You can move, or remove it, as needed.
            this.zaposleniciTableAdapter.Fill(this.apVarazdinDataSet11.Zaposlenici);
            //TODO: This line of code loads data into the 'apVarazdinDataSet.Autobusi' table. You can move, or remove it, as needed.
            this.autobusiTableAdapter.Fill(this.apVarazdinDataSet.Autobusi);
            
            pripremiFormuZaNovuKartu();
        }

        private void dohvatiMoguceVoznjeIzmedjuKolodvora()
        {
            if (cmbPolazista.SelectedItem != null && cmbOdredista.SelectedItem != null)
            {
                int kolodvoriIdPolazak = 0, kolodvoriIdDolazak = 0;

                try
                {
                    kolodvoriIdPolazak = ((TableKolodvori)cmbPolazista.SelectedItem).Id;
                    kolodvoriIdDolazak = ((TableKolodvori)cmbOdredista.SelectedItem).Id;
                }
                catch(InvalidCastException c)
                {
                    Console.WriteLine(c);
                }

                if (kolodvoriIdPolazak > 0 && kolodvoriIdDolazak > 0)
                {
                    cmbVoznje.DataSource = TableVoznje.getAll(kolodvoriIdPolazak, kolodvoriIdDolazak);
                    cmbVoznje.ValueMember = "Id";
                    cmbVoznje.DisplayMember = "P_Vrijeme";
                }
            }
            else
            {
                cmbVoznje.DataSource = null;
                cmbVoznje.SelectedIndex = -1;
                cmbVoznje.SelectedItem = null;
                cmbVoznje.Text = " - NEMA RASPOLOŽIVIH VOŽNJI - ";
                if (cmbVoznje.SelectedIndex >= 0)
                    cmbVoznje.Items[cmbVoznje.SelectedIndex] = string.Empty;
            }
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Autobusi a = new Autobusi();
            a.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Zaposlenici a = new Zaposlenici();
            a.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DnevniPrometi a = new DnevniPrometi();
            a.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            PoslovniPartneri a = new PoslovniPartneri();
            a.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Prodaja a = new Prodaja();
            a.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ProdaneKarte a = new ProdaneKarte();
            a.ShowDialog();
        }

        private void servisiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Servisi a = new Servisi();
            a.ShowDialog();
        }      

        private void cmbPolazista_SelectedIndexChanged(object sender, EventArgs e)
        {
            dohvatiMoguceVoznjeIzmedjuKolodvora();
        }

        private void cmbOdredista_SelectedIndexChanged(object sender, EventArgs e)
        {
            dohvatiMoguceVoznjeIzmedjuKolodvora();
        }

        private decimal cijena = 0, popust = 0, iznos = 0;


        private void izracunajIznosRacuna()
        {
            try
            {
                if (txtCijena.Text != string.Empty)
                    cijena = Decimal.Parse(txtCijena.Text);

                if (txtPopust.Text != null)
                    popust = Decimal.Parse(txtPopust.Text);
            }
            catch(Exception e)
            {

            }

            iznos = cijena - cijena * popust / 100;
            txtIznos.Text = iznos.ToString("C2");
        }

        private void txtCijena_Leave(object sender, EventArgs e)
        {
            izracunajIznosRacuna();
        }

        private void txtCijena_Enter(object sender, EventArgs e)
        {
            txtCijena.Focus();
            txtCijena.SelectAll();
            txtCijena.SelectionStart = 0;
        }

        private void txtPopust_Enter(object sender, EventArgs e)
        {
            txtPopust.Focus();
            txtPopust.SelectAll();
            txtPopust.SelectionStart = 0;
        }

        private void txtPopust_Leave(object sender, EventArgs e)
        {
            izracunajIznosRacuna();
        }

        private void btnNaplati_Click(object sender, EventArgs e)
        {
            TableKarte karte = new TableKarte();
            karte.BrojKarte = Int32.Parse(txtBrojKarte.Text);
            karte.Cijena = cijena;
            karte.VrijemeIzdavanja = DateTime.Parse(dteVrijemeIzdavanja.Text);
            karte.Popust = popust;
            karte.ZaposleniciId = ((TableZaposlenici)cmbZaposlenici.SelectedItem).Id;
            karte.IznosRacuna = iznos;
            karte.VoznjeId = ((TableVoznje)cmbVoznje.SelectedItem).Id;

            if (karte.dodaj())
            {
                MessageBox.Show("Karta je uspješno spremljena.");
                ocistiFormu();
            }
            else
                MessageBox.Show("Greška prilikom spremanja karte!");
        }
    }
}
