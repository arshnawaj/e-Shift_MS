namespace e_Shift_MS
{
    partial class frmUpdateCustomer
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtcusStatus = new System.Windows.Forms.TextBox();
            this.txtcusNIC = new System.Windows.Forms.TextBox();
            this.txtcusContact = new System.Windows.Forms.TextBox();
            this.txtcusAddress = new System.Windows.Forms.TextBox();
            this.txtcusName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(267, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 26);
            this.label6.TabIndex = 25;
            this.label6.Text = "Update Customer Details";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtcusStatus
            // 
            this.txtcusStatus.Location = new System.Drawing.Point(243, 318);
            this.txtcusStatus.Name = "txtcusStatus";
            this.txtcusStatus.Size = new System.Drawing.Size(399, 20);
            this.txtcusStatus.TabIndex = 24;
            this.txtcusStatus.TextChanged += new System.EventHandler(this.txtcusStatus_TextChanged);
            // 
            // txtcusNIC
            // 
            this.txtcusNIC.Location = new System.Drawing.Point(243, 277);
            this.txtcusNIC.Name = "txtcusNIC";
            this.txtcusNIC.Size = new System.Drawing.Size(399, 20);
            this.txtcusNIC.TabIndex = 23;
            this.txtcusNIC.TextChanged += new System.EventHandler(this.txtcusNIC_TextChanged);
            // 
            // txtcusContact
            // 
            this.txtcusContact.Location = new System.Drawing.Point(243, 234);
            this.txtcusContact.Name = "txtcusContact";
            this.txtcusContact.Size = new System.Drawing.Size(399, 20);
            this.txtcusContact.TabIndex = 22;
            this.txtcusContact.TextChanged += new System.EventHandler(this.txtcusContact_TextChanged);
            // 
            // txtcusAddress
            // 
            this.txtcusAddress.Location = new System.Drawing.Point(243, 192);
            this.txtcusAddress.Name = "txtcusAddress";
            this.txtcusAddress.Size = new System.Drawing.Size(399, 20);
            this.txtcusAddress.TabIndex = 21;
            this.txtcusAddress.TextChanged += new System.EventHandler(this.txtcusAddress_TextChanged);
            // 
            // txtcusName
            // 
            this.txtcusName.Location = new System.Drawing.Point(243, 150);
            this.txtcusName.Name = "txtcusName";
            this.txtcusName.Size = new System.Drawing.Size(399, 20);
            this.txtcusName.TabIndex = 20;
            this.txtcusName.TextChanged += new System.EventHandler(this.txtcusName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Status";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "NIC";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Contact";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Customer Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(494, 383);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 61);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(141, 383);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(148, 61);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Update";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Customer ID ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(243, 104);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(399, 20);
            this.txtID.TabIndex = 27;
            this.txtID.Text = " ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkGray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(319, 383);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 61);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcusStatus);
            this.Controls.Add(this.txtcusNIC);
            this.Controls.Add(this.txtcusContact);
            this.Controls.Add(this.txtcusAddress);
            this.Controls.Add(this.txtcusName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Name = "frmUpdateCustomer";
            this.Text = "frmUpdateCustomer";
            this.Load += new System.EventHandler(this.frmUpdateCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcusStatus;
        private System.Windows.Forms.TextBox txtcusNIC;
        private System.Windows.Forms.TextBox txtcusContact;
        private System.Windows.Forms.TextBox txtcusAddress;
        private System.Windows.Forms.TextBox txtcusName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnDelete;
    }
}