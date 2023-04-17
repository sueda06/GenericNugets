using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PointoFrameworks.PointoFrameworks.Validators
{
    public class PasswordValidator
    {
        readonly static string PasswordRegexExpression = @"^(?=.*?[A-ZŞşÇçİÜüĞğÖöı])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
        public static bool IsValid(string password)
        {
            return Regex.Match(password!, PasswordRegexExpression).Success;
        }
    }
}
