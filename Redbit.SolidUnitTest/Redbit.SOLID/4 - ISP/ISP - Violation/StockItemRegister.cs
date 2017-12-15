using System;
using System.Collections.Generic;
using System.Text;

namespace Redbit.SOLID.ISP.Violation
{
    public class StockItemRegister : IRegister
    {
        public void ValidData()
        {
            //Validate the incoming data
        }

        public void SaveData()
        {
            //Save data on StockItem Table
        }

        public void SendEmail()
        {
            throw new NotImplementedException("HuMMM... send email to an item? WTF??");
        }
    }
}
