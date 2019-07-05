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
        public string Name { get; set; }
        public List<(string, int)> AdressBook { get; set; }
        public delegate void MobileConnect(MobileAccount toAcc, MobileAccount fromAcc, bool isSMS,  string message);
        public event MobileConnect Connecting;
        public MobileAccount(string name, int number)
        {
            Name = name;
            Number = number;
            AdressBook = new List<(string, int)> {(" ", 0)};
        }
        public void Call(MobileAccount toAcc, string message)
        {
            if(AdressBook.Count(i => i.Item2 == toAcc.Number) == 0)
                AdressBook.Add((toAcc.Name, toAcc.Number));
            Connecting?.Invoke(toAcc, this, false, message);
        }
        public void SMS(MobileAccount toAcc, string message)
        {
            if (AdressBook.Count(i => i.Item2 == toAcc.Number) == 0)
                AdressBook.Add((toAcc.Name, toAcc.Number));
            Connecting?.Invoke(toAcc, this, true, message);
        }
        public void ShowOnScreen(string message)
        {
            Console.WriteLine(message);
        }
    }
}
