namespace PriceCompareUI.Forms
{
    partial class StoresForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chainIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._PriceCompareFramework_Handlers_DatabaseTDataSet1 = new PriceCompareUI._PriceCompareFramework_Handlers_DatabaseTDataSet1();
            this.storesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._PriceCompareFramework_Handlers_DatabaseTDataSet = new PriceCompareUI._PriceCompareFramework_Handlers_DatabaseTDataSet();
            this.storesTableAdapter = new PriceCompareUI._PriceCompareFramework_Handlers_DatabaseTDataSetTableAdapters.StoresTableAdapter();
            this.storesTableAdapter1 = new PriceCompareUI._PriceCompareFramework_Handlers_DatabaseTDataSet1TableAdapters.StoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PriceCompareFramework_Handlers_DatabaseTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PriceCompareFramework_Handlers_DatabaseTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.StoreName,
            this.chainIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.storesBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(347, 238);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 50F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // StoreName
            // 
            this.StoreName.DataPropertyName = "StoreName";
            this.StoreName.FillWeight = 150F;
            this.StoreName.HeaderText = "StoreName";
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            this.StoreName.Width = 150;
            // 
            // chainIdDataGridViewTextBoxColumn
            // 
            this.chainIdDataGridViewTextBoxColumn.DataPropertyName = "ChainId";
            this.chainIdDataGridViewTextBoxColumn.HeaderText = "ChainId";
            this.chainIdDataGridViewTextBoxColumn.Name = "chainIdDataGridViewTextBoxColumn";
            this.chainIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storesBindingSource1
            // 
            this.storesBindingSource1.DataMember = "Stores";
            this.storesBindingSource1.DataSource = this._PriceCompareFramework_Handlers_DatabaseTDataSet1;
            // 
            // _PriceCompareFramework_Handlers_DatabaseTDataSet1
            // 
            this._PriceCompareFramework_Handlers_DatabaseTDataSet1.DataSetName = "_PriceCompareFramework_Handlers_DatabaseTDataSet1";
            this._PriceCompareFramework_Handlers_DatabaseTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storesBindingSource
            // 
            this.storesBindingSource.DataMember = "Stores";
            this.storesBindingSource.DataSource = this._PriceCompareFramework_Handlers_DatabaseTDataSet;
            // 
            // _PriceCompareFramework_Handlers_DatabaseTDataSet
            // 
            this._PriceCompareFramework_Handlers_DatabaseTDataSet.DataSetName = "_PriceCompareFramework_Handlers_DatabaseTDataSet";
            this._PriceCompareFramework_Handlers_DatabaseTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storesTableAdapter
            // 
            this.storesTableAdapter.ClearBeforeFill = true;
            // 
            // storesTableAdapter1
            // 
            this.storesTableAdapter1.ClearBeforeFill = true;
            // 
            // StoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 238);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StoresForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PriceCompareFramework_Handlers_DatabaseTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PriceCompareFramework_Handlers_DatabaseTDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _PriceCompareFramework_Handlers_DatabaseTDataSet _PriceCompareFramework_Handlers_DatabaseTDataSet;
        private System.Windows.Forms.BindingSource storesBindingSource;
        private _PriceCompareFramework_Handlers_DatabaseTDataSetTableAdapters.StoresTableAdapter storesTableAdapter;
        private _PriceCompareFramework_Handlers_DatabaseTDataSet1 _PriceCompareFramework_Handlers_DatabaseTDataSet1;
        private System.Windows.Forms.BindingSource storesBindingSource1;
        private _PriceCompareFramework_Handlers_DatabaseTDataSet1TableAdapters.StoresTableAdapter storesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chainIdDataGridViewTextBoxColumn;
    }
}