namespace iceparlor
{
    partial class MENU
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
            this.menuGridView1 = new System.Windows.Forms.DataGridView();
            this.flavouridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.icrecreamparlorDataSet2 = new iceparlor.icrecreamparlorDataSet2();
            this.menuTableAdapter = new iceparlor.icrecreamparlorDataSet2TableAdapters.menuTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flavors = new System.Windows.Forms.ComboBox();
            this.flavorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flavoursDataSet = new iceparlor.flavoursDataSet();
            this.flavorsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.flavorDataSet3 = new iceparlor.flavorDataSet3();
            this.containers = new System.Windows.Forms.ComboBox();
            this.containersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.icrecreamparlorDataSet3 = new iceparlor.icrecreamparlorDataSet3();
            this.flavorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flavorsTableAdapter = new iceparlor.flavoursDataSetTableAdapters.flavorsTableAdapter();
            this.flavorsTableAdapter1 = new iceparlor.flavorDataSet3TableAdapters.flavorsTableAdapter();
            this.containersTableAdapter = new iceparlor.icrecreamparlorDataSet3TableAdapters.containersTableAdapter();
            this.flavor_id = new System.Windows.Forms.TextBox();
            this.container_id = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icrecreamparlorDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flavorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flavoursDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flavorsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flavorDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icrecreamparlorDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flavorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuGridView1
            // 
            this.menuGridView1.AllowUserToOrderColumns = true;
            this.menuGridView1.AutoGenerateColumns = false;
            this.menuGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menuGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flavouridDataGridViewTextBoxColumn,
            this.containeridDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.menuidDataGridViewTextBoxColumn});
            this.menuGridView1.DataSource = this.menuBindingSource;
            this.menuGridView1.Location = new System.Drawing.Point(0, 134);
            this.menuGridView1.Name = "menuGridView1";
            this.menuGridView1.Size = new System.Drawing.Size(715, 265);
            this.menuGridView1.TabIndex = 0;
            this.menuGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // menuidDataGridViewTextBoxColumn
            // 
            this.menuidDataGridViewTextBoxColumn.DataPropertyName = "menu_id";
            this.menuidDataGridViewTextBoxColumn.HeaderText = "menu_id";
            this.menuidDataGridViewTextBoxColumn.Name = "menuidDataGridViewTextBoxColumn";
            this.menuidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "menu";
            this.menuBindingSource.DataSource = this.icrecreamparlorDataSet2;
            // 
            // icrecreamparlorDataSet2
            // 
            this.icrecreamparlorDataSet2.DataSetName = "icrecreamparlorDataSet2";
            this.icrecreamparlorDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Get FlavorID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Get Container ID:";
            // 
            // flavors
            // 
            this.flavors.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.flavorsBindingSource1, "flavour_id", true));
            this.flavors.DataSource = this.flavorsBindingSource2;
            this.flavors.DisplayMember = "flavour_name";
            this.flavors.FormattingEnabled = true;
            this.flavors.Location = new System.Drawing.Point(15, 25);
            this.flavors.Name = "flavors";
            this.flavors.Size = new System.Drawing.Size(121, 21);
            this.flavors.TabIndex = 3;
            this.flavors.ValueMember = "flavour_id";
            this.flavors.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // flavorsBindingSource1
            // 
            this.flavorsBindingSource1.DataMember = "flavors";
            this.flavorsBindingSource1.DataSource = this.flavoursDataSet;
            // 
            // flavoursDataSet
            // 
            this.flavoursDataSet.DataSetName = "flavoursDataSet";
            this.flavoursDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flavorsBindingSource2
            // 
            this.flavorsBindingSource2.DataMember = "flavors";
            this.flavorsBindingSource2.DataSource = this.flavorDataSet3;
            // 
            // flavorDataSet3
            // 
            this.flavorDataSet3.DataSetName = "flavorDataSet3";
            this.flavorDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // containers
            // 
            this.containers.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.containersBindingSource, "container_id", true));
            this.containers.DataSource = this.containersBindingSource;
            this.containers.DisplayMember = "container_name";
            this.containers.FormattingEnabled = true;
            this.containers.Location = new System.Drawing.Point(161, 25);
            this.containers.Name = "containers";
            this.containers.Size = new System.Drawing.Size(121, 21);
            this.containers.TabIndex = 4;
            this.containers.ValueMember = "container_id";
            this.containers.SelectedIndexChanged += new System.EventHandler(this.containers_SelectedIndexChanged);
            // 
            // containersBindingSource
            // 
            this.containersBindingSource.DataMember = "containers";
            this.containersBindingSource.DataSource = this.icrecreamparlorDataSet3;
            // 
            // icrecreamparlorDataSet3
            // 
            this.icrecreamparlorDataSet3.DataSetName = "icrecreamparlorDataSet3";
            this.icrecreamparlorDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flavorsBindingSource
            // 
            this.flavorsBindingSource.DataMember = "flavors";
            this.flavorsBindingSource.DataSource = this.flavoursDataSet;
            // 
            // flavorsTableAdapter
            // 
            this.flavorsTableAdapter.ClearBeforeFill = true;
            // 
            // flavorsTableAdapter1
            // 
            this.flavorsTableAdapter1.ClearBeforeFill = true;
            // 
            // containersTableAdapter
            // 
            this.containersTableAdapter.ClearBeforeFill = true;
            // 
            // flavor_id
            // 
            this.flavor_id.Location = new System.Drawing.Point(15, 64);
            this.flavor_id.Name = "flavor_id";
            this.flavor_id.Size = new System.Drawing.Size(100, 20);
            this.flavor_id.TabIndex = 5;
            // 
            // container_id
            // 
            this.container_id.Location = new System.Drawing.Point(161, 64);
            this.container_id.Name = "container_id";
            this.container_id.Size = new System.Drawing.Size(100, 20);
            this.container_id.TabIndex = 6;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(425, 64);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 20);
            this.price.TabIndex = 7;
            this.price.TextChanged += new System.EventHandler(this.c);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(425, 25);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 20);
            this.amount.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Amount";
            this.label3.TextChanged += new System.EventHandler(this.cv);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(587, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 401);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.price);
            this.Controls.Add(this.container_id);
            this.Controls.Add(this.flavor_id);
            this.Controls.Add(this.containers);
            this.Controls.Add(this.flavors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuGridView1);
            this.Name = "MENU";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.MENU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icrecreamparlorDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flavorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flavoursDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flavorsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flavorDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icrecreamparlorDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flavorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView menuGridView1;
        private icrecreamparlorDataSet2 icrecreamparlorDataSet2;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private icrecreamparlorDataSet2TableAdapters.menuTableAdapter menuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn flavouridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn containeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox flavors;
        private System.Windows.Forms.ComboBox containers;
        private flavoursDataSet flavoursDataSet;
        private System.Windows.Forms.BindingSource flavorsBindingSource;
        private flavoursDataSetTableAdapters.flavorsTableAdapter flavorsTableAdapter;
        private System.Windows.Forms.BindingSource flavorsBindingSource1;
        private flavorDataSet3 flavorDataSet3;
        private System.Windows.Forms.BindingSource flavorsBindingSource2;
        private flavorDataSet3TableAdapters.flavorsTableAdapter flavorsTableAdapter1;
        private icrecreamparlorDataSet3 icrecreamparlorDataSet3;
        private System.Windows.Forms.BindingSource containersBindingSource;
        private icrecreamparlorDataSet3TableAdapters.containersTableAdapter containersTableAdapter;
        private System.Windows.Forms.TextBox flavor_id;
        private System.Windows.Forms.TextBox container_id;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}