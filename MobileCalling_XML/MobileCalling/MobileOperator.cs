using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace MobileCalling
{
    public class MobileOperator
    {
        public string Name { get; set; }
        public List<MobileAccount> AccountsList { get; set; }
        private List<(int, int, bool)> callLogList;
        public List<(int, int, bool)> CallLogList
        {
            get
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<(int, int, bool)>));
                using (FileStream fs = new FileStream($"{Name}_callLogList.xml", FileMode.OpenOrCreate))
                {
                    callLogList = (List<(int, int, bool)>)formatter.Deserialize(fs);
                }
                return callLogList;
            }
            set
            {
                callLogList = value;
                XmlSerializer formatter = new XmlSerializer(typeof(List<(int, int, bool)>));
                using (FileStream fs = new FileStream($"{Name}_callLogList.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, callLogList);
                }
            }
        }
        public MobileOperator()
        {
        }
        public MobileOperator(string name)
        {
            Name = name;
            AccountsList = new List<MobileAccount>();
            if(File.Exists($"{Name}_callLogList.xml"))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<(int, int, bool)>));
                using (FileStream fs = new FileStream($"{Name}_callLogList.xml", FileMode.OpenOrCreate))
                {
                    callLogList = (List<(int, int, bool)>)formatter.Deserialize(fs);
                }
            }
            else
                CallLogList = new List<(int, int, bool)>();
        }

        public void AddToBase(MobileAccount acc)
        {
            this.AccountsList.Add(acc);
            acc.Connecting += this.ProcIncConn;
        }

        public void AddCallToLog(int toNumber, int fromNumber, bool isSMS)
        {
            callLogList.Add((toNumber, fromNumber, isSMS));
            this.CallLogList = callLogList;
        }

        public void ProcIncConn(MobileAccount toAcc, MobileAccount fromAcc, bool isSMS, string message)
        {
            AccountsList.First(i => i.Number == toAcc.Number).ShowOnScreen
                ($"Subscriber '{toAcc.Number}' received " + (isSMS ? "SMS" : "call") + $" from '{fromAcc.Number}' subscriber: {message}");
            AddCallToLog(toAcc.Number, fromAcc.Number, isSMS);
        }
    }
}