namespace e_Shift_MS
{
    partial class CustomerReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerReport));
            this.tblCustomerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Customer = new e_Shift_MS.DataSet_Customer();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Tbl_CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tbl_CustomerTableAdapter = new e_Shift_MS.DataSet_CustomerTableAdapters.Tbl_CustomerTableAdapter();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCustomerBindingSource1
            // 
            this.tblCustomerBindingSource1.DataMember = "Tbl_Customer";
            this.tblCustomerBindingSource1.DataSource = this.dataSetCustomerBindingSource;
            // 
            // dataSetCustomerBindingSource
            // 
            this.dataSetCustomerBindingSource.DataSource = this.DataSet_Customer;
            this.dataSetCustomerBindingSource.Position = 0;
            // 
            // DataSet_Customer
            // 
            this.DataSet_Customer.DataSetName = "DataSet_Customer";
            this.DataSet_Customer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Reports";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "CustomerData";
            reportDataSource1.Value = this.tblCustomerBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "e_Shift_MS.CustomerReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(40, 119);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(759, 372);
            this.reportViewer1.TabIndex = 1;
            // 
            // Tbl_CustomerBindingSource
            // 
            this.Tbl_CustomerBindingSource.DataMember = "Tbl_Customer";
            this.Tbl_CustomerBindingSource.DataSource = this.DataSet_Customer;
            // 
            // Tbl_CustomerTableAdapter
            // 
            this.Tbl_CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "Tbl_Customer";
            this.tblCustomerBindingSource.DataSource = this.dataSetCustomerBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "All Customers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Active Customers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(667, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Inactive Customers";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(758, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(771, 497);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Name = "CustomerReport";
            this.Text = "CustomerReport";
            this.Load += new System.EventHandler(this.CustomerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tbl_CustomerBindingSource;
        private DataSet_Customer DataSet_Customer;
        private DataSet_CustomerTableAdapters.Tbl_CustomerTableAdapter Tbl_CustomerTableAdapter;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource1;
        private System.Windows.Forms.BindingSource dataSetCustomerBindingSource;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}