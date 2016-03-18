namespace iceparlor
{
    partial class Sales
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
            this.flavouridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDataSet2 = new iceparlor.salesDataSet2();
            this.salesTableAdapter = new iceparlor.salesDataSet2TableAdapters.salesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.salesId = new System.Windows.Forms.TextBox();
            this.searchbydate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flavouridDataGridViewTextBoxColumn,
            this.containeridDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.salesidDataGridViewTextBoxColumn,
            this.unitrateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(586, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // flavouridDataGridViewTextBoxColumn
            // 
            this.flavouridDataGridViewTextBoxColumn.DataPropertyName = "flavour_id";
            this.flavouridDataGridViewTextBoxColumn.HeaderText = "flavour_id";
            this.flavouridDataGridViewTextBoxColumn.Name = "flavouridDataGridViewTextBoxColumn";
            // 
            // containeridDataGridViewTextBoxColumn
            // 
            this.containeridDataGridViewTextBoxColumn.DataPropertyName = "container_id";
            this.containeridDataGridViewTextBoxColumn.HeaderText = "container_id";
            this.containeridDataGridViewTextBoxColumn.Name = "containeridDataGridViewTextBoxColumn";
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // salesidDataGridViewTextBoxColumn
            // 
            this.salesidDataGridViewTextBoxColumn.DataPropertyName = "sales_id";
            this.salesidDataGridViewTextBoxColumn.HeaderText = "sales_id";
            this.salesidDataGridViewTextBoxColumn.Name = "salesidDataGridViewTextBoxColumn";
            this.salesidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitrateDataGridViewTextBoxColumn
            // 
            this.unitrateDataGridViewTextBoxColumn.DataPropertyName = "unit_rate";
            this.unitrateDataGridViewTextBoxColumn.HeaderText = "unit_rate";
            this.unitrateDataGridViewTextBoxColumn.Name = "unitrateDataGridViewTextBoxColumn";
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "sales";
            this.salesBindingSource.DataSource = this.salesDataSet2;
            // 
            // salesDataSet2
            // 
            this.salesDataSet2.DataSetName = "salesDataSet2";
            this.salesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SEARCH BY DATE:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SEARCH BY SALES ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(24, 48);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(100, 20);
            this.date.TabIndex = 4;
            this.date.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // salesId
            // 
            this.salesId.Location = new System.Drawing.Point(440, 48);
            this.salesId.Name = "salesId";
            this.salesId.Size = new System.Drawing.Size(100, 20);
            this.salesId.TabIndex = 5;
            // 
            // searchbydate
            // 
            this.searchbydate.Location = new System.Drawing.Point(24, 88);
            this.searchbydate.Name = "searchbydate";
            this.searchbydate.Size = new System.Drawing.Size(75, 23);
            this.searchbydate.TabIndex = 6;
            this.searchbydate.Text = "SEARCH";
            this.searchbydate.UseVisualStyleBackColor = true;
            this.searchbydate.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "SEARCH";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 371);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchbydate);
            this.Controls.Add(this.salesId);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.updateMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private salesDataSet2 salesDataSet2;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private salesDataSet2TableAdapters.salesTableAdapter salesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn flavouridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn containeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox salesId;
        private System.Windows.Forms.Button searchbydate;
        private System.Windows.Forms.Button button2;
    }
}