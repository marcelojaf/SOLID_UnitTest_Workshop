using System;
using System.Collections.Generic;
using System.Text;

namespace Redbit.SOLID.OCP.Solution
{
    public class ChargeInvestmentAccount : ChargeAccount
    {
        public override string Charge(decimal value, string account)
        {
            //Exempt taxes
            //Charge the account
            throw new NotImplementedException();
        }
    }
}
