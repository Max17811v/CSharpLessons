using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace HW_6_UserValidation
{
    class Validator : IValidator
    {
        public void ValidateUser(IUser user)
        {
            if ((user.Name == "exit") && (user.Password == "exit"))
            {
                Console.WriteLine("\nYou entered ExitCode and program will exit in 5 seconds");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            var IsPresent = false;
            foreach (var containedUser in UserContainer.UsersList)
            {
                if (user.Name == containedUser.Name)
                {
                    IsPresent = true;
                    if (user.Password == containedUser.Password)
                    {
                        Console.WriteLine($"\nYour last wisit was:{containedUser.DateTime}\n");
                        containedUser.DateTime = DateTime.Now;
                        break;
                    }
                    else Console.WriteLine($"\nYour entered incorrect password for '{user.Name}' user.\n"); break;
                }
            }
            if (!IsPresent)
            {
                Console.WriteLine($"\nYour entered new '{user.Name}' user and he will be added to user list.\n");
                UserContainer.UsersList.Add(new User { Name = user.Name, Password = user.Password, DateTime = DateTime.Now });
            }
        }
    }
}
