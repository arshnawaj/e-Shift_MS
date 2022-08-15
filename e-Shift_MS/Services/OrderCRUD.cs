using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace e_Shift_MS.Services
{
    class OrderCRUD
    {
        public OrderCRUD(int cusID, string orderItem, string orderDescription, string status)
        {
            CusID = cusID;
            OrderItem = orderItem;
            OrderDescription = orderDescription;
            Status = status;
        }

        public OrderCRUD()
        {
        }

        private int OrderID { get; set; }
        private int CusID { get; set; }
        private string OrderItem { get; set; }
        private string OrderDescription { get; set; }
        private string Status { get; set; }

        SqlConnection con = new SqlConnection(@"Data Source=HRC-ARSHN;Initial Catalog=eShiftDb;Integrated Security=True");

        public DataTable GetAll()
        {
            string query = "select * from Tbl_Order INNER JOIN Tbl_Customer ON Tbl_Order.CusID = Tbl_Customer.Id";

            SqlCommand com = new SqlCommand(query, con);

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable dt = new DataTable();

            da.Fill(dt);

            con.Close();

            return dt;


        }

        public List<string> GetCustomerList()
        {
            string query = "select Id, cusName from Tbl_Customer";

            SqlCommand com = new SqlCommand(query, con);

            con.Open();

            List<string> li = new List<string>();

            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                li.Add(item[0].ToString());
            }

            con.Close();
            return li;
        }

        public Returns InsertOrder()
        {
            try
            {
                string query = "INSERT INTO Tbl_Order(CusID,OrderItem,OrderDescription," + "Status) VALUES('" + CusID + "', '" + OrderItem + "', " + "'" + OrderDescription + "', '" + Status + "')";

                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                int rowsAdded = com.ExecuteNonQuery();
                if (rowsAdded > 0)
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess = true,
                        ErrorMessage = string.Empty,
                        Message = "Order Added Succesfully"
                    };
                else
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess = false,
                        ErrorMessage = string.Empty,
                        Message = "Order Confirmation Failed"
                    };

            }
            catch (Exception error)
            {
                return new Returns
                {
                    ID = 0,
                    IsSuccess = false,
                    ErrorMessage = error.Message,
                    Message = "Order Confirmation Failed"
                };

            }
            finally
            {
                con.Close();
            }
        }

        public Returns DeleteOrder(string CusID)
        {
            try
            {
                string query = "Delete Tbl_Order where cusID='" + CusID + "'";
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                int rowsDeleted = com.ExecuteNonQuery();
                if (rowsDeleted > 0)
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess = true,
                        ErrorMessage = string.Empty,
                        Message = "Order Deleted Succesfully"
                    };
                else
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess = false,
                        ErrorMessage = string.Empty,
                        Message = "Order Deletion Failed"
                    };
            }
            catch (Exception er)
            {
                return new Returns
                {
                    ID = 0,
                    IsSuccess = false,
                    ErrorMessage = er.Message,
                    Message = "Order Deletion Failed"
                };
            }
        }

            public Returns UpdateOrder(string CusID)
            {
            try
            {
                string query = "Update Tbl_Order set OrderItem='" + OrderItem+ "', OrderDescription='" + OrderDescription+ "', Status='" + Status+ "', where CusID='" + CusID + "'";
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                int rowsUpdated = com.ExecuteNonQuery();
                if (rowsUpdated > 0)
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess = true,
                        ErrorMessage = string.Empty,
                        Message = "Order Updated Succesfully"
                    };
                else
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess = false,
                        ErrorMessage = string.Empty,
                        Message = "Order Updation Failed"
                    };

            }
            catch (Exception error)
            {
                return new Returns
                {
                    ID = 0,
                    IsSuccess = false,
                    ErrorMessage = error.Message,
                    Message = "Order Updation Failed"
                };

            }
            finally
            {
                con.Close();
            }
        }
      
    }
}