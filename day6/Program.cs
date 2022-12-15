using System;
using System.Text.RegularExpressions;

namespace day5
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "puzzleInput.txt"));

            Console.WriteLine($"1: {SolvePuzzle(input, 4)}");
            Console.WriteLine($"2: {SolvePuzzle(input, 14)}");
        }

        private static object SolvePuzzle(string input, int lenghtPart)
        {
            char[] chars = input.ToCharArray();
            Queue<char> queue = new Queue<char>();
            for (int i = 0; i < chars.Length; i++)
            {
                if (queue.Count == lenghtPart)
                {
                    if (!queue.GroupBy(x => x).Any(g => g.Count() > 1))
                    {
                        return i;
                    }

                    queue.Dequeue();
                }

                queue.Enqueue(chars[i]);
            }

            return 0;
        }
    }
}
