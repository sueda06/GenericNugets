using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatusCodes.Base;

namespace StatusCodes.Successful
{
    public class NoContent : BaseStatus<Empty>
    {
        public static BaseStatus<Empty> NoContentResponse()
        {
            return Success(204);
        }
    }
}