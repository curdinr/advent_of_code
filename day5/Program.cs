using System;
using System.Text.RegularExpressions;

namespace day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "input.txt"));

            Console.WriteLine($"1: {PartOne(input)}");
            Console.WriteLine($"2: {PartTwo(input)}");
        }


        private static object PartOne(string[] input)
        {
            Stack<string> s1 = new Stack<string>(new[] { "Q", "M", "G", "C", "L" });
            Stack<string> s2 = new Stack<string>(new[] { "R", "D", "L", "C", "T", "F", "H", "G" });
            Stack<string> s3 = new Stack<string>(new[] { "V", "J", "F", "N", "M", "T", "W", "R" });
            Stack<string> s4 = new Stack<string>(new[] { "J", "F", "D", "V", "Q", "P" });
            Stack<string> s5 = new Stack<string>(new[] { "N", "F", "M", "S", "L", "B", "T" });
            Stack<string> s6 = new Stack<string>(new[] { "R", "N", "V", "H", "C", "D", "P" });
            Stack<string> s7 = new Stack<string>(new[] { "H", "C", "T" });
            Stack<string> s8 = new Stack<string>(new[] { "G", "S", "J", "V", "Z", "N", "H", "P" });
            Stack<string> s9 = new Stack<string>(new[] { "Z", "F", "H", "G" });

            Dictionary<int, Stack<string>> dic = new Dictionary<int, Stack<string>>();
            dic.Add(1, s1);
            dic.Add(2, s2);
            dic.Add(3, s3);
            dic.Add(4, s4);
            dic.Add(5, s5);
            dic.Add(6, s6);
            dic.Add(7, s7);
            dic.Add(8, s8);
            dic.Add(9, s9);

            string regex = @"move (\d+) from (\d+) to (\d+)";
            foreach (string line in input)
            {
                Match match = Regex.Match(line, regex);
                var amount = Int32.Parse(match.Groups[1].Value);
                var from = Int32.Parse(match.Groups[2].Value);
                var to = Int32.Parse(match.Groups[3].Value);

                var fromStack = dic[from];
                var toStack = dic[to];

                for (int i = 0; i < amount; i++)
                {
                    var t = fromStack.Pop();
                    toStack.Push(t);
                }
            }

            string ttt = "";
            foreach (var t in dic)
            {
                ttt += t.Value.Pop();
            }

            return ttt;
        }

        private static object PartTwo(string[] input)
        {
            Stack<string> s1 = new Stack<string>(new[] { "Q", "M", "G", "C", "L" });
            Stack<string> s2 = new Stack<string>(new[] { "R", "D", "L", "C", "T", "F", "H", "G" });
            Stack<string> s3 = new Stack<string>(new[] { "V", "J", "F", "N", "M", "T", "W", "R" });
            Stack<string> s4 = new Stack<string>(new[] { "J", "F", "D", "V", "Q", "P" });
            Stack<string> s5 = new Stack<string>(new[] { "N", "F", "M", "S", "L", "B", "T" });
            Stack<string> s6 = new Stack<string>(new[] { "R", "N", "V", "H", "C", "D", "P" });
            Stack<string> s7 = new Stack<string>(new[] { "H", "C", "T" });
            Stack<string> s8 = new Stack<string>(new[] { "G", "S", "J", "V", "Z", "N", "H", "P" });
            Stack<string> s9 = new Stack<string>(new[] { "Z", "F", "H", "G" });

            Dictionary<int, Stack<string>> dic = new Dictionary<int, Stack<string>>();
            dic.Add(1, s1);
            dic.Add(2, s2);
            dic.Add(3, s3);
            dic.Add(4, s4);
            dic.Add(5, s5);
            dic.Add(6, s6);
            dic.Add(7, s7);
            dic.Add(8, s8);
            dic.Add(9, s9);

            string regex = @"move (\d+) from (\d+) to (\d+)";
            foreach (string line in input)
            {
                Match match = Regex.Match(line, regex);
                var amount = Int32.Parse(match.Groups[1].Value);
                var from = Int32.Parse(match.Groups[2].Value);
                var to = Int32.Parse(match.Groups[3].Value);

                var fromStack = dic[from];
                var toStack = dic[to];

                List<string> strings = new List<string>();
                for (int i = 0; i < amount; i++)
                {
                    var t = fromStack.Pop();
                    strings.Add(t);
                }

                while (strings.Count != 0)
                {
                    toStack.Push(strings.Last());

                    strings.RemoveAt(strings.Count - 1);
                }
            }

            string ttt = "";
            foreach (var t in dic)
            {
                ttt += t.Value.Pop();
            }

            return ttt;
        }
    }
}