using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_UserValidation
{
    interface IValidator
    {
        void ValidateUser(IUser user);
    }
}
