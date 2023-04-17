using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointoFrameworks.PointoFrameworks.StatusCodes.Base;

namespace PointoFrameworks.PointoFrameworks.StatusCodes.Successful
{
    public class NoContent : BaseStatus<Empty>
    {
        public static BaseStatus<Empty> NoContentResponse()
        {
            return Success(204);
        }
    }
}