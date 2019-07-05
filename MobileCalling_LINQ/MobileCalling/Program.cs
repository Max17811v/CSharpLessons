using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileCalling
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobileOperator = new MobileOperator();
            var max = new MobileAccount("Max", 09311);
            mobileOperator.AddToBase(max);
            var crab =new MobileAccount("Ievgen", 05011);
            mobileOperator.AddToBase(crab);
            var zloi = new MobileAccount("Yaroslav", 06711);
            mobileOperator.AddToBase(zloi);
            var dima = new MobileAccount("Dima", 06722);
            mobileOperator.AddToBase(dima);
            var artem = new MobileAccount("Artem", 06733);
            mobileOperator.AddToBase(artem);
            var andrey = new MobileAccount("Andrey", 09322);
            mobileOperator.AddToBase(andrey);
            var vital = new MobileAccount("Vitaly", 05022);
            mobileOperator.AddToBase(vital);

            max.Call(crab, "let me write off your homework))");
            max.SMS(artem, "let me write off your homework))");
            max.Call(dima, "let me write off your homework))");
            max.SMS(artem, "let me write off your homework))");

            crab.SMS(zloi, "come here lazy!");
            crab.Call(artem, "come here lazy!");
            crab.SMS(max, "come here lazy!");
            crab.Call(dima, "come here lazy!");

            zloi.Call(max, "where is my money?");
            zloi.SMS(crab, "where is my money?");
            zloi.Call(dima, "where is my money?");
            zloi.SMS(artem, "where is my money?");
            zloi.Call(andrey, "where is my money?");
            zloi.SMS(max, "where is my money?");

            dima.Call(vital, "where is my money?");
            dima.SMS(andrey, "where is my money?");
            dima.Call(dima, "where is my money?");
            dima.SMS(artem, "where is my money?");
            dima.Call(andrey, "where is my money?");

            artem.Call(vital, "where is my money?");
            artem.SMS(andrey, "where is my money?");
            artem.Call(dima, "where is my money?");

            andrey.Call(max, "where is my money?");
            andrey.SMS(crab, "where is my money?");

            vital.Call(dima, "where is my money?");

            Console.WriteLine("\nTop 5 most wanted abonents:");
            var mostWanted = mobileOperator.CallLogList.GroupBy(i => i.Item1).Select(g => new {PhoneNumber = g.Key, Count = g.Count()}).
                OrderByDescending(i => i.Count).Select(g => g.PhoneNumber).Take(5);
            foreach (var i in mostWanted)
                Console.WriteLine(i);

            Console.WriteLine("\nTop 5 most active abonents:");
            var mostActive = mobileOperator.CallLogList.GroupBy(i => i.Item2).Select(g => new { PhoneNumber = g.Key, Count = g.Count() }).
                OrderByDescending(i => i.Count).Select(g => g.PhoneNumber).Take(5);
            foreach (var i in mostActive)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}