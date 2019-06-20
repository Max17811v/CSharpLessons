using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_UserValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var user = new User();
                var container = new UserContainer();
                var validator = new Validator();
                Console.Write("Enter user Name or Email:");
                user.Name = Console.ReadLine();
                Console.Write("\nEnter Password:");
                user.Password = Console.ReadLine();
                validator.ValidateUser(user);
            }
        }
    }
}
