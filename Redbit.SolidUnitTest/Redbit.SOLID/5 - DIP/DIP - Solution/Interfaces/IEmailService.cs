using System;
using System.Collections.Generic;
using System.Text;

namespace Redbit.SOLID.DIP.Solution
{
    public interface IEmailService
    {
        bool IsValid(string email);
        void Send(string from, string to, string subject, string message);
    }
}
