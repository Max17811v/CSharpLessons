using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace HW_6_UserValidation
{
    class User : IUser
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime DateTime { get; set; }
        public string GetFullInfo()
        {
            return "User Name: " + this.Name + " Password: "  
                + this.Password + " Email: " + this.DateTime;
        }
    }
}
