using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentEight
{
    public struct Account
    {
        private int AccountId;
        private string AccountHolder;
        private double Balance;
        public Account(int _AccountId, string _AccountHolder,double _Balance)
        {
            AccountId = _AccountId;
            AccountHolder = _AccountHolder;
            Balance = _Balance;
        }
        public string GetId
        {
            get { return $"Account Id is: {AccountId}."; }
        }
        public string GetAccountHolder
        {
            get { return $"Account Holedr is: {AccountHolder}."; }
        }
        public string GetBalance
        {
            get { return $"Account Balance is: {Balance}."; }
        }
        public override string ToString() {
            return $"Account Id is: '{AccountId}', Account Holedr is: '{AccountHolder}', Account Balance is: '{Balance}'.";
        }
    }
}
