using System.IO;

namespace AdventOfCodeDay01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = File.ReadLines("input.txt").ToList();
            List<int> calInts = new();
            int countCal = 0;

            foreach (var item in input)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    countCal += int.Parse(item);
                }
                else
                {
                    calInts.Add(countCal);
                    countCal = 0;
                }
            }

            calInts.Sort();

            Console.WriteLine($"The answer of part 1 is: { calInts.Max() }");
            Console.WriteLine($"The answer of part 2 is: { calInts.TakeLast(3).Sum() }");
        }
    }
}