using System.IO;

namespace AdventOfCodeDay02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = File.ReadLines("input.txt").ToList();
            int answer1 = 0;
            int answer2 = 0;

            foreach (var item in input)
            {
                var splitString = item.Split();

                var opponent = splitString.First();
                var you = splitString.Last();

                if ("X" == you && "A" == opponent)
                {
                    answer1 += 4;
                    answer2 += 3;
                }
                else if ("X" == you && "B" == opponent)
                {
                    answer1 += 1;
                    answer2 += 1;
                }
                else if ("X" == you && "C" == opponent)
                {
                    answer1 += 7;
                    answer2 += 2;
                }
                else if ("Y" == you && "A" == opponent)
                {
                    answer1 += 8;
                    answer2 += 4;
                }
                else if ("Y" == you && "B" == opponent)
                {
                    answer1 += 5;
                    answer2 += 5;
                }
                else if ("Y" == you && "C" == opponent)
                {
                    answer1 += 2;
                    answer2 += 6;
                }
                else if ("Z" == you && "A" == opponent)
                {
                    answer1 += 3;
                    answer2 += 8;
                }
                else if ("Z" == you && "B" == opponent)
                {
                    answer1 += 9;
                    answer2 += 9;
                }
                else if ("Z" == you && "C" == opponent)
                {
                    answer1 += 6;
                    answer2 += 7;
                }
            }

            Console.WriteLine($"The answer of part 1 is: { answer1 }");
            Console.WriteLine($"The answer of part 2 is: { answer2 }");
        }
    }
}