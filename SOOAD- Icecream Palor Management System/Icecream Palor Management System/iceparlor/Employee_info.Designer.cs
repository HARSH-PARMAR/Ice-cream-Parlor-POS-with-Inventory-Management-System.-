namespace iceparlor
{
    partial class Employee_info
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
            this.mobileNobox = new System.Windows.Forms.TextBox();
            this.adddressBox = new System.Windows.Forms.RichTextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.UPDATE = new System.Windows.Forms.Button();
            this.usersDataSet = new iceparlor.usersDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new iceparlor.usersDataSetTableAdapters.usersTableAdapter();
            this.userGridView1 = new System.Windows.Forms.DataGridView();
            this.managerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isManagarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mobileNobox
            // 
            this.mobileNobox.Location = new System.Drawing.Point(39, 36);
            this.mobileNobox.Name = "mobileNobox";
            this.mobileNobox.Size = new System.Drawing.Size(142, 20);
            this.mobileNobox.TabIndex = 1;
            // 
            // adddressBox
            // 
            this.adddressBox.Location = new System.Drawing.Point(39, 128);
            this.adddressBox.Name = "adddressBox";
            this.adddressBox.Size = new System.Drawing.Size(142, 96);
            this.adddressBox.TabIndex = 2;
            this.adddressBox.Text = "";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(39, 79);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(142, 20);
            this.passwordBox.TabIndex = 3;
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(39, 261);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(142, 20);
            this.typeBox.TabIndex = 4;
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(58, 306);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(95, 41);
            this.UPDATE.TabIndex = 5;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "usersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.usersDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // userGridView1
            // 
            this.userGridView1.AllowUserToOrderColumns = true;
            this.userGridView1.AutoGenerateColumns = false;
            this.userGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.managerIDDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.isManagarDataGridViewTextBoxColumn});
            this.userGridView1.DataSource = this.usersBindingSource;
            this.userGridView1.Location = new System.Drawing.Point(269, 36);
            this.userGridView1.Name = "userGridView1";
            this.userGridView1.Size = new System.Drawing.Size(382, 352);
            this.userGridView1.TabIndex = 6;
            this.userGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGridView1_CellClick);
            // 
            // managerIDDataGridViewTextBoxColumn
            // 
            this.managerIDDataGridViewTextBoxColumn.DataPropertyName = "ManagerID";
            this.managerIDDataGridViewTextBoxColumn.HeaderText = "ManagerID";
            this.managerIDDataGridViewTextBoxColumn.Name = "managerIDDataGridViewTextBoxColumn";
            this.managerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "mobileNo";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "mobileNo";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // isManagarDataGridViewTextBoxColumn
            // 
            this.isManagarDataGridViewTextBoxColumn.DataPropertyName = "isManagar";
            this.isManagarDataGridViewTextBoxColumn.HeaderText = "isManagar";
            this.isManagarDataGridViewTextBoxColumn.Name = "isManagarDataGridViewTextBoxColumn";
            // 
            // Employee_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 395);
            this.Controls.Add(this.userGridView1);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.adddressBox);
            this.Controls.Add(this.mobileNobox);
            this.Name = "Employee_info";
            this.Text = "Employee_info";
            this.Load += new System.EventHandler(this.Employee_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mobileNobox;
        private System.Windows.Forms.RichTextBox adddressBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Button UPDATE;
        private usersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private usersDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridView userGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isManagarDataGridViewTextBoxColumn;
    }
}