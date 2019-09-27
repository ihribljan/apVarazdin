namespace APVarazdin
{
    partial class ProdaneKarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdaneKarte));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.apVarazdinDataSet5 = new APVarazdin.apVarazdinDataSet5();
            this.vProdaneKarteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vProdaneKarteTableAdapter = new APVarazdin.apVarazdinDataSet5TableAdapters.vProdaneKarteTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojKarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeIzdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polazakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemePolaskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolazakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeDolaskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosRacunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProdaneKarteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.brojKarteDataGridViewTextBoxColumn,
            this.vrijemeIzdavanjaDataGridViewTextBoxColumn,
            this.polazakDataGridViewTextBoxColumn,
            this.vrijemePolaskaDataGridViewTextBoxColumn,
            this.dolazakDataGridViewTextBoxColumn,
            this.vrijemeDolaskaDataGridViewTextBoxColumn,
            this.iznosRacunaDataGridViewTextBoxColumn,
            this.zaposlenikDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vProdaneKarteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(868, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // apVarazdinDataSet5
            // 
            this.apVarazdinDataSet5.DataSetName = "apVarazdinDataSet5";
            this.apVarazdinDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vProdaneKarteBindingSource
            // 
            this.vProdaneKarteBindingSource.DataMember = "vProdaneKarte";
            this.vProdaneKarteBindingSource.DataSource = this.apVarazdinDataSet5;
            // 
            // vProdaneKarteTableAdapter
            // 
            this.vProdaneKarteTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // brojKarteDataGridViewTextBoxColumn
            // 
            this.brojKarteDataGridViewTextBoxColumn.DataPropertyName = "BrojKarte";
            this.brojKarteDataGridViewTextBoxColumn.HeaderText = "Broj karte";
            this.brojKarteDataGridViewTextBoxColumn.Name = "brojKarteDataGridViewTextBoxColumn";
            this.brojKarteDataGridViewTextBoxColumn.Width = 75;
            // 
            // vrijemeIzdavanjaDataGridViewTextBoxColumn
            // 
            this.vrijemeIzdavanjaDataGridViewTextBoxColumn.DataPropertyName = "VrijemeIzdavanja";
            this.vrijemeIzdavanjaDataGridViewTextBoxColumn.HeaderText = "Vrijeme izdavanja";
            this.vrijemeIzdavanjaDataGridViewTextBoxColumn.Name = "vrijemeIzdavanjaDataGridViewTextBoxColumn";
            this.vrijemeIzdavanjaDataGridViewTextBoxColumn.Width = 125;
            // 
            // polazakDataGridViewTextBoxColumn
            // 
            this.polazakDataGridViewTextBoxColumn.DataPropertyName = "Polazak";
            this.polazakDataGridViewTextBoxColumn.HeaderText = "Polazak";
            this.polazakDataGridViewTextBoxColumn.Name = "polazakDataGridViewTextBoxColumn";
            // 
            // vrijemePolaskaDataGridViewTextBoxColumn
            // 
            this.vrijemePolaskaDataGridViewTextBoxColumn.DataPropertyName = "VrijemePolaska";
            this.vrijemePolaskaDataGridViewTextBoxColumn.HeaderText = "Vrijeme polaska";
            this.vrijemePolaskaDataGridViewTextBoxColumn.Name = "vrijemePolaskaDataGridViewTextBoxColumn";
            this.vrijemePolaskaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dolazakDataGridViewTextBoxColumn
            // 
            this.dolazakDataGridViewTextBoxColumn.DataPropertyName = "Dolazak";
            this.dolazakDataGridViewTextBoxColumn.HeaderText = "Dolazak";
            this.dolazakDataGridViewTextBoxColumn.Name = "dolazakDataGridViewTextBoxColumn";
            // 
            // vrijemeDolaskaDataGridViewTextBoxColumn
            // 
            this.vrijemeDolaskaDataGridViewTextBoxColumn.DataPropertyName = "VrijemeDolaska";
            this.vrijemeDolaskaDataGridViewTextBoxColumn.HeaderText = "Vrijeme dolaska";
            this.vrijemeDolaskaDataGridViewTextBoxColumn.Name = "vrijemeDolaskaDataGridViewTextBoxColumn";
            this.vrijemeDolaskaDataGridViewTextBoxColumn.Width = 125;
            // 
            // iznosRacunaDataGridViewTextBoxColumn
            // 
            this.iznosRacunaDataGridViewTextBoxColumn.DataPropertyName = "IznosRacuna";
            this.iznosRacunaDataGridViewTextBoxColumn.HeaderText = "Iznos računa";
            this.iznosRacunaDataGridViewTextBoxColumn.Name = "iznosRacunaDataGridViewTextBoxColumn";
            // 
            // zaposlenikDataGridViewTextBoxColumn
            // 
            this.zaposlenikDataGridViewTextBoxColumn.DataPropertyName = "Zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.HeaderText = "Zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.Name = "zaposlenikDataGridViewTextBoxColumn";
            this.zaposlenikDataGridViewTextBoxColumn.Width = 75;
            // 
            // ProdaneKarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 450);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProdaneKarte";
            this.Text = "ProdaneKarte";
            this.Load += new System.EventHandler(this.ProdaneKarte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProdaneKarteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private apVarazdinDataSet5 apVarazdinDataSet5;
        private System.Windows.Forms.BindingSource vProdaneKarteBindingSource;
        private apVarazdinDataSet5TableAdapters.vProdaneKarteTableAdapter vProdaneKarteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojKarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeIzdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polazakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemePolaskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolazakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeDolaskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosRacunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikDataGridViewTextBoxColumn;
    }
}