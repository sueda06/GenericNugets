using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatusCodes.Base;

namespace StatusCodes.ClientError
{
    public class NotFound : BaseStatus<Empty>
    {
       public static BaseStatus<Empty> NotFoundResponse()
        {
            return Fail(404, "Not Found");
        }
    }
}
