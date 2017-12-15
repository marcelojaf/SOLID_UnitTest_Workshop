using System;
using System.Collections.Generic;
using System.Text;

namespace Redbit.SOLID.OCP.Violation
{
    public class ChargeAccount
    {
        public void Charge(decimal value, string account, AccountType accountType)
        {
            if (accountType == AccountType.Checking)
            {
                //Charge the account
            }

            if (accountType == AccountType.Savings)
            {
                //Verify the account anniversary
                //Charge the account
            }
        }
    }
}
