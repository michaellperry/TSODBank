using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TSODBank
{
    public class BankService : IBankService
    {
        public decimal GetBalance(int account)
        {
            return 3000.0m;
        }

        public Confirmation Withdraw(int account, decimal amount)
        {
            return new Confirmation
            {
                Identifier = "234",
                Account = account,
                NewBalance = 3000.0m - amount
            };
        }
    }
}
