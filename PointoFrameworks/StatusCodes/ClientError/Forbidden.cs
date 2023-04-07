using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatusCodes.Base;

namespace StatusCodes.ClientError
{
    public class Forbidden : BaseStatus<Empty>
    {
        public static BaseStatus<Empty> ForbiddenResponse()
        {
            return Fail(403, "Forbidden");
        }
    }
}
