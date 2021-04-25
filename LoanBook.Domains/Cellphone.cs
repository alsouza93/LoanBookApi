using System;
using System.Text.RegularExpressions;

namespace LoanBook.Domains
{
    public sealed class Cellphone
    {
        private static readonly Regex MobileRegex = new Regex(@"\(?\b([1-9]{2}|0[1-9]{2})\)?\s?[0-9]{5}[- ]?[0-9]{4}\b", RegexOptions.Compiled);
        private static readonly string AreaCode = "55";
        public string Number { get; private set; }

        public static Cellphone FromString(string number)
        {
            if (!MobileRegex.IsMatch(number))
            {
                throw new ArgumentException("Invalid cellphone number");
            }
            return new Cellphone(number);
        }
        private Cellphone(string number)
        {
            if (!MobileRegex.IsMatch(number))
            {
                throw new ArgumentException("Invalid cellphone number");
            }
            Number = number;
        }

        public string GetNumberWithAreaCode()
        {
            return AreaCode + Number;
        }
    }
}