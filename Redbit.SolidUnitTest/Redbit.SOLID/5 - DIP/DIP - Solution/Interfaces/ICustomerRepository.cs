using System;
using System.Collections.Generic;
using System.Text;

namespace Redbit.SOLID.DIP.Solution
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
    }
}
