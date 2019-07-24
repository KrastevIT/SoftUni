﻿using Logger.Exceptions;
using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using Logger.Models.Errors;
using System;
using System.Globalization;

namespace Logger.Factories
{
    public class ErrorFactory
    {
        private const string DATE_FORMAT = "M/dd/yyyy h:mm:ss tt";

        public IError GetError(string dateString, string levelString, string message)
        {
            Level level;

            bool hasParsed = Enum.TryParse<Level>(levelString, out level);

            if (!hasParsed)
            {
                throw new InvalidLevelTypeException();
            }

            DateTime dateTime;

            try
            {
                dateTime = DateTime.ParseExact(
                    dateString,
                    DATE_FORMAT,
                    CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                throw new InvalidDateFormatException();
            }

            return new Error(dateTime, message, level);
        }
    }
}
