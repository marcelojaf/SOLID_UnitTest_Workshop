using System;
using System.Collections.Generic;
using System.Text;

namespace Redbit.SOLID.ISP.Solution
{
    public interface ICustomerRegister
    {
        void ValidData();
        void SaveData();
        void SendEmail();
    }
}
