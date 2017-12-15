using System;
using System.Collections.Generic;
using System.Text;

namespace Redbit.SOLID.ISP.Violation
{
    public class CustomerRegister : IRegister
    {
        public void ValidData()
        {
            //Validate the incoming data
        }

        public void SaveData()
        {
            //Save data on Customer Table
        }

        public void SendEmail()
        {
            //Send an e-mail to confirm the customer registration
        }
    }
}
