using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PointoFrameworks.PointoFrameworks.Validators
{
    public class PhoneNumberValidator
    {
        readonly static string PhoneNumberRegexExpression = @"^\(?([0-9]{3})\)?[-  ]?([0-9]{3})[-  ]?([0-9]{2})[-  ]?([0-9]{2})$";
        public static bool IsValid(string phoneNumber)
        {
            return Regex.Match(phoneNumber!, PhoneNumberRegexExpression).Success;
        }
    }
}
