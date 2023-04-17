using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PointoFrameworks.PointoFrameworks.StatusCodes.Base
{
    public class BaseStatus<T>
    {
        public T Data { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }

        public List<string> Errors { get; set; }
        public static BaseStatus<T> Success(int statusCode, T data)
        {
            return new BaseStatus<T> { Data = data, StatusCode = statusCode };
        }
        public static BaseStatus<T> Success(int statusCode)
        {
            return new BaseStatus<T> { StatusCode = statusCode };
        }
        public static BaseStatus<T> Fail(int statusCode, List<string> errors)
        {
            return new BaseStatus<T> { StatusCode = statusCode, Errors = errors };
        }
        public static BaseStatus<T> Fail(int statusCode, string error)
        {
            return new BaseStatus<T> { StatusCode = statusCode, Errors = new List<string> { error } };
        }
    }
}
