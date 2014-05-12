using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TSODBank
{
    [ServiceContract]
    public interface IBankService
    {
        [OperationContract]
        decimal GetBalance(int account);

        [OperationContract]
        Withdrawl PrepareWithdrawl(int account, decimal amount);

        [OperationContract]
        void ExecuteWithdrawl(Withdrawl withdrawl);
    }

    [DataContract]
    public class Withdrawl
    {
        [DataMember]
        public int ConfirmationNumber { get; set; }

        [DataMember]
        public int Account { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public decimal NewBalance { get; set; }
    }
}
