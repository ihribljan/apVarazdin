namespace APVarazdin
{
    partial class PoslovniPartneri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoslovniPartneri));
            this.vPoslovniPartneriTableAdapter = new APVarazdin.apVarazdinDataSet3TableAdapters.vPoslovniPartneriTableAdapter();
            this.vPoslovniPartneriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.apVarazdinDataSet6 = new APVarazdin.apVarazdinDataSet6();
            this.vPoslovniPartneriBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vPoslovniPartneriTableAdapter1 = new APVarazdin.apVarazdinDataSet6TableAdapters.vPoslovniPartneriTableAdapter();
            this.apVarazdinDataSet8 = new APVarazdin.apVarazdinDataSet8();
            this.vPoslovniPartneriTableAdapter2 = new APVarazdin.apVarazdinDataSet8TableAdapters.vPoslovniPartneriTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vPoslovniPartneriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apVarazdinDataSet9 = new APVarazdin.apVarazdinDataSet9();
            this.vPoslovniPartneriTableAdapter3 = new APVarazdin.apVarazdinDataSet9TableAdapters.vPoslovniPartneriTableAdapter();
            this.apVarazdinDataSet8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mjestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vPoslovniPartneriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPoslovniPartneriBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPoslovniPartneriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet8BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vPoslovniPartneriTableAdapter
            // 
            this.vPoslovniPartneriTableAdapter.ClearBeforeFill = true;
            // 
            // apVarazdinDataSet6
            // 
            this.apVarazdinDataSet6.DataSetName = "apVarazdinDataSet6";
            this.apVarazdinDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vPoslovniPartneriBindingSource2
            // 
            this.vPoslovniPartneriBindingSource2.DataMember = "vPoslovniPartneri";
            this.vPoslovniPartneriBindingSource2.DataSource = this.apVarazdinDataSet6;
            // 
            // vPoslovniPartneriTableAdapter1
            // 
            this.vPoslovniPartneriTableAdapter1.ClearBeforeFill = true;
            // 
            // apVarazdinDataSet8
            // 
            this.apVarazdinDataSet8.DataSetName = "apVarazdinDataSet8";
            this.apVarazdinDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vPoslovniPartneriTableAdapter2
            // 
            this.vPoslovniPartneriTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.oibDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.mjestoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vPoslovniPartneriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // vPoslovniPartneriBindingSource
            // 
            this.vPoslovniPartneriBindingSource.DataMember = "vPoslovniPartneri";
            this.vPoslovniPartneriBindingSource.DataSource = this.apVarazdinDataSet9;
            // 
            // apVarazdinDataSet9
            // 
            this.apVarazdinDataSet9.DataSetName = "apVarazdinDataSet9";
            this.apVarazdinDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vPoslovniPartneriTableAdapter3
            // 
            this.vPoslovniPartneriTableAdapter3.ClearBeforeFill = true;
            // 
            // apVarazdinDataSet8BindingSource
            // 
            this.apVarazdinDataSet8BindingSource.DataSource = this.apVarazdinDataSet8;
            this.apVarazdinDataSet8BindingSource.Position = 0;
            // 
            // mjestoDataGridViewTextBoxColumn
            // 
            this.mjestoDataGridViewTextBoxColumn.DataPropertyName = "Mjesto";
            this.mjestoDataGridViewTextBoxColumn.HeaderText = "Mjesto";
            this.mjestoDataGridViewTextBoxColumn.Name = "mjestoDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.Width = 150;
            // 
            // oibDataGridViewTextBoxColumn
            // 
            this.oibDataGridViewTextBoxColumn.DataPropertyName = "Oib";
            this.oibDataGridViewTextBoxColumn.HeaderText = "Oib";
            this.oibDataGridViewTextBoxColumn.Name = "oibDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 150;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // PoslovniPartneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 280);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PoslovniPartneri";
            this.Text = "PoslovniPartneri";
            this.Load += new System.EventHandler(this.PoslovniPartneri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vPoslovniPartneriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPoslovniPartneriBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPoslovniPartneriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apVarazdinDataSet8BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private apVarazdinDataSet3TableAdapters.vPoslovniPartneriTableAdapter vPoslovniPartneriTableAdapter;
        private System.Windows.Forms.BindingSource vPoslovniPartneriBindingSource1;
        private apVarazdinDataSet6 apVarazdinDataSet6;
        private System.Windows.Forms.BindingSource vPoslovniPartneriBindingSource2;
        private apVarazdinDataSet6TableAdapters.vPoslovniPartneriTableAdapter vPoslovniPartneriTableAdapter1;
        private apVarazdinDataSet8 apVarazdinDataSet8;
        private apVarazdinDataSet8TableAdapters.vPoslovniPartneriTableAdapter vPoslovniPartneriTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private apVarazdinDataSet9 apVarazdinDataSet9;
        private System.Windows.Forms.BindingSource vPoslovniPartneriBindingSource;
        private apVarazdinDataSet9TableAdapters.vPoslovniPartneriTableAdapter vPoslovniPartneriTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource apVarazdinDataSet8BindingSource;
    }
}