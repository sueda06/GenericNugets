using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PointoFrameworks.PointoFrameworks.Validators
{
    public class DateOfBirthValidator
    {
        readonly static string DateOfBirthRegexExpression = @"\d{4}[- /.]([1-9]|0[1-9]|1[012])[- /.]([1-9]|0[1-9]|[12][0-9]|3[01])";
        public static bool IsValid(string dateOfBirth)
        {
            return Regex.Match(dateOfBirth!, DateOfBirthRegexExpression).Success;
        }
    }
}
