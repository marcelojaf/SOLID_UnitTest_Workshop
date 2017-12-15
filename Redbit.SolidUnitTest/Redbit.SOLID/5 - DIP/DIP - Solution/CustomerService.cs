using System;
using System.Collections.Generic;
using System.Text;

namespace Redbit.SOLID.DIP.Solution
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IEmailService _emailService;

        public CustomerService(ICustomerRepository customerRepository, IEmailService emailService)
        {
            _customerRepository = customerRepository;
            _emailService = emailService;
        }

        public string AddCustomer(Customer customer)
        {
            if (!customer.IsValid()) return "Invalid data";

            _customerRepository.AddCustomer(customer);

            _emailService.Send("redbit@redbit.com", customer.Email, "Welcome", "Congratulations! You are registered.");

            return "Customer successfully registered";
        }
    }
}
