using System;
using System.Collections.Generic;
using System.Text;

namespace Redbit.SOLID.DIP.Violation
{
    public class CustomerService
    {
        public string AddCustomer(Customer customer)
        {
            if (!customer.IsValid()) return "Invalid data";

            var repo = new CustomerRepository();
            repo.AddCustomer(customer);

            EmailServices.Send("redbit@redbit.com", customer.Email, "Welcome", "Congratulations! You are registered.");

            return "Customer successfully registered";
        }
    }
}
