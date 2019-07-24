using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Exceptions
{
    public class InvalidLayoutTypeException : Exception
    {
        private const string EXC_MESSAGE = "Invalid Layout Type!";

        public InvalidLayoutTypeException()
            :base(EXC_MESSAGE)
        {

        }

        public InvalidLayoutTypeException(string message) 
            : base(message)
        {

        }
    }
}
