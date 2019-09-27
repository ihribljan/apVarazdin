namespace APVarazdin
{
    partial class Servisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servisi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vServisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apVarazdinDataSet3 = new APVarazdin.apVarazdinDataSet3();
            this.servisiAutobusaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apVarazdinDataSet1 = new APVarazdin.apVarazdinDataSet1();
            this.servisiAutobusaTableAdapter = new APVarazdin.apVarazdinDataSet1TableAdapters.ServisiAutobusaTableAdapter();
            this.vServisiTableAdapter = new APVarazdin.apVarazdinDataSet3TableAdapters.vServisiTableAdapter();
            this.datumServisaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mjesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivMarke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivModela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSasije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vServisiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisiAutobusaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datumServisaDataGridViewTextBoxColumn,
            this.Naziv,
            this.Mjesto,
            this.NazivMarke,
            this.NazivModela,
            this.BrojSasije,
            this.opisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vServisiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(968, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // vServisiBindingSource
            // 
            this.vServisiBindingSource.DataMember = "vServisi";
            this.vServisiBindingSource.DataSource = this.apVarazdinDataSet3;
            // 
            // apVarazdinDataSet3
            // 
            this.apVarazdinDataSet3.DataSetName = "apVarazdinDataSet3";
            this.apVarazdinDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servisiAutobusaBindingSource
            // 
            this.servisiAutobusaBindingSource.DataMember = "ServisiAutobusa";
            this.servisiAutobusaBindingSource.DataSource = this.apVarazdinDataSet1;
            // 
            // apVarazdinDataSet1
            // 
            this.apVarazdinDataSet1.DataSetName = "apVarazdinDataSet1";
            this.apVarazdinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servisiAutobusaTableAdapter
            // 
            this.servisiAutobusaTableAdapter.ClearBeforeFill = true;
            // 
            // vServisiTableAdapter
            // 
            this.vServisiTableAdapter.ClearBeforeFill = true;
            // 
            // datumServisaDataGridViewTextBoxColumn
            // 
            this.datumServisaDataGridViewTextBoxColumn.DataPropertyName = "DatumServisa";
            this.datumServisaDataGridViewTextBoxColumn.HeaderText = "Datum servisa";
            this.datumServisaDataGridViewTextBoxColumn.Name = "datumServisaDataGridViewTextBoxColumn";
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Mjesto
            // 
            this.Mjesto.DataPropertyName = "Mjesto";
            this.Mjesto.HeaderText = "Mjesto";
            this.Mjesto.Name = "Mjesto";
            // 
            // NazivMarke
            // 
            this.NazivMarke.DataPropertyName = "NazivMarke";
            this.NazivMarke.HeaderText = "Marka";
            this.NazivMarke.Name = "NazivMarke";
            // 
            // NazivModela
            // 
            this.NazivModela.DataPropertyName = "NazivModela";
            this.NazivModela.HeaderText = "Model";
            this.NazivModela.Name = "NazivModela";
            // 
            // BrojSasije
            // 
            this.BrojSasije.DataPropertyName = "BrojSasije";
            this.BrojSasije.HeaderText = "Broj šasije";
            this.BrojSasije.Name = "BrojSasije";
            this.BrojSasije.Width = 150;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.Width = 275;
            // 
            // Servisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 266);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Servisi";
            this.Text = "Servisi";
            this.Load += new System.EventHandler(this.Servisi_Load);
            this.Click += new System.EventHandler(this.Servisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vServisiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servisiAutobusaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private apVarazdinDataSet1 apVarazdinDataSet1;
        private System.Windows.Forms.BindingSource servisiAutobusaBindingSource;
        private apVarazdinDataSet1TableAdapters.ServisiAutobusaTableAdapter servisiAutobusaTableAdapter;
        private apVarazdinDataSet3 apVarazdinDataSet3;
        private System.Windows.Forms.BindingSource vServisiBindingSource;
        private apVarazdinDataSet3TableAdapters.vServisiTableAdapter vServisiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumServisaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mjesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivMarke;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivModela;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSasije;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
    }
}