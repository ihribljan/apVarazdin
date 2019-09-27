using System;

namespace APVarazdin
{
    partial class Prodaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prodaja));
            this.txtBrojKarte = new System.Windows.Forms.TextBox();
            this.apVarazdinDataSet = new APVarazdin.apVarazdinDataSet();
            this.autobusiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autobusiTableAdapter = new APVarazdin.apVarazdinDataSetTableAdapters.AutobusiTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poslovniPartneriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dnevniPrometToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servisiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prodaneKarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbZaposlenici = new System.Windows.Forms.ComboBox();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apVarazdinDataSet1 = new APVarazdin.apVarazdinDataSet1();
            this.zaposleniciTableAdapter = new APVarazdin.apVarazdinDataSet1TableAdapters.ZaposleniciTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.apVarazdinDataSet2 = new APVarazdin.apVarazdinDataSet();
            this.apVarazdinDataSet11 = new APVarazdin.apVarazdinDataSet1();
            this.dataSet1 = new System.Data.DataSet();
            this.cmbPolazista = new System.Windows.Forms.ComboBox();
            this.kolodvoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relacijeTableAdapter = new APVarazdin.apVarazdinDataSet1TableAdapters.RelacijeTableAdapter();
            this.kolodvoriTableAdapter = new APVarazdin.apVarazdinDataSet1TableAdapters.KolodvoriTableAdapter();
            this.cmbOdredista = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fKRelacijeKolodv151B244EBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apVarazdinDataSet3 = new APVarazdin.apVarazdinDataSet();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnNaplati = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbVoznje = new System.Windows.Forms.ComboBox();
            this.voznjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voznjeTableAdapter = new APVarazdin.apVarazdinDataSet1TableAdapters.VoznjeTableAdapter();
            this.txtCijena = new System.Windows.Forms.MaskedTextBox();
            this.txtPopust = new System.Windows.Forms.MaskedTextBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.dteVrijemeIzdavanja = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusiBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolodvoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relacijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRelacijeKolodv151B244EBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voznjeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBrojKarte
            // 
            this.txtBrojKarte.Location = new System.Drawing.Point(150, 90);
            this.txtBrojKarte.Name = "txtBrojKarte";
            this.txtBrojKarte.ReadOnly = true;
            this.txtBrojKarte.Size = new System.Drawing.Size(100, 20);
            this.txtBrojKarte.TabIndex = 2;
            // 
            // apVarazdinDataSet
            // 
            this.apVarazdinDataSet.DataSetName = "apVarazdinDataSet";
            this.apVarazdinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autobusiBindingSource
            // 
            this.autobusiBindingSource.DataMember = "Autobusi";
            this.autobusiBindingSource.DataSource = this.apVarazdinDataSet;
            // 
            // autobusiTableAdapter
            // 
            this.autobusiTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.servisiToolStripMenuItem1,
            this.zaposleniciToolStripMenuItem,
            this.poslovniPartneriToolStripMenuItem,
            this.prodaneKarteToolStripMenuItem,
            this.dnevniPrometToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem1.Text = "Vozila";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            this.zaposleniciToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // poslovniPartneriToolStripMenuItem
            // 
            this.poslovniPartneriToolStripMenuItem.Name = "poslovniPartneriToolStripMenuItem";
            this.poslovniPartneriToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.poslovniPartneriToolStripMenuItem.Text = "Poslovni partneri";
            this.poslovniPartneriToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // dnevniPrometToolStripMenuItem
            // 
            this.dnevniPrometToolStripMenuItem.Name = "dnevniPrometToolStripMenuItem";
            this.dnevniPrometToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.dnevniPrometToolStripMenuItem.Text = "Dnevni promet";
            this.dnevniPrometToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // servisiToolStripMenuItem1
            // 
            this.servisiToolStripMenuItem1.Name = "servisiToolStripMenuItem1";
            this.servisiToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.servisiToolStripMenuItem1.Text = "Servisi";
            this.servisiToolStripMenuItem1.Click += new System.EventHandler(this.servisiToolStripMenuItem1_Click);
            // 
            // prodaneKarteToolStripMenuItem
            // 
            this.prodaneKarteToolStripMenuItem.Name = "prodaneKarteToolStripMenuItem";
            this.prodaneKarteToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.prodaneKarteToolStripMenuItem.Text = "Prodane karte";
            this.prodaneKarteToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Blagajnik:";
            // 
            // cmbZaposlenici
            // 
            this.cmbZaposlenici.DataSource = this.zaposleniciBindingSource;
            this.cmbZaposlenici.DisplayMember = "Id";
            this.cmbZaposlenici.FormattingEnabled = true;
            this.cmbZaposlenici.Location = new System.Drawing.Point(150, 60);
            this.cmbZaposlenici.Name = "cmbZaposlenici";
            this.cmbZaposlenici.Size = new System.Drawing.Size(100, 21);
            this.cmbZaposlenici.TabIndex = 1;
            // 
            // zaposleniciBindingSource
            // 
            this.zaposleniciBindingSource.DataMember = "Zaposlenici";
            this.zaposleniciBindingSource.DataSource = this.apVarazdinDataSet1;
            // 
            // apVarazdinDataSet1
            // 
            this.apVarazdinDataSet1.DataSetName = "apVarazdinDataSet1";
            this.apVarazdinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaposleniciTableAdapter
            // 
            this.zaposleniciTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Vrijeme izdavanja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Broj karte:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Popust %:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Cijena:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "UKUPAN IZNOS:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Polazište:";
            // 
            // apVarazdinDataSet2
            // 
            this.apVarazdinDataSet2.DataSetName = "apVarazdinDataSet";
            this.apVarazdinDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apVarazdinDataSet11
            // 
            this.apVarazdinDataSet11.DataSetName = "apVarazdinDataSet1";
            this.apVarazdinDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // cmbPolazista
            // 
            this.cmbPolazista.DataSource = this.kolodvoriBindingSource;
            this.cmbPolazista.DisplayMember = "Naziv";
            this.cmbPolazista.FormattingEnabled = true;
            this.cmbPolazista.Location = new System.Drawing.Point(150, 200);
            this.cmbPolazista.Name = "cmbPolazista";
            this.cmbPolazista.Size = new System.Drawing.Size(245, 21);
            this.cmbPolazista.TabIndex = 4;
            this.cmbPolazista.SelectedIndexChanged += new System.EventHandler(this.cmbPolazista_SelectedIndexChanged);
            // 
            // kolodvoriBindingSource
            // 
            this.kolodvoriBindingSource.DataMember = "Kolodvori";
            this.kolodvoriBindingSource.DataSource = this.apVarazdinDataSet1;
            // 
            // relacijeBindingSource
            // 
            this.relacijeBindingSource.DataMember = "Relacije";
            this.relacijeBindingSource.DataSource = this.apVarazdinDataSet1;
            // 
            // relacijeTableAdapter
            // 
            this.relacijeTableAdapter.ClearBeforeFill = true;
            // 
            // kolodvoriTableAdapter
            // 
            this.kolodvoriTableAdapter.ClearBeforeFill = true;
            // 
            // cmbOdredista
            // 
            this.cmbOdredista.DataSource = this.kolodvoriBindingSource;
            this.cmbOdredista.DisplayMember = "Naziv";
            this.cmbOdredista.FormattingEnabled = true;
            this.cmbOdredista.Location = new System.Drawing.Point(150, 233);
            this.cmbOdredista.Name = "cmbOdredista";
            this.cmbOdredista.Size = new System.Drawing.Size(245, 21);
            this.cmbOdredista.TabIndex = 5;
            this.cmbOdredista.SelectedIndexChanged += new System.EventHandler(this.cmbOdredista_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Odredište:";
            // 
            // fKRelacijeKolodv151B244EBindingSource
            // 
            this.fKRelacijeKolodv151B244EBindingSource.DataMember = "FK__Relacije__Kolodv__151B244E";
            this.fKRelacijeKolodv151B244EBindingSource.DataSource = this.kolodvoriBindingSource;
            // 
            // apVarazdinDataSet3
            // 
            this.apVarazdinDataSet3.DataSetName = "apVarazdinDataSet";
            this.apVarazdinDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnNaplati
            // 
            this.btnNaplati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNaplati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNaplati.ForeColor = System.Drawing.Color.White;
            this.btnNaplati.Location = new System.Drawing.Point(315, 350);
            this.btnNaplati.Name = "btnNaplati";
            this.btnNaplati.Size = new System.Drawing.Size(100, 30);
            this.btnNaplati.TabIndex = 10;
            this.btnNaplati.Text = "Naplati";
            this.btnNaplati.UseVisualStyleBackColor = false;
            this.btnNaplati.Click += new System.EventHandler(this.btnNaplati_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Vrijeme putovanja:";
            // 
            // cmbVoznje
            // 
            this.cmbVoznje.DataSource = this.voznjeBindingSource;
            this.cmbVoznje.DisplayMember = "VrijemePolaska";
            this.cmbVoznje.FormattingEnabled = true;
            this.cmbVoznje.Location = new System.Drawing.Point(150, 263);
            this.cmbVoznje.Name = "cmbVoznje";
            this.cmbVoznje.Size = new System.Drawing.Size(245, 21);
            this.cmbVoznje.TabIndex = 6;
            // 
            // voznjeBindingSource
            // 
            this.voznjeBindingSource.DataMember = "Voznje";
            this.voznjeBindingSource.DataSource = this.apVarazdinDataSet1;
            // 
            // voznjeTableAdapter
            // 
            this.voznjeTableAdapter.ClearBeforeFill = true;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(569, 201);
            this.txtCijena.Mask = "990.00";
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 20);
            this.txtCijena.TabIndex = 7;
            this.txtCijena.Enter += new System.EventHandler(this.txtCijena_Enter);
            this.txtCijena.Leave += new System.EventHandler(this.txtCijena_Leave);
            // 
            // txtPopust
            // 
            this.txtPopust.Location = new System.Drawing.Point(569, 233);
            this.txtPopust.Mask = "90.00";
            this.txtPopust.Name = "txtPopust";
            this.txtPopust.Size = new System.Drawing.Size(100, 20);
            this.txtPopust.TabIndex = 8;
            this.txtPopust.Enter += new System.EventHandler(this.txtPopust_Enter);
            this.txtPopust.Leave += new System.EventHandler(this.txtPopust_Leave);
            // 
            // txtIznos
            // 
            this.txtIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIznos.Location = new System.Drawing.Point(569, 264);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.ReadOnly = true;
            this.txtIznos.Size = new System.Drawing.Size(100, 20);
            this.txtIznos.TabIndex = 48;
            // 
            // dteVrijemeIzdavanja
            // 
            this.dteVrijemeIzdavanja.CustomFormat = "dd. MM. yyyy  HH:mm:ss";
            this.dteVrijemeIzdavanja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteVrijemeIzdavanja.Location = new System.Drawing.Point(150, 120);
            this.dteVrijemeIzdavanja.Name = "dteVrijemeIzdavanja";
            this.dteVrijemeIzdavanja.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dteVrijemeIzdavanja.Size = new System.Drawing.Size(175, 20);
            this.dteVrijemeIzdavanja.TabIndex = 3;
            // 
            // Prodaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 411);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.txtPopust);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.cmbVoznje);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnNaplati);
            this.Controls.Add(this.dteVrijemeIzdavanja);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbOdredista);
            this.Controls.Add(this.cmbPolazista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbZaposlenici);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrojKarte);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Prodaja";
            this.Text = "APVarazdin";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusiBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolodvoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relacijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRelacijeKolodv151B244EBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voznjeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            //textBox17 = textBox8 - (textBox8 * textBox17);

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox txtBrojKarte;
        private apVarazdinDataSet apVarazdinDataSet;
        private System.Windows.Forms.BindingSource autobusiBindingSource;
        private apVarazdinDataSetTableAdapters.AutobusiTableAdapter autobusiTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poslovniPartneriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dnevniPrometToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbZaposlenici;
        private apVarazdinDataSet1 apVarazdinDataSet1;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private apVarazdinDataSet1TableAdapters.ZaposleniciTableAdapter zaposleniciTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private apVarazdinDataSet apVarazdinDataSet2;
        private apVarazdinDataSet1 apVarazdinDataSet11;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.ComboBox cmbPolazista;
        private System.Windows.Forms.BindingSource relacijeBindingSource;
        private apVarazdinDataSet1TableAdapters.RelacijeTableAdapter relacijeTableAdapter;
        private System.Windows.Forms.BindingSource kolodvoriBindingSource;
        private apVarazdinDataSet1TableAdapters.KolodvoriTableAdapter kolodvoriTableAdapter;
        private System.Windows.Forms.ComboBox cmbOdredista;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource fKRelacijeKolodv151B244EBindingSource;
        private apVarazdinDataSet apVarazdinDataSet3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnNaplati;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbVoznje;
        private System.Windows.Forms.BindingSource voznjeBindingSource;
        private apVarazdinDataSet1TableAdapters.VoznjeTableAdapter voznjeTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem servisiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prodaneKarteToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txtCijena;
        private System.Windows.Forms.MaskedTextBox txtPopust;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.DateTimePicker dteVrijemeIzdavanja;
    }
}

