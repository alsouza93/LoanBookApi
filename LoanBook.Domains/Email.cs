using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LoanBook.Domains
{
    public class Email
    {
        private static readonly Regex EmailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.Compiled);

        public string Address { get; private set; }

        public static Email FromString(string address)
        {
            if (!EmailRegex.IsMatch(address))
            {
                throw new ArgumentException("Invalid email.");
            }
            return new Email(address);
        }
        private Email(string address)
        {
            Address = address;
        }      
    }
}
