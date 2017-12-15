using System;
using System.Collections.Generic;
using System.Text;

namespace Redbit.SOLID.DIP.Solution
{
    public class Customer
    {
        private readonly IEmailService _emailService;

        public Customer(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateRegister { get; set; }

        public bool IsValid()
        {
            return _emailService.IsValid(Email);
        }
    }
}
