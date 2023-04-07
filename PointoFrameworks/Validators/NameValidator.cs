using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validators
{
    public class NameValidator
    {
        readonly static string NameRegexExpression = @"^[a-zA-ZŞşÇçİÜüĞğÖöı]*$";
        public static bool IsValid(string name)
        {
            return Regex.Match(name!, NameRegexExpression).Success;
        }
    }
}
