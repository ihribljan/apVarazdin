namespace APVarazdin
{
    partial class DnevniPrometi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DnevniPrometi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dnevniPrometiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apVarazdinDataSet1 = new APVarazdin.apVarazdinDataSet1();
            this.apVarazdinDataSet = new APVarazdin.apVarazdinDataSet();
            this.apVarazdinDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apVarazdinDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.autobusiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autobusiTableAdapter = new APVarazdin.apVarazdinDataSetTableAdapters.AutobusiTableAdapter();
            this.dnevniPrometiTableAdapter = new APVarazdin.apVarazdinDataSet1TableAdapters.DnevniPrometiTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnevniPrometiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.iznosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dnevniPrometiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(310, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dnevniPrometiBindingSource
            // 
            this.dnevniPrometiBindingSource.DataMember = "DnevniPrometi";
            this.dnevniPrometiBindingSource.DataSource = this.apVarazdinDataSet1;
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
            // apVarazdinDataSetBindingSource
            // 
            this.apVarazdinDataSetBindingSource.DataSource = this.apVarazdinDataSet;
            this.apVarazdinDataSetBindingSource.Position = 0;
            // 
            // apVarazdinDataSetBindingSource1
            // 
            this.apVarazdinDataSetBindingSource1.DataSource = this.apVarazdinDataSet;
            this.apVarazdinDataSetBindingSource1.Position = 0;
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
            // dnevniPrometiTableAdapter
            // 
            this.dnevniPrometiTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.Width = 125;
            // 
            // iznosDataGridViewTextBoxColumn
            // 
            this.iznosDataGridViewTextBoxColumn.DataPropertyName = "Iznos";
            this.iznosDataGridViewTextBoxColumn.HeaderText = "Iznos";
            this.iznosDataGridViewTextBoxColumn.Name = "iznosDataGridViewTextBoxColumn";
            this.iznosDataGridViewTextBoxColumn.Width = 142;
            // 
            // DnevniPrometi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DnevniPrometi";
            this.Text = "DnevniPrometi";
            this.Load += new System.EventHandler(this.DnevniPrometi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnevniPrometiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource apVarazdinDataSetBindingSource;
        private apVarazdinDataSet apVarazdinDataSet;
        private System.Windows.Forms.BindingSource apVarazdinDataSetBindingSource1;
        private System.Windows.Forms.BindingSource autobusiBindingSource;
        private apVarazdinDataSetTableAdapters.AutobusiTableAdapter autobusiTableAdapter;
        private apVarazdinDataSet1 apVarazdinDataSet1;
        private System.Windows.Forms.BindingSource dnevniPrometiBindingSource;
        private apVarazdinDataSet1TableAdapters.DnevniPrometiTableAdapter dnevniPrometiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosDataGridViewTextBoxColumn;
    }
}