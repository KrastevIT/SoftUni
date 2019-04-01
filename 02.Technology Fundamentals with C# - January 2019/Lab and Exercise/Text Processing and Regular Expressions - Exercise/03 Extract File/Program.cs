using System;

namespace _03_Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Console.ReadLine();

            string file = string.Empty;
            string extension = string.Empty;

            int startIndexOfFile = directory.LastIndexOf('\\') + 1;
            int endIndexOfFile = directory.LastIndexOf('.');

            for (int i = startIndexOfFile; i < endIndexOfFile; i++)
            {
                file += directory[i];
            }

            int startIndexOfExtension = directory.LastIndexOf('.') + 1;
            int endIndexOfExtencion = directory.Length;

            for (int i = startIndexOfExtension; i < endIndexOfExtencion; i++)
            {
                extension += directory[i];
            }

            Console.WriteLine($"File name: {file}");
            Console.WriteLine($"File extension: {extension}");

        }
    }
}
