using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validators
{
    public class PlateNumberValidator
    {
        readonly static string PlateNumberRegexExpression = @"^(0[1-9]|[1-7][0-9]|8[01])(([A-Z])(\d{4,5})|([A-Z]{2})(\d{3,4})|([A-Z]{3})(\d{2,3}))$";
        public static bool IsValid(string plateNumber)
        {
            return Regex.Match(plateNumber!, PlateNumberRegexExpression).Success;
        }
    }
}
