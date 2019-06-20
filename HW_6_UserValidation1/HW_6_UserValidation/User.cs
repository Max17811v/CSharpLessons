using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace HW_6_UserValidation
{
    class User : IUser, IValidator
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateTime { get; set; }
        public static List<User> UsersList { get; set; } = new List<User>
        {
            new User { Name = "John", Password = "123", DateTime = DateTime.MinValue }
        };
        
        public void ValidateUser()
        {
            if ((this.Name == "exit") && (this.Password == "exit"))
            {
                Console.WriteLine("\nYou entered ExitCode and program will exit in 5 seconds");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }

            var IsPresent = false;

            foreach (User i in UsersList)
            {
                if (this.Name == i.Name)
                {
                    IsPresent = true;
                    if (this.Password == i.Password)
                    {
                        Console.WriteLine($"\nYour last wisit was:{i.DateTime}\n");
                        i.DateTime = DateTime.Now;
                        break;
                    }
                    else Console.WriteLine($"\nYou entered incorrect password for {this.Name} user.\n"); break;

                }
                
            }

            if(!IsPresent)
            {
                Console.WriteLine($"\nYou entered new '{this.Name}' user and he will be added to user list.\n");
                UsersList.Add(new User { Name = this.Name, Password = this.Password, DateTime = DateTime.Now });
            }
            
        }

        public string GetFullInfo()
        {
            return "User Name: " + this.Name + " Password: "  
                + this.Password + " Email: " + this.Email + " Last visit time: " + this.DateTime;
        }
    }
}
