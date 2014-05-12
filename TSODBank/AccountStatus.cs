using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSODBank
{
    public class AccountStatus
    {
        public AccountStatus()
        {
            Transactions = new List<int>();
        }

        public List<int> Transactions { get; set; }
        public decimal Balance { get; set; }
    }
}
