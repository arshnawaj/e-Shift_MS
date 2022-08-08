using System;
using System.Windows.Forms;
using e_Shift_MS.Services;


namespace e_Shift_MS
{
    public partial class frmCreateCustomer : Form
    {
         public frmCreateCustomer()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CustomerCRUD cusCrud  = new CustomerCRUD(txtcusName.Text, txtcusAddress.Text, txtcusNIC.Text, txtcusContact.Text, txtcusStatus.Text);

            var result = cusCrud.CreateCustomer();

            if (result.IsSuccess)
                MessageBox.Show(result.Message);
            else
                MessageBox.Show(result.Message +" :"+result.ErrorMessage);
        }

        private void btnRegCustomer_Click(object sender, EventArgs e)
        {
           
        }

        private void txtcusStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcusNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcusContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcusAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
