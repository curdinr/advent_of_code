using System;

namespace day2
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
            int current = 0;

            foreach (string line in input)
            {
                string[] data = line.Split(' ');

                if (data[0] == "A") // stei
                {
                    if (data[1] == "X")
                    {
                        //stei vs stei = draw
                        current += 4;
                    }
                    else if (data[1] == "Y") 
                    {
                        //stei VS papier
                        current += 8;

                    }
                    else
                    {
                        //stei VS schär
                        current += 3;
                    }

                }
                else if (data[0] == "B") //papier
                {
                    if (data[1] == "X")
                    {
                        //papier VS stei
                        current += 1;
                    }
                    else if (data[1] == "Y")
                    {
                        //papier VS papier
                        current += 5;
                    }
                    else
                    {
                        //papier VS schär
                        current += 9;
                    }
                }
                else //schär
                {
                    if (data[1] == "X")
                    {
                        //schär VS stei
                        current += 7;
                    }
                    else if (data[1] == "Y")
                    {
                        //schär VS papier
                        current += 2;
                    }
                    else
                    {
                        //schär VS schär
                        current += 6;
                    }
                }
            }

            return current;
        }

        private static object PartTwo(string[] input)
        {
            int current = 0;
            foreach (string line in input)
            {
                string[] data = line.Split(' ');

                if (data[0] == "A") // stei
                {
                    if (data[1] == "X") //lose
                    {
                        current += 3;
                    }
                    else if (data[1] == "Y") //draw
                    {
                        current += 4;
                    }
                    else //win
                    {
                        current += 8;
                    }
                }
                else if (data[0] == "B") //papier
                {
                    if (data[1] == "X") //lose
                    {
                        current += 1;
                    }
                    else if (data[1] == "Y") //draw
                    {
                        current += 5;
                    }
                    else //win
                    {
                        current += 9;
                    }
                }
                else //schär
                {
                    if (data[1] == "X") //lose
                    {
                        current += 2;
                    }
                    else if (data[1] == "Y") //draw
                    {
                        current += 6;
                    }
                    else //win
                    {
                        current += 7;
                    }
                }
            }

            return current;
        }
    }
}