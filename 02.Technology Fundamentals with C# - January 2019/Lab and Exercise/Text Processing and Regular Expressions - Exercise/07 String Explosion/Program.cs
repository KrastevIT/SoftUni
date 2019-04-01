using System;

namespace _07_String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int couter = 0;

            for (int i = 0; i < text.Length; i++)
            {

                if (char.IsDigit(text[i]))
                {
                    int explosionNumbers = int.Parse(text[i].ToString()) + couter;

                    for (int x = 0; x < explosionNumbers; x++)
                    {
                        if (text.Length <= i)
                        {
                            break;
                        }
                        if (text[i] != '>')
                        {
                            text = text.Remove(i, 1);
                        }
                        else
                        {
                            couter++;
                        }
                    }
                }
            }

            Console.WriteLine(text);
        }
    }
}
