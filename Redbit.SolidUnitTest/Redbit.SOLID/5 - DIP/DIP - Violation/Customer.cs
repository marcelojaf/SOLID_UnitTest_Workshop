using System;
using System.Collections.Generic;
using System.Text;

namespace Redbit.SOLID.DIP.Violation
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateRegister { get; set; }

        public bool IsValid()
        {
            return EmailServices.IsValid(Email);
        }
    }
}
