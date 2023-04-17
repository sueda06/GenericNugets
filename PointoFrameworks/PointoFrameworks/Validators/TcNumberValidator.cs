using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PointoFrameworks.PointoFrameworks.Validators
{
    public class TcNumberValidator
    {
        readonly static string TcNumberRegexExpression = @"^[1-9]{1}[0-9]{9}[02468]{1}$";
        public static bool IsValid(string tcNumber)
        {
            return Regex.Match(tcNumber!, TcNumberRegexExpression).Success;
        }
    }
}
