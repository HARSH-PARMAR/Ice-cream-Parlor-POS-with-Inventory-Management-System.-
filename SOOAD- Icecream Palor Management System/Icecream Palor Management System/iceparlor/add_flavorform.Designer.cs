namespace iceparlor
{
    partial class addFlavor
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
            this.addGridVIew = new System.Windows.Forms.DataGridView();
            this.flavournameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flavourunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flavouridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flavorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addFlavorsDataSet2 = new iceparlor.addFlavorsDataSet2();
            this.flavorsTableAdapter = new iceparlor.addFlavorsDataSet2TableAdapters.flavorsTableAdapter();
            this.flavorName = new System.Windows.Forms.Label();
            this.VOLUME = new System.Windows.Forms.Label();
            this.addvolume = new System.Windows.Forms.TextBox();
            this.addname = new System.Windows.Forms.TextBox();
            this.updateflavor = new System.Windows.Forms.Button();
            this.addFlavour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addGridVIew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flavorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFlavorsDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // addGridVIew
            // 
            this.addGridVIew.AllowUserToOrderColumns = true;
            this.addGridVIew.AutoGenerateColumns = false;
            this.addGridVIew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addGridVIew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addGridVIew.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flavournameDataGridViewTextBoxColumn,
            this.flavourunitDataGridViewTextBoxColumn,
            this.flavouridDataGridViewTextBoxColumn});
            this.addGridVIew.DataSource = this.flavorsBindingSource;
            this.addGridVIew.Location = new System.Drawing.Point(214, 35);
            this.addGridVIew.Name = "addGridVIew";
            this.addGridVIew.Size = new System.Drawing.Size(281, 351);
            this.addGridVIew.TabIndex = 0;
            this.addGridVIew.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addGridVIew_CellClick);
            // 
            // flavournameDataGridViewTextBoxColumn
            // 
            this.flavournameDataGridViewTextBoxColumn.DataPropertyName = "flavour_name";
            this.flavournameDataGridViewTextBoxColumn.HeaderText = "flavour_name";
            this.flavournameDataGridViewTextBoxColumn.Name = "flavournameDataGridViewTextBoxColumn";
            // 
            // flavourunitDataGridViewTextBoxColumn
            // 
            this.flavourunitDataGridViewTextBoxColumn.DataPropertyName = "flavour_unit";
            this.flavourunitDataGridViewTextBoxColumn.HeaderText = "flavour_unit";
            this.flavourunitDataGridViewTextBoxColumn.Name = "flavourunitDataGridViewTextBoxColumn";
            // 
            // flavouridDataGridViewTextBoxColumn
            // 
            this.flavouridDataGridViewTextBoxColumn.DataPropertyName = "flavour_id";
            this.flavouridDataGridViewTextBoxColumn.HeaderText = "flavour_id";
            this.flavouridDataGridViewTextBoxColumn.Name = "flavouridDataGridViewTextBoxColumn";
            this.flavouridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flavorsBindingSource
            // 
            this.flavorsBindingSource.DataMember = "flavors";
            this.flavorsBindingSource.DataSource = this.addFlavorsDataSet2;
            // 
            // addFlavorsDataSet2
            // 
            this.addFlavorsDataSet2.DataSetName = "addFlavorsDataSet2";
            this.addFlavorsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flavorsTableAdapter
            // 
            this.flavorsTableAdapter.ClearBeforeFill = true;
            // 
            // flavorName
            // 
            this.flavorName.AutoSize = true;
            this.flavorName.Location = new System.Drawing.Point(17, 52);
            this.flavorName.Name = "flavorName";
            this.flavorName.Size = new System.Drawing.Size(38, 13);
            this.flavorName.TabIndex = 1;
            this.flavorName.Text = "NAME";
            // 
            // VOLUME
            // 
            this.VOLUME.AutoSize = true;
            this.VOLUME.Location = new System.Drawing.Point(17, 93);
            this.VOLUME.Name = "VOLUME";
            this.VOLUME.Size = new System.Drawing.Size(52, 13);
            this.VOLUME.TabIndex = 2;
            this.VOLUME.Text = "VOLUME";
            // 
            // addvolume
            // 
            this.addvolume.Location = new System.Drawing.Point(86, 93);
            this.addvolume.Name = "addvolume";
            this.addvolume.Size = new System.Drawing.Size(100, 20);
            this.addvolume.TabIndex = 4;
            // 
            // addname
            // 
            this.addname.Location = new System.Drawing.Point(86, 52);
            this.addname.Name = "addname";
            this.addname.Size = new System.Drawing.Size(100, 20);
            this.addname.TabIndex = 5;
            // 
            // updateflavor
            // 
            this.updateflavor.Location = new System.Drawing.Point(86, 228);
            this.updateflavor.Name = "updateflavor";
            this.updateflavor.Size = new System.Drawing.Size(75, 23);
            this.updateflavor.TabIndex = 7;
            this.updateflavor.Text = "UPDATE";
            this.updateflavor.UseVisualStyleBackColor = true;
            this.updateflavor.Click += new System.EventHandler(this.updateflavor_Click);
            // 
            // addFlavour
            // 
            this.addFlavour.Location = new System.Drawing.Point(86, 176);
            this.addFlavour.Name = "addFlavour";
            this.addFlavour.Size = new System.Drawing.Size(75, 23);
            this.addFlavour.TabIndex = 9;
            this.addFlavour.Text = "ADD";
            this.addFlavour.UseVisualStyleBackColor = true;
            this.addFlavour.Click += new System.EventHandler(this.addFlavour_Click);
            // 
            // addFlavor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 390);
            this.Controls.Add(this.addFlavour);
            this.Controls.Add(this.updateflavor);
            this.Controls.Add(this.addname);
            this.Controls.Add(this.addvolume);
            this.Controls.Add(this.VOLUME);
            this.Controls.Add(this.flavorName);
            this.Controls.Add(this.addGridVIew);
            this.Name = "addFlavor";
            this.Text = "add_flavorform";
            this.Load += new System.EventHandler(this.add_flavorform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addGridVIew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flavorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addFlavorsDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView addGridVIew;
        private addFlavorsDataSet2 addFlavorsDataSet2;
        private System.Windows.Forms.BindingSource flavorsBindingSource;
        private addFlavorsDataSet2TableAdapters.flavorsTableAdapter flavorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn flavournameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flavourunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flavouridDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label flavorName;
        private System.Windows.Forms.Label VOLUME;
        private System.Windows.Forms.TextBox addvolume;
        private System.Windows.Forms.TextBox addname;
        private System.Windows.Forms.Button updateflavor;
        private System.Windows.Forms.Button addFlavour;

    }
}