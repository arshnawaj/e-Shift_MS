using System;
using System.Windows.Forms;

namespace e_Shift_MS
{
    public partial class SearchCustomers : Form
    {
        public SearchCustomers()
        {
            InitializeComponent();
        }

        private void SearchCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Customer.Tbl_Customer' table. You can move, or remove it, as needed.
            this.tbl_CustomerTableAdapter.Fill(this.dataSet_Customer.Tbl_Customer);
            rdbtnAll.Checked = true;
        }

        private void txtSearchVal_TextChanged(object sender, EventArgs e)
        {          
            Search();
        }

        private void Search()
        {
            //coding
            string SearchVal = txtSearchVal.Text;
            string statusCheck = getStatusFilter();

            if (SearchVal != string.Empty)
                if (statusCheck != string.Empty)
                    this.tbl_CustomerTableAdapter.FillBySearchValAndStatus(this.dataSet_Customer.Tbl_Customer, SearchVal + "%", statusCheck);
                else
                    //search data according to search text only
                    this.tbl_CustomerTableAdapter.FillBySearchVal(this.dataSet_Customer.Tbl_Customer, SearchVal + "%");

            else
                if (statusCheck != string.Empty)
                this.tbl_CustomerTableAdapter.FillByStatus(this.dataSet_Customer.Tbl_Customer, statusCheck);
            else
                this.tbl_CustomerTableAdapter.Fill(this.dataSet_Customer.Tbl_Customer);
        }


        private string getStatusFilter()
        {
            if (rdbtnAll.Checked)
                return string.Empty;
            else if (rdbtnActive.Checked)
                return "Active";
            else if (rdbtnInactive.Checked)
                return "InActive";
            else
                return string.Empty;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void rdbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void rdbtnActive_CheckedChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AdminForm().Show();
            this.Close();
        }
    }
}
