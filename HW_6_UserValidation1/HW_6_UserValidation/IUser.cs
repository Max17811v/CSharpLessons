using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_UserValidation
{
    interface IUser
    {
        string Name { get; set; }
        string Password { get; set; }
        string GetFullInfo();
    }
}
