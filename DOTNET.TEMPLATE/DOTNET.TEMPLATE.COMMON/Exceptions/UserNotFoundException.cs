using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET.TEMPLATE.COMMON.Exceptions
{
    internal class UserNotFoundException :Exception
    {
        public string Message()
        {
            return "User not found";
        }
    }
}
