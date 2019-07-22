using System;
using System.Text.RegularExpressions;

namespace regular_expressions

{
    public class Validator
    {
        public static bool ValidName(string name)
        {
            return Regex.IsMatch(name, @"^(\b\p{Lu}[a-z]*\b\s?)+$");
        }

        public static bool ValidCellPhoneNumberHUN(string number)
        {
            return Regex.IsMatch(number, @"^\+36\s20|30|70|31\s\d{3}\s\d{4}$");
        }

        public static bool ValidateEmail(string mail)
        {
            return Regex.IsMatch(mail, @"^([a-z0-9]+(?:[._-][a-z0-9]+)*)@([a-z0-9]+(?:[.-][a-z0-9]+)*\.[a-z]{2,})$");
        }
    }
}
