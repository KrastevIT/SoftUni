using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models.Appenders
{
    public class FileAppender : IAppender
    {
        private int messagesAppended;

        public FileAppender()
        {
            this.messagesAppended = 0;
        }
        public FileAppender(ILayout layout, Level level, IFile file)
            : this()
        {
            this.Layout = layout;
            this.Level = level;
            this.File = file;
        }

        public ILayout Layout { get; private set; }

        public Level Level { get; private set; }

        public IFile File { get; private set; }

        public void Append(IError error)
        {
            string formattedMessage = this.File
                 .Write(this.Layout, error) + Environment.NewLine;

            System.IO.File.AppendAllText(this.File.Path,
                formattedMessage);

            this.messagesAppended++;
        }

        public override string ToString()
        {
            return $"Appender type: {GetType().Name}, Layout type: {Layout.GetType().Name}," +
                 $" Report level: {Level.ToString()}, Messages appended: {messagesAppended}," +
                 $" File Size: {File.Size}";
        }
    }
}
