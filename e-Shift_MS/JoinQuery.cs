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
    public partial class JoinQuery : Form
    {
        public JoinQuery()
        {
            InitializeComponent();
        }

        private void JoinQuery_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Customer.Tbl_Customer' table. You can move, or remove it, as needed.
            this.tbl_CustomerTableAdapter.Fill(this.dataSet_Customer.Tbl_Customer);
            LoadData();

        }

        private void LoadData()
        {
            OrderCRUD obj = new OrderCRUD();
            DataTable dataTable = obj.GetAll();
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();

            comboBox1.DataSource = obj.GetCustomerList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
         
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderCRUD obj = new OrderCRUD(
            int.Parse(comboBox1.SelectedValue.ToString()),
            txtOrderItem.Text,
            txtDescription.Text,
            txtStatus.Text
            );

         obj.InsertOrder();

         LoadData();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
                OrderCRUD obj = new OrderCRUD(
                    int.Parse(comboBox1.SelectedValue.ToString()),
                    txtOrderItem.Text,
                    txtDescription.Text,
                    txtStatus.Text);

         obj.DeleteOrder(comboBox1.Text);

         LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AdminForm().Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
