using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var queueOfNumbers = new Queue<int>();

            int[] operations = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int toAdd = operations[0];
            int topDequeue = operations[1];
            int magicNumber = operations[2];

            for (int i = 0; i < toAdd && i < numbers.Length; i++)
            {
                queueOfNumbers.Enqueue(numbers[i]);
            }

            for (int i = 0; i < topDequeue && queueOfNumbers.Count > 0; i++)
            {
                queueOfNumbers.Dequeue();
            }

            if (queueOfNumbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queueOfNumbers.Contains(magicNumber))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queueOfNumbers.Min());
            }
        }
    }
}
