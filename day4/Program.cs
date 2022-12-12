﻿using System;
using System.Text.RegularExpressions;

namespace day4
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
            int index = 0;
            string regex = @"(?<g1>\d+)-(?<g2>\d+),(?<g3>\d+)-(?<g4>\d+)";
            foreach (string line in input) 
            {
                Match match = Regex.Match(line, regex);
                var startSectionOne  = Int32.Parse(match.Groups["g1"].Value);
                var endSectionOne = Int32.Parse(match.Groups["g2"].Value);
                var startSectionTwo = Int32.Parse(match.Groups["g3"].Value);
                var endSectionTwo = Int32.Parse(match.Groups["g4"].Value);

                if ((startSectionOne <= startSectionTwo && endSectionOne >= endSectionTwo) || (startSectionTwo <= startSectionOne && endSectionOne <= endSectionTwo))
                    index++;
            }

            return index;
        }

        private static object PartTwo(string[] input)
        {
            int index = 0;
            string regex = @"(?<g1>\d+)-(?<g2>\d+),(?<g3>\d+)-(?<g4>\d+)";
            foreach (string line in input)
            {
                Match match = Regex.Match(line, regex);
                var startSectionOne = Int32.Parse(match.Groups["g1"].Value);
                var endSectionOne = Int32.Parse(match.Groups["g2"].Value);
                var startSectionTwo = Int32.Parse(match.Groups["g3"].Value);
                var endSectionTwo = Int32.Parse(match.Groups["g4"].Value);

                if (Enumerable.Range(startSectionOne, endSectionOne - startSectionOne + 1).Any(x => x == startSectionTwo || x == endSectionTwo) || Enumerable.Range(startSectionTwo, endSectionTwo - startSectionTwo + 1).Any(x => x == startSectionOne || x == endSectionOne)) 
                    index++;
            }

            return index;
        }
    }
}