using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointoFrameworks.PointoFrameworks.StatusCodes.Base;

namespace PointoFrameworks.PointoFrameworks.StatusCodes.ClientError
{
    public class Unauthorized : BaseStatus<Empty>
    {
        public static BaseStatus<Empty> UnauthorizedResponse()
        {
            return Fail(401, "Unauthorized");
        }
    }
}
