using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02_Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string regex = @"(?<valid>[\d\w]{16,25})";

            var validKeys = Regex.Matches(input, regex);

            var finalCode = new List<string>();

            foreach (Match match in validKeys)
            {
                int length = match.Length;
                string code = match.ToString().ToUpper();

                for (int i = 0; i < code.Length; i++)
                {
                    if (char.IsDigit(code[i]))
                    {
                        int num = int.Parse(code[i].ToString()) - 9;
                        num = Math.Abs(num);
                        string number = num.ToString();

                        code = code.Remove(i, 1);
                        code = code.Insert(i, number);

                    }
                }

                var currentCode = new StringBuilder();

                if (length == 16)
                {
                    for (int i = 0; i < length; i++)
                    {
                        if (i % 4 == 0 && i > 0)
                        {
                            currentCode.Append("-");
                        }

                        currentCode.Append(code[i]);
                    }
                }
                else if (length == 25)
                {
                    for (int i = 0; i < length; i++)
                    {
                        if (i % 5 == 0 && i > 0)
                        {
                            currentCode.Append("-");
                        }

                        currentCode.Append(code[i]);
                    }
                }

                finalCode.Add(currentCode.ToString());
            }

            int endIndex = 1;

            foreach (var item in finalCode)
            {
                if (finalCode.Count == 1)
                {
                    Console.Write(item);
                }
                else if (finalCode.Count == endIndex)
                {
                    Console.Write(item);
                }
                else
                {
                    Console.Write(item + ", ");
                }

                endIndex++;
            }
        }
    }
}
