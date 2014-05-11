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
        private static Dictionary<int, AccountStatus> _accounts = new Dictionary<int, AccountStatus>
        {
            { 1, new AccountStatus { Balance = 3000.0m }},
            { 2, new AccountStatus { Balance = 2000.0m }},
            { 3, new AccountStatus { Balance = 5000.0m }},
            { 4, new AccountStatus { Balance = 4000.0m }},
            { 5, new AccountStatus { Balance = 1000.0m }}
        };

        private static int _nextConfirmationNumber = 1000;
        
        public decimal GetBalance(int account)
        {
            return _accounts[account].Balance;
        }

        public Withdrawl PrepareWithdrawl(int account, decimal amount)
        {
            var accountStatus = _accounts[account];

            if (accountStatus.Balance < amount)
                throw new InvalidOperationException(
                    "Insufficient funds");

            return new Withdrawl
            {
                ConfirmationNumber = _nextConfirmationNumber++,
                Account = account,
                Amount = amount,
                NewBalance = accountStatus.Balance - amount
            };
        }
    }
}
