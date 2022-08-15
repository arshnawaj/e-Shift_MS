namespace e_Shift_MS
{
    partial class SearchCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCustomers));
            this.layout = new System.Windows.Forms.Panel();
            this.gridViewArea = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Customer = new e_Shift_MS.DataSet_Customer();
            this.searchArea = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbtnInactive = new System.Windows.Forms.RadioButton();
            this.rdbtnActive = new System.Windows.Forms.RadioButton();
            this.rdbtnAll = new System.Windows.Forms.RadioButton();
            this.txtSearchVal = new System.Windows.Forms.TextBox();
            this.tbl_CustomerTableAdapter = new e_Shift_MS.DataSet_CustomerTableAdapters.Tbl_CustomerTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.layout.SuspendLayout();
            this.gridViewArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Customer)).BeginInit();
            this.searchArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.Controls.Add(this.gridViewArea);
            this.layout.Controls.Add(this.searchArea);
            this.layout.Dock = System.Windows.Forms.DockStyle.Top;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(800, 453);
            this.layout.TabIndex = 0;
            // 
            // gridViewArea
            // 
            this.gridViewArea.Controls.Add(this.pictureBox1);
            this.gridViewArea.Controls.Add(this.dataGridView1);
            this.gridViewArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewArea.Location = new System.Drawing.Point(0, 100);
            this.gridViewArea.Name = "gridViewArea";
            this.gridViewArea.Size = new System.Drawing.Size(800, 353);
            this.gridViewArea.TabIndex = 1;
            this.gridViewArea.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.cusNameDataGridViewTextBoxColumn,
            this.cusNICDataGridViewTextBoxColumn,
            this.cusAddressDataGridViewTextBoxColumn,
            this.cusContactDataGridViewTextBoxColumn,
            this.cusStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCustomerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cusNameDataGridViewTextBoxColumn
            // 
            this.cusNameDataGridViewTextBoxColumn.DataPropertyName = "cusName";
            this.cusNameDataGridViewTextBoxColumn.HeaderText = "cusName";
            this.cusNameDataGridViewTextBoxColumn.Name = "cusNameDataGridViewTextBoxColumn";
            // 
            // cusNICDataGridViewTextBoxColumn
            // 
            this.cusNICDataGridViewTextBoxColumn.DataPropertyName = "cusNIC";
            this.cusNICDataGridViewTextBoxColumn.HeaderText = "cusNIC";
            this.cusNICDataGridViewTextBoxColumn.Name = "cusNICDataGridViewTextBoxColumn";
            // 
            // cusAddressDataGridViewTextBoxColumn
            // 
            this.cusAddressDataGridViewTextBoxColumn.DataPropertyName = "cusAddress";
            this.cusAddressDataGridViewTextBoxColumn.HeaderText = "cusAddress";
            this.cusAddressDataGridViewTextBoxColumn.Name = "cusAddressDataGridViewTextBoxColumn";
            // 
            // cusContactDataGridViewTextBoxColumn
            // 
            this.cusContactDataGridViewTextBoxColumn.DataPropertyName = "cusContact";
            this.cusContactDataGridViewTextBoxColumn.HeaderText = "cusContact";
            this.cusContactDataGridViewTextBoxColumn.Name = "cusContactDataGridViewTextBoxColumn";
            // 
            // cusStatusDataGridViewTextBoxColumn
            // 
            this.cusStatusDataGridViewTextBoxColumn.DataPropertyName = "cusStatus";
            this.cusStatusDataGridViewTextBoxColumn.HeaderText = "cusStatus";
            this.cusStatusDataGridViewTextBoxColumn.Name = "cusStatusDataGridViewTextBoxColumn";
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "Tbl_Customer";
            this.tblCustomerBindingSource.DataSource = this.dataSet_Customer;
            // 
            // dataSet_Customer
            // 
            this.dataSet_Customer.DataSetName = "DataSet_Customer";
            this.dataSet_Customer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchArea
            // 
            this.searchArea.Controls.Add(this.button2);
            this.searchArea.Controls.Add(this.button1);
            this.searchArea.Controls.Add(this.label1);
            this.searchArea.Controls.Add(this.rdbtnInactive);
            this.searchArea.Controls.Add(this.rdbtnActive);
            this.searchArea.Controls.Add(this.rdbtnAll);
            this.searchArea.Controls.Add(this.txtSearchVal);
            this.searchArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchArea.Location = new System.Drawing.Point(0, 0);
            this.searchArea.Name = "searchArea";
            this.searchArea.Size = new System.Drawing.Size(800, 100);
            this.searchArea.TabIndex = 0;
            this.searchArea.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search by Name";
            // 
            // rdbtnInactive
            // 
            this.rdbtnInactive.AutoSize = true;
            this.rdbtnInactive.Location = new System.Drawing.Point(667, 52);
            this.rdbtnInactive.Name = "rdbtnInactive";
            this.rdbtnInactive.Size = new System.Drawing.Size(63, 17);
            this.rdbtnInactive.TabIndex = 3;
            this.rdbtnInactive.TabStop = true;
            this.rdbtnInactive.Text = "Inactive";
            this.rdbtnInactive.UseVisualStyleBackColor = true;
            this.rdbtnInactive.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdbtnActive
            // 
            this.rdbtnActive.AutoSize = true;
            this.rdbtnActive.Location = new System.Drawing.Point(532, 52);
            this.rdbtnActive.Name = "rdbtnActive";
            this.rdbtnActive.Size = new System.Drawing.Size(55, 17);
            this.rdbtnActive.TabIndex = 2;
            this.rdbtnActive.TabStop = true;
            this.rdbtnActive.Text = "Active";
            this.rdbtnActive.UseVisualStyleBackColor = true;
            this.rdbtnActive.CheckedChanged += new System.EventHandler(this.rdbtnActive_CheckedChanged);
            // 
            // rdbtnAll
            // 
            this.rdbtnAll.AutoSize = true;
            this.rdbtnAll.Location = new System.Drawing.Point(398, 56);
            this.rdbtnAll.Name = "rdbtnAll";
            this.rdbtnAll.Size = new System.Drawing.Size(36, 17);
            this.rdbtnAll.TabIndex = 1;
            this.rdbtnAll.TabStop = true;
            this.rdbtnAll.Text = "All";
            this.rdbtnAll.UseVisualStyleBackColor = true;
            this.rdbtnAll.CheckedChanged += new System.EventHandler(this.rdbtnAll_CheckedChanged);
            // 
            // txtSearchVal
            // 
            this.txtSearchVal.Location = new System.Drawing.Point(118, 42);
            this.txtSearchVal.Multiline = true;
            this.txtSearchVal.Name = "txtSearchVal";
            this.txtSearchVal.Size = new System.Drawing.Size(241, 45);
            this.txtSearchVal.TabIndex = 0;
            this.txtSearchVal.TextChanged += new System.EventHandler(this.txtSearchVal_TextChanged);
            // 
            // tbl_CustomerTableAdapter
            // 
            this.tbl_CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(710, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(725, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // SearchCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layout);
            this.Name = "SearchCustomers";
            this.Text = "SearchCustomers";
            this.Load += new System.EventHandler(this.SearchCustomers_Load);
            this.layout.ResumeLayout(false);
            this.gridViewArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Customer)).EndInit();
            this.searchArea.ResumeLayout(false);
            this.searchArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel layout;
        private System.Windows.Forms.GroupBox gridViewArea;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox searchArea;
        private DataSet_Customer dataSet_Customer;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private DataSet_CustomerTableAdapters.Tbl_CustomerTableAdapter tbl_CustomerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusNICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearchVal;
        private System.Windows.Forms.RadioButton rdbtnInactive;
        private System.Windows.Forms.RadioButton rdbtnActive;
        private System.Windows.Forms.RadioButton rdbtnAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}