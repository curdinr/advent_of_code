using System;

namespace day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "input.txt"));

            Console.WriteLine($"1:{PartOne(input)}");
            Console.WriteLine($"2:{PartTwo(input)}");
        }

        private static int PartOne(string[] input)
        {
            int max = 0;
            int current = 0;
            foreach (string line in input) 
            {
                if (line == "") 
                {
                    if (max < current)
                        max = current;

                    current = 0;
                    continue;
                }
                
                current += Int32.Parse(line);
            }

            return max;
        }

            private static int PartTwo(string[] input)
        {
            List<int> food = new List<int>();
            int current = 0;
            foreach (string line in input)
            {
                if (line == "")
                {
                    food.Add(current);

                    current = 0;
                    continue;
                }

                current += Int32.Parse(line);
            }

            food.Sort();

            return food.Skip(food.Count() - 3).Sum();
        }
    }
}