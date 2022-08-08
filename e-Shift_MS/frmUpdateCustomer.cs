using e_Shift_MS.Services;
using System;
using System.Windows.Forms;

namespace e_Shift_MS
{
    public partial class frmUpdateCustomer : Form
    {

        private DataGridViewCellCollection data;
              
        public frmUpdateCustomer(DataGridViewCellCollection data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void label6_Click(object sender, EventArgs e)
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

        private void txtcusName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CustomerCRUD cusCrud = new CustomerCRUD(txtcusName.Text, txtcusAddress.Text, txtcusNIC.Text, txtcusContact.Text, txtcusStatus.Text);

            var result = cusCrud.UpdateCustomer(txtID.Text);

            if (result.IsSuccess)
                MessageBox.Show("Customer Updated Successfully");
            else
                MessageBox.Show("Customer Updation failed");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = data[0].Value.ToString();
                txtcusName.Text = data[1].Value.ToString();
                txtcusNIC.Text = data[2].Value.ToString();
                txtcusAddress.Text = data[3].Value.ToString();
                txtcusContact.Text = data[4].Value.ToString();
                txtcusStatus.Text = data[5].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerCRUD cusCrud = new CustomerCRUD();

            var result = cusCrud.DeleteCustomer(txtID.Text);

            if (result.IsSuccess)
                MessageBox.Show(result.Message);
            else
                MessageBox.Show(result.Message + " :" + result.ErrorMessage);

        }
    }
}
