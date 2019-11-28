namespace tech_spech_2
{
    partial class cartridge
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tech_specDataSet = new tech_spech_2.tech_specDataSet();
            this.cartridgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartridgeTableAdapter = new tech_spech_2.tech_specDataSetTableAdapters.cartridgeTableAdapter();
            this.cartridgeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufactureidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owneridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartridgeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "New cartridge";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cartridgeidDataGridViewTextBoxColumn,
            this.manufactureidDataGridViewTextBoxColumn,
            this.modelidDataGridViewTextBoxColumn,
            this.workidDataGridViewTextBoxColumn,
            this.clientidDataGridViewTextBoxColumn,
            this.owneridDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cartridgeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // tech_specDataSet
            // 
            this.tech_specDataSet.DataSetName = "tech_specDataSet";
            this.tech_specDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartridgeBindingSource
            // 
            this.cartridgeBindingSource.DataMember = "cartridge";
            this.cartridgeBindingSource.DataSource = this.tech_specDataSet;
            // 
            // cartridgeTableAdapter
            // 
            this.cartridgeTableAdapter.ClearBeforeFill = true;
            // 
            // cartridgeidDataGridViewTextBoxColumn
            // 
            this.cartridgeidDataGridViewTextBoxColumn.DataPropertyName = "cartridge_id";
            this.cartridgeidDataGridViewTextBoxColumn.HeaderText = "cartridge_id";
            this.cartridgeidDataGridViewTextBoxColumn.Name = "cartridgeidDataGridViewTextBoxColumn";
            // 
            // manufactureidDataGridViewTextBoxColumn
            // 
            this.manufactureidDataGridViewTextBoxColumn.DataPropertyName = "manufacture_id";
            this.manufactureidDataGridViewTextBoxColumn.HeaderText = "manufacture_id";
            this.manufactureidDataGridViewTextBoxColumn.Name = "manufactureidDataGridViewTextBoxColumn";
            // 
            // modelidDataGridViewTextBoxColumn
            // 
            this.modelidDataGridViewTextBoxColumn.DataPropertyName = "model_id";
            this.modelidDataGridViewTextBoxColumn.HeaderText = "model_id";
            this.modelidDataGridViewTextBoxColumn.Name = "modelidDataGridViewTextBoxColumn";
            // 
            // workidDataGridViewTextBoxColumn
            // 
            this.workidDataGridViewTextBoxColumn.DataPropertyName = "work_id";
            this.workidDataGridViewTextBoxColumn.HeaderText = "work_id";
            this.workidDataGridViewTextBoxColumn.Name = "workidDataGridViewTextBoxColumn";
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            // 
            // owneridDataGridViewTextBoxColumn
            // 
            this.owneridDataGridViewTextBoxColumn.DataPropertyName = "owner_id";
            this.owneridDataGridViewTextBoxColumn.HeaderText = "owner_id";
            this.owneridDataGridViewTextBoxColumn.Name = "owneridDataGridViewTextBoxColumn";
            // 
            // cartridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 200);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "cartridge";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.cartridge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_specDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartridgeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private tech_specDataSet tech_specDataSet;
        private System.Windows.Forms.BindingSource cartridgeBindingSource;
        private tech_specDataSetTableAdapters.cartridgeTableAdapter cartridgeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartridgeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufactureidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn owneridDataGridViewTextBoxColumn;
    }
}