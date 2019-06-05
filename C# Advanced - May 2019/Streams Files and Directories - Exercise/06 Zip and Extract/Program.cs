using System;
using System.IO;
using System.IO.Compression;

namespace _06_Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            var zipFile = @"..\..\..\myNewzip.zip";

            var file = "copyMe.png";

            using (var arhive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                arhive.CreateEntryFromFile(file, Path.GetFileName(file));
            }
        }
    }
}
