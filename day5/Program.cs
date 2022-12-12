using System;


namespace day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "input.txt"));

            Console.WriteLine($"1: {PartOne(input)}");
            //Console.WriteLine($"2: {PartTwo(input)}");
        }

        private static object PartOne(string[] input)
        {
            Stack<string> s1;
        }

        // private static object PartTwo(string[] input)
        // {
            
        // }
    }
}