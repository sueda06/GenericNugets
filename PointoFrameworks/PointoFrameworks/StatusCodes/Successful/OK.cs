﻿using PointoFrameworks.PointoFrameworks.StatusCodes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointoFrameworks.PointoFrameworks.StatusCodes.Successful
{
    public class OK<T> : BaseStatus<T>
    {
        public static BaseStatus<T> OKResponse(T data)
        {
            return Success(200, data);
        }
    }
}
