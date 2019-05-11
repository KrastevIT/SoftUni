using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackOfParentheses = new Stack<char>();

            string parentheses = Console.ReadLine();

            char[] openParentheses = new char[] { '(', '[', '{' };

            bool isValid = true;

            for (int i = 0; i < parentheses.Length; i++)
            {
                char currentBracket = parentheses[i];

                if (openParentheses.Contains(currentBracket))
                {
                    stackOfParentheses.Push(currentBracket);
                    continue;
                }

                if (stackOfParentheses.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (stackOfParentheses.Peek() == '(' && currentBracket == ')')
                {
                    stackOfParentheses.Pop();
                }
                else if (stackOfParentheses.Peek() == '[' && currentBracket == ']')
                {
                    stackOfParentheses.Pop();
                }
                else if (stackOfParentheses.Peek() == '{' && currentBracket == '}')
                {
                    stackOfParentheses.Pop();
                }
            }

            if (isValid && stackOfParentheses.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }

    }
}
