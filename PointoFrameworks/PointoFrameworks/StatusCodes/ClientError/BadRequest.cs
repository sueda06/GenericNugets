using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointoFrameworks.PointoFrameworks.StatusCodes.Base;

namespace PointoFrameworks.PointoFrameworks.StatusCodes.ClientError
{
    public class BadRequest : BaseStatus<Empty>
    {
        public static BaseStatus<Empty> BadRequestResponse()
        {
            return Fail(400, "Bad Request");
        }
    }
}
