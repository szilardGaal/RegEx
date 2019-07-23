using System;
using System.Text.RegularExpressions;

namespace regular_expressions

{
    public class RegexOperations
    {
        public static bool ValidName(string name)
        {
            return Regex.IsMatch(name, @"^(\b\p{Lu}[a-z]*\b\s?)+$");
        }

        public static bool ValidCellPhoneNumberHUN(string number)
        {
            return Regex.IsMatch(number, @"^\+36\s20|30|70|31\d{7}$");
        }

        public static bool ValidateEmail(string mail)
        {
            return Regex.IsMatch(mail, @"^([a-z0-9]+(?:[._-][a-z0-9]+)*)@([a-z0-9]+(?:[.-][a-z0-9]+)*\.[a-z]{2,})$");
        }

        public static string ReformatPhone(string number)
        {
            Match m = Regex.Match(number, @"^(\+36)\s(\d{2})(\d{3})(\d{4})");
            return String.Format("{0} ({1})/{2}-{3}", m.Groups[1], m.Groups[2], m.Groups[3], m.Groups[4]);
        }
    }
}
