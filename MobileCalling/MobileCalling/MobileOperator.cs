using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileCalling
{
    class MobileOperator
    {
        public List<MobileAccount> AccountsList { get; set; }
        public MobileOperator()
        {
            AccountsList = new List<MobileAccount>();
        }

        public void AddToBase(MobileAccount acc)
        {
            this.AccountsList.Add(acc);
            acc.Connecting += this.ProcIncConn;
        }

        public void ProcIncConn(MobileAccount toAcc, MobileAccount fromAcc, bool isSMS, string message)
        {
            var IsPresent = false;
            foreach (var acc in AccountsList)
            {
                if (acc.Number == toAcc.Number)
                {
                    acc.ShowOnScreen($"Subscriber '{acc.Number}' received " + (isSMS?"SMS":"call") + $" from '{fromAcc.Number}' subscriber: {message}");
                    IsPresent = true;
                    break;
                }
            }
            //if (!IsPresent)
            //    fromAcc.ShowOnScreen("There is no such accaunt");
        }
    }
}