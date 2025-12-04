using AdventOfCode2025.Helpers;
using System.Text;

namespace AdventOfCode2025.Solutions
{
    public class Day03
    {
        public long Part1()
        {
            var filePath = @"C:\Users\willm\source\repos\AdventOfCode2025\AdventOfCode2025\Inputs\Day03.txt";

            var input = FileReader.ReadLines(filePath);
            var largestValues = new List<long>();

            foreach (var line in input)
            {
                var original = line;
                var spliced = line[..^1];

                var largestDigit = spliced.Max();
                // take the index of the larget. now only search after that index in the original
                var index = original.IndexOf(largestDigit) + 1;
                original = original[index..];

                var secondLargest = original.Max();
                var total = largestDigit.ToString() + secondLargest.ToString();
                largestValues.Add(long.Parse(total));
            }

            var sum = largestValues.Sum();
            return sum; 
        }

        public long Part2()
        {
            // so now instead of 2 you would do this for 12
            // lol brute force goes brrrrrrrrrr
            // now instead of the last index we need to slice by at least 12(could be more)

            var filePath = @"C:\Users\willm\source\repos\AdventOfCode2025\AdventOfCode2025\Inputs\Day03.txt";

            var input = FileReader.ReadLines(filePath);
            var largestValues = new List<long>();

            foreach (var line in input)
            {
                var result = new StringBuilder();
                var index = 0;
                var digitsNeeded = 12;

                for (var i = 0; i < digitsNeeded; i++)
                {
                    var digitsRemainingToCapture = digitsNeeded - 1 - i; // holy hell what a var name dude
                    var lastValidIndex = line.Length - digitsRemainingToCapture;
                    var maxDigit = ' ';
                    var newIndex = 0;

                    for (var j = index; j <  lastValidIndex; j++)
                    {
                        if (line[j] > maxDigit)
                        {
                            maxDigit = line[j];
                            newIndex = j;
                        }
                    }

                    result.Append(maxDigit);
                    index = newIndex + 1;
                }

                largestValues.Add(long.Parse(result.ToString()));

            }

            var sum = largestValues.Sum();
            return sum;
        }

    }
}
