using AdventOfCode2025.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2025.Solutions
{
    public class Day02
    {

        public long Part1()
        {
            var filePath = @"C:\Users\willm\source\repos\AdventOfCode2025\AdventOfCode2025\Inputs\Day02.txt";

            var input = FileReader.ReadText(filePath);
            var ranges = input.Split(",");
            var invalidNums = new List<long>();
            foreach (var range in ranges)
            {
                var numbers = range.Split("-");
                var firstNum = numbers[0];
                var lastNum = numbers[1];
        
                if (firstNum[0] is '0')               
                    firstNum = firstNum.Substring(1);
                               
                for (var i = long.Parse(firstNum); i <= long.Parse(lastNum); i++)
                {
                    var currentAsString = i.ToString();
                    if (currentAsString.Length % 2 is not 0)
                        continue;
                    var half = currentAsString.Length / 2;
                    var isMatch = currentAsString.Substring(0, half) == currentAsString.Substring(half);
                    if (isMatch)
                        invalidNums.Add(long.Parse(currentAsString));
                }
            }
            var sum = invalidNums.Sum();
            return sum; 
        }

        public long Part2()
        {
            var filePath = @"C:\Users\willm\source\repos\AdventOfCode2025\AdventOfCode2025\Inputs\Day01.txt";

            var input = FileReader.ReadLines(filePath);
            return 2;
        }
    }
}
