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
        Confirmation Withdraw(int account, decimal amount);
    }

    [DataContract]
    public class Confirmation
    {
        [DataMember]
        public string Identifier { get; set; }

        [DataMember]
        public int Account { get; set; }

        [DataMember]
        public decimal NewBalance { get; set; }
    }
}
