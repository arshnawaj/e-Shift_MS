using e_Shift_MS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Shift_MS
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
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
                InitSetting();
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
        }


        private void InitSetting()
            {
                btnRegCustomer.Enabled = true;

                txtcusName.Text = string.Empty;
                txtcusNIC.Text = string.Empty;
                txtcusAddress.Text = string.Empty;
                txtcusContact.Text = string.Empty;
                txtcusStatus.Text = string.Empty;
            }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}
