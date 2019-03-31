using System;
using System.Linq;

namespace _10_LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fSize = int.Parse(Console.ReadLine());

            int[] fieldSize = new int[fSize];
            int[] bugsIndex = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string[] nextPosition = null;
            int positionToFly = 0;
            string direction = "";
            int lenghtToFly = 0;

            string command = "";

            foreach (int index in bugsIndex)
            {
                if (index < 0 || index >= fieldSize.Length)
                {
                    continue;
                }

                fieldSize[index] = 1;
            }
            while (true)
            {
                command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }
                else
                {
                    nextPosition = command.Split(" ").ToArray();
                }

                positionToFly = int.Parse(nextPosition[0]);
                direction = nextPosition[1];
                lenghtToFly = int.Parse(nextPosition[2]);

                if (positionToFly < 0 || positionToFly >= fSize)
                {
                    continue;
                }

                if (fieldSize[positionToFly] == 0)
                {
                    continue;
                }
                fieldSize[positionToFly] = 0;
                int currPosition = positionToFly;

                while (true)
                {
                    if (direction == "right")
                    {
                        currPosition += lenghtToFly;
                    }
                    if (direction == "left")
                    {
                        currPosition -= lenghtToFly;
                    }

                    if (currPosition < 0 || currPosition >= fSize)
                    {
                        break;
                    }

                    if (fieldSize[currPosition] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        fieldSize[currPosition] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", fieldSize));
        }
    }
}
