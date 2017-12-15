using System;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Redbit.SOLID.SRP.Violation
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateRegister { get; set; }

        public string AddCustomer()
        {
            if (!Email.Contains("@")) return "Invalid e-mail";

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "My connection string";
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO CUSTOMER (NAME, EMAIL, DATEREGISTER) VALUES (@name, @email, @dateregister)";

                cmd.Parameters.AddWithValue("name", Name);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("dateregister", DateRegister);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            var mail = new MailMessage("company@company.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Welcome";
            mail.Body = "Congratulations! You are registered.";
            client.Send(mail);

            return "Customer successfully registered";
        }
    }
}
