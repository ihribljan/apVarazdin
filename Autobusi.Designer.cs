namespace APVarazdin
{
    partial class Autobusi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autobusi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vAutobusiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apVarazdinDataSet2 = new APVarazdin.apVzDataSet();
            this.autobusiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.apVarazdinDataSet1 = new APVarazdin.apVzDataSet();
            this.apVarazdinDataSet = new APVarazdin.apVzDataSet();
            this.autobusiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autobusiTableAdapter = new APVarazdin.apVzDataSetTableAdapters.AutobusiTableAdapter();
            this.autobusiTableAdapter1 = new APVarazdin.apVzDataSetTableAdapters.AutobusiTableAdapter();
            this.autobusiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.autobusiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.autobusiTableAdapter2 = new APVarazdin.apVzDataSetTableAdapters.AutobusiTableAdapter();
            this.vAutobusiTableAdapter = new APVarazdin.apVzDataSetTableAdapters.vAutobusiTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markeVozilaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivMarkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeliVozilaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivModelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojSasijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAutobusiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusiBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.markeVozilaIdDataGridViewTextBoxColumn,
            this.nazivMarkeDataGridViewTextBoxColumn,
            this.modeliVozilaIdDataGridViewTextBoxColumn,
            this.nazivModelaDataGridViewTextBoxColumn,
            this.brojSasijeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vAutobusiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vAutobusiBindingSource
            // 
            this.vAutobusiBindingSource.DataMember = "vAutobusi";
            this.vAutobusiBindingSource.DataSource = this.apVarazdinDataSet2;
            // 
            // apVarazdinDataSet2
            // 
            this.apVarazdinDataSet2.DataSetName = "apVarazdinDataSet2";
            this.apVarazdinDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autobusiBindingSource1
            // 
            this.autobusiBindingSource1.DataMember = "Autobusi";
            this.autobusiBindingSource1.DataSource = this.apVarazdinDataSet1;
            // 
            // apVarazdinDataSet1
            // 
            this.apVarazdinDataSet1.DataSetName = "apVarazdinDataSet1";
            this.apVarazdinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // autobusiTableAdapter1
            // 
            this.autobusiTableAdapter1.ClearBeforeFill = true;
            // 
            // autobusiBindingSource2
            // 
            this.autobusiBindingSource2.DataMember = "Autobusi";
            this.autobusiBindingSource2.DataSource = this.apVarazdinDataSet1;
            // 
            // autobusiBindingSource3
            // 
            this.autobusiBindingSource3.DataMember = "Autobusi";
            this.autobusiBindingSource3.DataSource = this.apVarazdinDataSet2;
            // 
            // autobusiTableAdapter2
            // 
            this.autobusiTableAdapter2.ClearBeforeFill = true;
            // 
            // vAutobusiTableAdapter
            // 
            this.vAutobusiTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // markeVozilaIdDataGridViewTextBoxColumn
            // 
            this.markeVozilaIdDataGridViewTextBoxColumn.DataPropertyName = "MarkeVozilaId";
            this.markeVozilaIdDataGridViewTextBoxColumn.HeaderText = "Šifra marke";
            this.markeVozilaIdDataGridViewTextBoxColumn.Name = "markeVozilaIdDataGridViewTextBoxColumn";
            this.markeVozilaIdDataGridViewTextBoxColumn.Width = 90;
            // 
            // nazivMarkeDataGridViewTextBoxColumn
            // 
            this.nazivMarkeDataGridViewTextBoxColumn.DataPropertyName = "NazivMarke";
            this.nazivMarkeDataGridViewTextBoxColumn.HeaderText = "Naziv marke";
            this.nazivMarkeDataGridViewTextBoxColumn.Name = "nazivMarkeDataGridViewTextBoxColumn";
            // 
            // modeliVozilaIdDataGridViewTextBoxColumn
            // 
            this.modeliVozilaIdDataGridViewTextBoxColumn.DataPropertyName = "ModeliVozilaId";
            this.modeliVozilaIdDataGridViewTextBoxColumn.HeaderText = "Šifra modela";
            this.modeliVozilaIdDataGridViewTextBoxColumn.Name = "modeliVozilaIdDataGridViewTextBoxColumn";
            this.modeliVozilaIdDataGridViewTextBoxColumn.Width = 90;
            // 
            // nazivModelaDataGridViewTextBoxColumn
            // 
            this.nazivModelaDataGridViewTextBoxColumn.DataPropertyName = "NazivModela";
            this.nazivModelaDataGridViewTextBoxColumn.HeaderText = "Naziv modela";
            this.nazivModelaDataGridViewTextBoxColumn.Name = "nazivModelaDataGridViewTextBoxColumn";
            // 
            // brojSasijeDataGridViewTextBoxColumn
            // 
            this.brojSasijeDataGridViewTextBoxColumn.DataPropertyName = "BrojSasije";
            this.brojSasijeDataGridViewTextBoxColumn.HeaderText = "Broj šasije";
            this.brojSasijeDataGridViewTextBoxColumn.Name = "brojSasijeDataGridViewTextBoxColumn";
            this.brojSasijeDataGridViewTextBoxColumn.Width = 150;
            // 
            // Autobusi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 261);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Autobusi";
            this.Text = "Autobusi";
            this.Load += new System.EventHandler(this.Autobusi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAutobusiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusiBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private apVzDataSet apVarazdinDataSet;
        private System.Windows.Forms.BindingSource autobusiBindingSource;
        private apVzDataSetTableAdapters.AutobusiTableAdapter autobusiTableAdapter;
        private apVzDataSet apVarazdinDataSet1;
        private System.Windows.Forms.BindingSource autobusiBindingSource1;
        private apVzDataSetTableAdapters.AutobusiTableAdapter autobusiTableAdapter1;
        private System.Windows.Forms.BindingSource autobusiBindingSource2;
        private apVzDataSet apVarazdinDataSet2;
        private System.Windows.Forms.BindingSource autobusiBindingSource3;
        private apVzDataSetTableAdapters.AutobusiTableAdapter autobusiTableAdapter2;
        private System.Windows.Forms.BindingSource vAutobusiBindingSource;
        private apVzDataSetTableAdapters.vAutobusiTableAdapter vAutobusiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markeVozilaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivMarkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeliVozilaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivModelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojSasijeDataGridViewTextBoxColumn;
    }
}