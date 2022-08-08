using System;
using System.Data.SqlClient;

namespace e_Shift_MS.Services
{
    class CustomerCRUD
    {
        SqlConnection con = new SqlConnection("Data Source=HRC-ARSHN;Initial Catalog=eShiftDb;Integrated Security=True");

        public CustomerCRUD(string cusName, string cusAddress, string cusNIC, string cusContact, string cusStatus)
        {
            this.txtcusName = cusName;
            this.txtcusAddress = cusAddress;
            this.txtcusNIC = cusNIC;
            this.txtcusContact = cusContact;
            this.txtcusStatus = cusStatus;
        }

        public CustomerCRUD()
        {
        }

        private int ID { get; set; }
        private string txtcusName { get; set; }
        private string txtcusAddress { get; set; }
        private string txtcusNIC { get; set; }
        private string txtcusContact { get; set; }
        private string txtcusStatus { get; set; }

        public Returns CreateCustomer()
        {
            try
            {
                string query = "INSERT INTO Tbl_Customer(cusName, cusNIC, cusAddress, cusContact, cusStatus) VALUES('" + txtcusName + "', '" + txtcusNIC + "', '" + txtcusAddress + "', '" + txtcusContact + "', '" + txtcusStatus + "')";

                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                int rowsAdded = com.ExecuteNonQuery();
                if (rowsAdded > 0)
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess = true,
                        ErrorMessage = string.Empty,
                        Message = "Customer Registered Succesfully"
                    };
                else
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess = false,
                        ErrorMessage = string.Empty,
                        Message = "Customer Registration Failed"
                    };

            }
            catch (Exception error)
            {
                return new Returns
                {
                    ID = 0,
                    IsSuccess = false,
                    ErrorMessage = error.Message,
                    Message = "Customer Registration Failed"
                };

            }
            finally
            {
                con.Close();
            }
        }

        public Returns UpdateCustomer(string ID)
        {
            try
            {
                string query = "Update Tbl_Customer set cusName='" + txtcusName + "', cusNIC='" + txtcusNIC + "', cusAddress='" + txtcusAddress + "', cusContact='" + txtcusContact + "', cusStatus='" + txtcusStatus + "' where Id='" + ID + "'";

                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                int rowsUpdated = com.ExecuteNonQuery();
                if (rowsUpdated > 0)
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess = true,
                        ErrorMessage = string.Empty,
                        Message = "Customer Updated Succesfully"
                    };
                else
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess = false,
                        ErrorMessage = string.Empty,
                        Message = "Customer Updation Failed"
                    };

            }
            catch (Exception error)
            {
                return new Returns
                {
                    ID = 0,
                    IsSuccess = false,
                    ErrorMessage = error.Message,
                    Message = "Customer Updation Failed"
                };

            }
            finally
            {
                con.Close();
            }
        }
        public Returns DeleteCustomer(string ID)
        {
            try
            {
                string query = "Delete Tbl_Customer where Id='" + ID + "'";
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                int rowsDeleted = com.ExecuteNonQuery();
                if (rowsDeleted > 0)
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess = true,
                        ErrorMessage = string.Empty,
                        Message = "Customer Deleted Succesfully"
                    };
                else
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess = false,
                        ErrorMessage = string.Empty,
                        Message = "Customer Deletion Failed"
                    };
            }
            catch (Exception er)
            {
                return new Returns
                {
                    ID = 0,
                    IsSuccess = false,
                    ErrorMessage = er.Message,
                    Message = "Customer Deletion Failed"
                };

            }
        }
    }

}
