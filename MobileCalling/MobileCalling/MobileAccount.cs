using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileCalling
{
    class MobileAccount
    {
        public int Number { get; }
        public delegate void MobileConnect(MobileAccount toAcc, MobileAccount fromAcc, bool isSMS,  string message);
        public event MobileConnect Connecting;
        public MobileAccount(int number)
        {
            Number = number;
        }
        public void Call(MobileAccount toAcc, string message)
        {
            Connecting(toAcc,this, false, message);
        }
        public void SMS(MobileAccount toAcc, string message)
        {
            Connecting(toAcc, this, true, message);
        }
        public void ShowOnScreen(string message)
        {
            Console.WriteLine(message);
        }
    }
}
