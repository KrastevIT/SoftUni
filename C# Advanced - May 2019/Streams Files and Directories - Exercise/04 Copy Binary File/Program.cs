using System;
using System.IO;

namespace _04_Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string picPath = "copyMe.png";
            string picCopyPath = "copy-copy.png";

            using (FileStream streamReader = new FileStream(picPath, FileMode.Open))
            {
                using (FileStream streamWrite = new FileStream(picCopyPath, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] byteArray = new byte[4096];

                        int size = streamReader.Read(byteArray, 0, byteArray.Length);

                        if (size == 0)
                        {
                            break;
                        }

                        streamWrite.Write(byteArray, 0, size);
                    }
                }
            }
        }
    }
}
