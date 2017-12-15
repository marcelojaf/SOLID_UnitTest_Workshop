using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Redbit.SOLID.SRP.Solution
{
    public class CustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "My connection string";
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO CUSTOMER (NAME, EMAIL, DATEREGISTER) VALUES (@name, @email, @dateregister)";

                cmd.Parameters.AddWithValue("name", customer.Name);
                cmd.Parameters.AddWithValue("email", customer.Email);
                cmd.Parameters.AddWithValue("dateregister", customer.DateRegister);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
