using StatusCodes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusCodes.ServerError
{
    public class InternalServerError : BaseStatus<Empty>
    {
        public static BaseStatus<Empty> InternalServerErrorResponse()
        {
            return Fail(500, "Internal Server Error");
        }
    }
}
