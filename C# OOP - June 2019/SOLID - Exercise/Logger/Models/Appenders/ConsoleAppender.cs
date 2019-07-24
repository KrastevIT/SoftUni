using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using System;
using System.Globalization;

namespace Logger.Models.Appenders
{
    public class ConsoleAppender : IAppender
    {
        private const string DATE_FORMAT = "M/dd/yyyy h:mm:ss tt";

        private int messagesAppended;

        public ConsoleAppender()
        {
            this.messagesAppended = 0;
        }
        public ConsoleAppender(ILayout layout, Level level)
            : this()
        {
            this.Layout = layout;
            this.Level = level;
        }

        public ILayout Layout { get; private set; }

        public Level Level { get; private set; }

        public void Append(IError error)
        {
            string format = this.Layout.Format;

            DateTime dateTime = error.DateTime;
            Level level = error.Level;
            string message = error.Message;

            string formattedMessage = string.Format(format,
                dateTime.ToString(DATE_FORMAT,
                CultureInfo.InvariantCulture),
                level.ToString(),
                message);

            Console.WriteLine(formattedMessage);
            this.messagesAppended++;

        }

        public override string ToString()
        {
            return $"Appender type: {GetType().Name}, Layout type: {Layout.GetType().Name}," +
                $" Report level: {Level.ToString()}, Messages appended: {messagesAppended},";
        }
    }
}
