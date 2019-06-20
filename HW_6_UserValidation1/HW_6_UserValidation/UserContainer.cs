using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_UserValidation
{
    class UserContainer
    {
        public static List<User> UsersList { get; set; } 
        public UserContainer()
        {
            UsersList = new List<User> { new User { Name = "John", Password = "123", DateTime = DateTime.MinValue }};
        }
    }
}
