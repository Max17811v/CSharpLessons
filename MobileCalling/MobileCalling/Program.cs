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
            var max = new MobileAccount(093); mobileOperator.AddToBase(max);
            var crab =new MobileAccount(050); mobileOperator.AddToBase(crab);
            var zloi = new MobileAccount(067); mobileOperator.AddToBase(zloi);

            zloi.Call(max, "where is my money?");
            crab.SMS(zloi, "come here lazy!");
            max.SMS(crab, "let me write off your homework))");
            Console.ReadKey();
        }
    }
}