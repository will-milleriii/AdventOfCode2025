using AdventOfCode2025.Helpers;

namespace AdventOfCode2025.Solutions
{
    public class Day01
    {

        public int Part1()
        {
            var filePath = @"C:\Users\willm\source\repos\AdventOfCode2025\AdventOfCode2025\Inputs\Day01.txt";

            var input = FileReader.ReadLines(filePath);
            var currentNumber = 50;
            var actualPassword = 0;

            try
            {
                foreach (var line in input)
                {
                    //need to parse out L or R
                    char direction = line[0];
                    var number = int.Parse(line[1..]);

                    if (direction is 'L')
                    {
                        Console.WriteLine($"Subtractions {number} from {currentNumber}");
                        currentNumber -= number;
                    }

                    if (direction is 'R')
                    {
                        Console.WriteLine($"Adding {number} to {currentNumber}");
                        currentNumber += number;
                    }

                    if (currentNumber % 100 is 0)
                    {
                        Console.WriteLine($"Current number is {currentNumber}. Updating actual password from {actualPassword}");
                        actualPassword++;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return actualPassword;
        }

        public int Part2()
        {
            var filePath = @"C:\Users\willm\source\repos\AdventOfCode2025\AdventOfCode2025\Inputs\Day01.txt";

            var input = FileReader.ReadLines(filePath);

            var currentNumber = 50;
            var actualPassword = 0;

            foreach (var line in input)
            {
                //need to parse out L or R
                char direction = line[0];
                var number = int.Parse(line[1..]);
                var operand = 0;

                if (direction is 'L')
                    operand = -1;

                if (direction is 'R')
                    operand = 1; 

                for (var i = 0; i < number; i++)
                {
                    currentNumber += operand;
                    if (currentNumber % 100 is 0)
                        actualPassword++;
                }
            }

            return actualPassword;
        }
    }
}
