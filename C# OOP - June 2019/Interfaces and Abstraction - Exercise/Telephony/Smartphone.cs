using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Telephony
{
    public class Smartphone : ICalling, IBrowsing
    {
        public Smartphone()
        {

        }
        public string Browsing(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid URL!");
            }

            return $"Browsing: {url}!";
        }

        public string Calling(string phoneNumber)
        {
            if (!phoneNumber.All(x => char.IsDigit(x)))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Calling... {phoneNumber}";
        }
    }
}
