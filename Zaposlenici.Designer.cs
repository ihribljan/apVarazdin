namespace APVarazdin
{
    partial class Zaposlenici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zaposlenici));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobitelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaporkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnoMjestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vZaposleniciBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.apVarazdinDataSet11 = new APVarazdin.apVarazdinDataSet4();
            this.vZaposleniciTableAdapter = new APVarazdin.apVarazdinDataSet3TableAdapters.vZaposleniciTableAdapter();
            this.vZaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vZaposleniciTableAdapter1 = new APVarazdin.apVarazdinDataSet4TableAdapters.vZaposleniciTableAdapter();
            this.apVarazdinDataSet6 = new APVarazdin.apVarazdinDataSet6();
            this.vZaposleniciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vZaposleniciTableAdapter2 = new APVarazdin.apVarazdinDataSet6TableAdapters.vZaposleniciTableAdapter();
            this.Zaporka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vZaposleniciBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vZaposleniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vZaposleniciBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.oibDataGridViewTextBoxColumn,
            this.mobitelDataGridViewTextBoxColumn,
            this.zaporkaDataGridViewTextBoxColumn,
            this.radnoMjestoDataGridViewTextBoxColumn,
            this.mjestoDataGridViewTextBoxColumn,
            this.Zaporka});
            this.dataGridView1.DataSource = this.vZaposleniciBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 165);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // oibDataGridViewTextBoxColumn
            // 
            this.oibDataGridViewTextBoxColumn.DataPropertyName = "Oib";
            this.oibDataGridViewTextBoxColumn.HeaderText = "Oib";
            this.oibDataGridViewTextBoxColumn.Name = "oibDataGridViewTextBoxColumn";
            // 
            // mobitelDataGridViewTextBoxColumn
            // 
            this.mobitelDataGridViewTextBoxColumn.DataPropertyName = "Mobitel";
            this.mobitelDataGridViewTextBoxColumn.HeaderText = "Mobitel";
            this.mobitelDataGridViewTextBoxColumn.Name = "mobitelDataGridViewTextBoxColumn";
            // 
            // zaporkaDataGridViewTextBoxColumn
            // 
            this.zaporkaDataGridViewTextBoxColumn.DataPropertyName = "Zaporka";
            this.zaporkaDataGridViewTextBoxColumn.HeaderText = "Zaporka";
            this.zaporkaDataGridViewTextBoxColumn.Name = "zaporkaDataGridViewTextBoxColumn";
            this.zaporkaDataGridViewTextBoxColumn.Visible = false;
            // 
            // radnoMjestoDataGridViewTextBoxColumn
            // 
            this.radnoMjestoDataGridViewTextBoxColumn.DataPropertyName = "RadnoMjesto";
            this.radnoMjestoDataGridViewTextBoxColumn.HeaderText = "Radno mjesto";
            this.radnoMjestoDataGridViewTextBoxColumn.Name = "radnoMjestoDataGridViewTextBoxColumn";
            // 
            // mjestoDataGridViewTextBoxColumn
            // 
            this.mjestoDataGridViewTextBoxColumn.DataPropertyName = "Mjesto";
            this.mjestoDataGridViewTextBoxColumn.HeaderText = "Mjesto";
            this.mjestoDataGridViewTextBoxColumn.Name = "mjestoDataGridViewTextBoxColumn";
            // 
            // vZaposleniciBindingSource2
            // 
            this.vZaposleniciBindingSource2.DataMember = "vZaposlenici";
            this.vZaposleniciBindingSource2.DataSource = this.apVarazdinDataSet11;
            // 
            // apVarazdinDataSet4
            // 
            this.apVarazdinDataSet11.DataSetName = "apVarazdinDataSet4";
            this.apVarazdinDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vZaposleniciTableAdapter
            // 
            this.vZaposleniciTableAdapter.ClearBeforeFill = true;
            // 
            // vZaposleniciBindingSource
            // 
            this.vZaposleniciBindingSource.DataMember = "vZaposlenici";
            this.vZaposleniciBindingSource.DataSource = this.apVarazdinDataSet11;
            // 
            // vZaposleniciTableAdapter1
            // 
            this.vZaposleniciTableAdapter1.ClearBeforeFill = true;
            // 
            // apVarazdinDataSet6
            // 
            this.apVarazdinDataSet6.DataSetName = "apVarazdinDataSet6";
            this.apVarazdinDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vZaposleniciBindingSource1
            // 
            this.vZaposleniciBindingSource1.DataMember = "vZaposlenici";
            this.vZaposleniciBindingSource1.DataSource = this.apVarazdinDataSet6;
            // 
            // vZaposleniciTableAdapter2
            // 
            this.vZaposleniciTableAdapter2.ClearBeforeFill = true;
            // 
            // Zaporka
            // 
            this.Zaporka.DataPropertyName = "Zaporka";
            this.Zaporka.HeaderText = "Zaporka";
            this.Zaporka.Name = "Zaporka";
            // 
            // Zaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 272);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zaposlenici";
            this.Text = "Zaposlenici";
            this.Load += new System.EventHandler(this.Zaposlenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vZaposleniciBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vZaposleniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vZaposleniciBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private apVarazdinDataSet3TableAdapters.vZaposleniciTableAdapter vZaposleniciTableAdapter;
        private apVarazdinDataSet4 apVarazdinDataSet11;
        private System.Windows.Forms.BindingSource vZaposleniciBindingSource;
        private apVarazdinDataSet4TableAdapters.vZaposleniciTableAdapter vZaposleniciTableAdapter1;
        private apVarazdinDataSet6 apVarazdinDataSet6;
        private System.Windows.Forms.BindingSource vZaposleniciBindingSource1;
        private apVarazdinDataSet6TableAdapters.vZaposleniciTableAdapter vZaposleniciTableAdapter2;
        private System.Windows.Forms.BindingSource vZaposleniciBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobitelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaporkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radnoMjestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zaporka;
    }
}