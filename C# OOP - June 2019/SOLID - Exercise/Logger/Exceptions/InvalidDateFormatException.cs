using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Exceptions
{
    public class InvalidDateFormatException : Exception
    {
        private const string EXC_MESSAGE = "Invalid DateTime Format!";

        public InvalidDateFormatException()
            :base(EXC_MESSAGE)
        {

        }
        public InvalidDateFormatException(string message) 
            : base(message)
        {
        }

        public InvalidDateFormatException(string message, Exception innerException)
            : base(EXC_MESSAGE, innerException)
        {

        }
    }
}
