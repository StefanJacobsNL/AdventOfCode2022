using System.IO;
using System.Linq;

namespace AdventOfCodeDay01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = File.ReadLines("input.txt").ToList();
            List<char> abc = new()
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };
            int answer1 = 0;
            List<char> itemTypes = new();

            foreach (var item in input)
            {
                var componentLenght = item.Count() / 2;

                List<char> firstComponent = item.Take(componentLenght).ToList();
                List<char> secondComponent = item.Skip(componentLenght).ToList();

                var comparedItemType = firstComponent.Where(x => secondComponent.Contains(x)).Distinct().ToList();

                if (comparedItemType != null && comparedItemType.Any())
                {
                    itemTypes.AddRange(comparedItemType);
                }
            }

            answer1 = itemTypes.Sum(x => abc.IndexOf(x) + 1);

            Console.WriteLine($"The answer of part 1 is: { answer1 }");
            //Console.WriteLine($"The answer of part 2 is: { calInts.TakeLast(3).Sum() }");
        }
    }
}