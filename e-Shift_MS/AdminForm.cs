using e_Shift_MS.Services;
using System;
using System.Windows.Forms;

namespace e_Shift_MS
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Customer.Tbl_Customer' table. You can move, or remove it, as needed.
            this.tbl_CustomerTableAdapter.Fill(this.dataSet_Customer.Tbl_Customer);
            InitSetting();
        }

        private void InitSetting()
        {
            btnUpdateSubmit.Enabled = false;
            btnDeleteCustomer.Enabled = false;
            btnRegCustomer.Enabled = true;
            txtID.ReadOnly = true;

            txtID.Text = string.Empty;
            txtcusName.Text = string.Empty;
            txtcusNIC.Text = string.Empty;
            txtcusAddress.Text = string.Empty;
            txtcusContact.Text = string.Empty;
            txtcusStatus.Text = string.Empty;
        }


        private void btnRegCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerCRUD cusCrud = new CustomerCRUD(txtcusName.Text, txtcusAddress.Text, txtcusNIC.Text, txtcusContact.Text, txtcusStatus.Text);

                var result = cusCrud.CreateCustomer();

                if (result.IsSuccess)
                    MessageBox.Show(result.Message);
                else
                    MessageBox.Show(result.Message + " :" + result.ErrorMessage);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                this.tbl_CustomerTableAdapter.Fill(this.dataSet_Customer.Tbl_Customer);
                InitSetting();
            }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var data = dataGridView1.Rows[e.RowIndex].Cells;

                txtID.Text = data[0].Value.ToString();
                txtcusName.Text = data[1].Value.ToString();
                txtcusNIC.Text = data[2].Value.ToString();
                txtcusAddress.Text = data[3].Value.ToString();
                txtcusContact.Text = data[4].Value.ToString();
                txtcusStatus.Text = data[5].Value.ToString();

                btnUpdateSubmit.Enabled = true;
                btnDeleteCustomer.Enabled = true;
                btnRegCustomer.Enabled = false;

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerCRUD cusCrud = new CustomerCRUD();

                var result = cusCrud.DeleteCustomer(txtID.Text);

                if (result.IsSuccess)
                    MessageBox.Show(result.Message);
                else
                    MessageBox.Show(result.Message + " :" + result.ErrorMessage);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                this.tbl_CustomerTableAdapter.Fill(this.dataSet_Customer.Tbl_Customer);
                InitSetting();
            }


        }

        private void btnUpdateSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerCRUD cusCrud = new CustomerCRUD(txtcusName.Text, txtcusAddress.Text, txtcusNIC.Text, txtcusContact.Text, txtcusStatus.Text);

                var result = cusCrud.UpdateCustomer(txtID.Text);

                if (result.IsSuccess)
                    MessageBox.Show("Customer Updated Successfully");
                else
                    MessageBox.Show("Customer Updation failed");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                this.tbl_CustomerTableAdapter.Fill(this.dataSet_Customer.Tbl_Customer);
                InitSetting();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CustomerReport().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SearchCustomers().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new JoinQuery().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
