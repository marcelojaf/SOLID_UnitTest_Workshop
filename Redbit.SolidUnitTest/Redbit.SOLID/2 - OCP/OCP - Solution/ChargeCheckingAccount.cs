using System;
using System.Collections.Generic;
using System.Text;

namespace Redbit.SOLID.OCP.Solution
{
    public class ChargeCheckingAccount : ChargeAccount
    {
        public override string Charge(decimal value, string account)
        {
            //Charge the account
            return FormatTransaction();
        }
    }
}
