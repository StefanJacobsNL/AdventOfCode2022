using System.IO;
using System.Linq;

namespace AdventOfCodeDay01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = File.ReadLines("input.txt").ToList();
            
            int answer1 = 0;
            int answer2 = 0;

            foreach (var textRow in input)
            {
                List<int> assignmentTexts = textRow.Split(',', '-').Select(int.Parse).ToList();

                if (assignmentTexts[0] >= assignmentTexts[2] && assignmentTexts[1] <= assignmentTexts[3])
                {
                    answer1++;
                }
                else if (assignmentTexts[2] >= assignmentTexts[0] && assignmentTexts[3] <= assignmentTexts[1])
                {
                    answer1++;
                }
            }

            Console.WriteLine($"The answer of part 1 is: { answer1 }");

            foreach (var textRow in input)
            {
                List<int> assignmentTexts = textRow.Split(',', '-').Select(int.Parse).ToList();

                if (assignmentTexts[0] >= assignmentTexts[2] && assignmentTexts[1] <= assignmentTexts[3])
                {
                    answer2++;
                }
                else if (assignmentTexts[2] >= assignmentTexts[0] && assignmentTexts[3] <= assignmentTexts[1])
                {
                    answer2++;
                }
                else if (assignmentTexts[1] >= assignmentTexts[2] && assignmentTexts[3] >= assignmentTexts[0])
                {
                    answer2++;
                }
                else if (assignmentTexts[2] >= assignmentTexts[1] && assignmentTexts[0] >= assignmentTexts[3])
                {
                    answer2++;
                }
            }


            Console.WriteLine($"The answer of part 2 is: { answer2 }");
        }
    }
}