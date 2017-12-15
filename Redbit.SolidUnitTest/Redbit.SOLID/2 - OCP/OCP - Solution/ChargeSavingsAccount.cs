using System;
using System.Collections.Generic;
using System.Text;

namespace Redbit.SOLID.OCP.Solution
{
    public class ChargeSavingsAccount : ChargeAccount
    {
        public override string Charge(decimal value, string account)
        {
            //Verify the account anniversary
            //Charge the account
            return FormatTransaction();
        }
    }
}
