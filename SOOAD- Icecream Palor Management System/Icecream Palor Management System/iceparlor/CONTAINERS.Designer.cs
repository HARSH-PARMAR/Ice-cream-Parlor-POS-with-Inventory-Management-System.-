namespace iceparlor
{
    partial class CONTAINERS
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
            this.updateContainerGridView1 = new System.Windows.Forms.DataGridView();
            this.CONTAINERDataSet4 = new iceparlor.icrecreamparlorDataSet4();
            this.containersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.containersTableAdapter = new iceparlor.icrecreamparlorDataSet4TableAdapters.containersTableAdapter();
            this.containernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containerName = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.Label();
            this.add_containerName = new System.Windows.Forms.TextBox();
            this.add_containerUnit = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updateContainerGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAINERDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.containersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // updateContainerGridView1
            // 
            this.updateContainerGridView1.AutoGenerateColumns = false;
            this.updateContainerGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.updateContainerGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.containernameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.containeridDataGridViewTextBoxColumn});
            this.updateContainerGridView1.DataSource = this.containersBindingSource;
            this.updateContainerGridView1.Location = new System.Drawing.Point(255, 41);
            this.updateContainerGridView1.Name = "updateContainerGridView1";
            this.updateContainerGridView1.Size = new System.Drawing.Size(305, 376);
            this.updateContainerGridView1.TabIndex = 0;
            this.updateContainerGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CONTAINERDataSet4
            // 
            this.CONTAINERDataSet4.DataSetName = "CONTAINERDataSet4";
            this.CONTAINERDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // containersBindingSource
            // 
            this.containersBindingSource.DataMember = "containers";
            this.containersBindingSource.DataSource = this.CONTAINERDataSet4;
            // 
            // containersTableAdapter
            // 
            this.containersTableAdapter.ClearBeforeFill = true;
            // 
            // containernameDataGridViewTextBoxColumn
            // 
            this.containernameDataGridViewTextBoxColumn.DataPropertyName = "container_name";
            this.containernameDataGridViewTextBoxColumn.HeaderText = "container_name";
            this.containernameDataGridViewTextBoxColumn.Name = "containernameDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // containeridDataGridViewTextBoxColumn
            // 
            this.containeridDataGridViewTextBoxColumn.DataPropertyName = "container_id";
            this.containeridDataGridViewTextBoxColumn.HeaderText = "container_id";
            this.containeridDataGridViewTextBoxColumn.Name = "containeridDataGridViewTextBoxColumn";
            this.containeridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // containerName
            // 
            this.containerName.AutoSize = true;
            this.containerName.Location = new System.Drawing.Point(12, 48);
            this.containerName.Name = "containerName";
            this.containerName.Size = new System.Drawing.Size(70, 13);
            this.containerName.TabIndex = 1;
            this.containerName.Text = "CONTAINER";
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Location = new System.Drawing.Point(12, 113);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(33, 13);
            this.unit.TabIndex = 3;
            this.unit.Text = "UNIT";
            // 
            // add_containerName
            // 
            this.add_containerName.Location = new System.Drawing.Point(136, 41);
            this.add_containerName.Name = "add_containerName";
            this.add_containerName.Size = new System.Drawing.Size(100, 20);
            this.add_containerName.TabIndex = 4;
            // 
            // add_containerUnit
            // 
            this.add_containerUnit.Location = new System.Drawing.Point(136, 106);
            this.add_containerUnit.Name = "add_containerUnit";
            this.add_containerUnit.Size = new System.Drawing.Size(100, 20);
            this.add_containerUnit.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(31, 202);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 37);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(161, 202);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 37);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // CONTAINERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 488);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.add_containerUnit);
            this.Controls.Add(this.add_containerName);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.containerName);
            this.Controls.Add(this.updateContainerGridView1);
            this.Name = "CONTAINERS";
            this.Text = "CONTAINERS";
            this.Load += new System.EventHandler(this.CONTAINERS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updateContainerGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONTAINERDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.containersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView updateContainerGridView1;
        private icrecreamparlorDataSet4 CONTAINERDataSet4;
        private System.Windows.Forms.BindingSource containersBindingSource;
        private icrecreamparlorDataSet4TableAdapters.containersTableAdapter containersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn containernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn containeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label containerName;
        private System.Windows.Forms.Label unit;
        private System.Windows.Forms.TextBox add_containerName;
        private System.Windows.Forms.TextBox add_containerUnit;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
    }
}