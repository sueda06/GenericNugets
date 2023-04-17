using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PointoFrameworks.PointoFrameworks.Validators
{
    public class CreditCardNumberValidator
    {
        readonly static string CreditCardNumberRegexExpression = @"^([0-9]{4})\s?([0-9]{4})\s?([0-9]{4})\s?([0-9]{4})$";
        public static bool IsValid(string creditCardNumber)
        {
            return Regex.Match(creditCardNumber!, CreditCardNumberRegexExpression).Success;
        }
    }
}
