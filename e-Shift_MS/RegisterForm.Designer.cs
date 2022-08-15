namespace e_Shift_MS
{
    partial class RegisterForm
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
            this.txtcusNIC = new System.Windows.Forms.TextBox();
            this.txtcusContact = new System.Windows.Forms.TextBox();
            this.txtcusAddress = new System.Windows.Forms.TextBox();
            this.txtcusName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegCustomer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcusStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcusNIC
            // 
            this.txtcusNIC.Location = new System.Drawing.Point(124, 266);
            this.txtcusNIC.Name = "txtcusNIC";
            this.txtcusNIC.Size = new System.Drawing.Size(399, 20);
            this.txtcusNIC.TabIndex = 34;
            // 
            // txtcusContact
            // 
            this.txtcusContact.Location = new System.Drawing.Point(124, 223);
            this.txtcusContact.Name = "txtcusContact";
            this.txtcusContact.Size = new System.Drawing.Size(399, 20);
            this.txtcusContact.TabIndex = 33;
            // 
            // txtcusAddress
            // 
            this.txtcusAddress.Location = new System.Drawing.Point(124, 181);
            this.txtcusAddress.Name = "txtcusAddress";
            this.txtcusAddress.Size = new System.Drawing.Size(399, 20);
            this.txtcusAddress.TabIndex = 32;
            // 
            // txtcusName
            // 
            this.txtcusName.Location = new System.Drawing.Point(124, 139);
            this.txtcusName.Name = "txtcusName";
            this.txtcusName.Size = new System.Drawing.Size(399, 20);
            this.txtcusName.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "NIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Registration Page";
            // 
            // btnRegCustomer
            // 
            this.btnRegCustomer.Location = new System.Drawing.Point(375, 342);
            this.btnRegCustomer.Name = "btnRegCustomer";
            this.btnRegCustomer.Size = new System.Drawing.Size(148, 61);
            this.btnRegCustomer.TabIndex = 37;
            this.btnRegCustomer.Text = "Register";
            this.btnRegCustomer.UseVisualStyleBackColor = true;
            this.btnRegCustomer.Click += new System.EventHandler(this.btnRegCustomer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcusStatus
            // 
            this.txtcusStatus.Location = new System.Drawing.Point(124, 307);
            this.txtcusStatus.Name = "txtcusStatus";
            this.txtcusStatus.Size = new System.Drawing.Size(399, 20);
            this.txtcusStatus.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Status";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 415);
            this.Controls.Add(this.txtcusStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcusNIC);
            this.Controls.Add(this.txtcusContact);
            this.Controls.Add(this.txtcusAddress);
            this.Controls.Add(this.txtcusName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtcusNIC;
        private System.Windows.Forms.TextBox txtcusContact;
        private System.Windows.Forms.TextBox txtcusAddress;
        private System.Windows.Forms.TextBox txtcusName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcusStatus;
        private System.Windows.Forms.Label label5;
    }
}