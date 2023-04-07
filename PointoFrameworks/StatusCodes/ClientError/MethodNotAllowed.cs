using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatusCodes.Base;

namespace StatusCodes.ClientError
{
    public class MethodNotAllowed : BaseStatus<Empty>
    {
        public static BaseStatus<Empty> MethodNotAllowedResponse()
        {
            return Fail(405, "Method Not Allowed");
        }
    }
}
