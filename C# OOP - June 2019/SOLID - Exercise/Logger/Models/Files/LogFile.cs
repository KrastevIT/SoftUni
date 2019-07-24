using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using Logger.Models.IOManagement;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Logger.Models.Files
{
    public class LogFile : IFile
    {
        private const string DATE_FORMAT = "M/dd/yyyy h:mm:ss tt";

        private const string CURRENT_DIRECTORY = "\\logs\\";
        private const string CURRENT_FILE = "log.txt";

        private string currentPath;
        private IIOManager IOManager;

        public LogFile()
        {
            this.IOManager = new IOManager(CURRENT_DIRECTORY, CURRENT_FILE);
            this.currentPath = this.IOManager.GetCurrentPath();
            this.IOManager.EnsureDirectoryAndFileExist();
            this.Path = currentPath + CURRENT_DIRECTORY + CURRENT_FILE;
        }

        public string Path { get; private set; }

        public ulong Size => GetFileSize();


        public string Write(ILayout layout, IError error)
        {
            string format = layout.Format;

            DateTime dateTime = error.DateTime;
            string message = error.Message;
            Level level = error.Level;

            string formattedMessage = String.Format(format,
                dateTime.ToString(DATE_FORMAT,
                CultureInfo.InvariantCulture),
                level.ToString(),
                message);

            return formattedMessage;
        }

        private ulong GetFileSize()
        {
            string text = File.ReadAllText(this.Path);

            ulong size = (ulong)text
                .ToCharArray()
                .Where(c => Char.IsLetter(c))
                .Sum(c => (int)c);

            return size;
        }
    }
}
