using StatusCodes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusCodes.Successful
{
    public class Created<T> : BaseStatus<T>
    {
        public static BaseStatus<T> CreatedResponse(T data)
        {
            return Success(201,data);
        }
    }
}
