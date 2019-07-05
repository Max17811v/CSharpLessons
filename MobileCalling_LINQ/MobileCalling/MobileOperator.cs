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
        public List<(int, int, bool)> CallLogList { get; set; }
        public MobileOperator()
        {
            AccountsList = new List<MobileAccount>();
            CallLogList = new List<(int, int, bool)>();
        }

        public void AddToBase(MobileAccount acc)
        {
            this.AccountsList.Add(acc);
            acc.Connecting += this.ProcIncConn;
        }

        public void AddCallToLog(int toNumber, int fromNumber, bool isSMS)
        {
            CallLogList.Add((toNumber, fromNumber, isSMS));
        }

        public void ProcIncConn(MobileAccount toAcc, MobileAccount fromAcc, bool isSMS, string message)
        {
            AccountsList.First(i => i.Number == toAcc.Number).ShowOnScreen
                ($"Subscriber '{toAcc.Number}' received " + (isSMS ? "SMS" : "call") + $" from '{fromAcc.Number}' subscriber: {message}");
            AddCallToLog(toAcc.Number, fromAcc.Number, isSMS);

            //var IsPresent = false; 
            //foreach (var acc in AccountsList)
            //{

            //    if (acc.Number == toAcc.Number)
            //    {
            //        acc.ShowOnScreen($"Subscriber '{acc.Number}' received " + (isSMS?"SMS":"call") + $" from '{fromAcc.Number}' subscriber: {message}");
            //        AddCallToLog(toAcc.Number, fromAcc.Number, isSMS);
            //        //IsPresent = true;
            //        break;
            //    }
            //}
            //if (!IsPresent)
            //    fromAcc.ShowOnScreen("There is no such accaunt");
        }
    }
}