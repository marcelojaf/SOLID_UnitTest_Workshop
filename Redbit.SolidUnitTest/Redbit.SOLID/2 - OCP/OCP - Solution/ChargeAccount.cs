using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Redbit.SOLID.OCP.Solution
{
    public abstract class ChargeAccount
    {
        public string TransactionNumber { get; set; }
        public abstract string Charge(decimal value, string account);

        public string FormatTransaction()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            TransactionNumber = new string(Enumerable.Repeat(chars, 15)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            // Numero de transacao formatado
            return TransactionNumber;
        }
    }
}
