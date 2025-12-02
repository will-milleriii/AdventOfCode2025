using AdventOfCode2025.Solutions;
using System.Diagnostics;

namespace AdventOfCode2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solutions = new Day02();

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine(solutions.Part1());
            stopwatch.Stop();
            var time = stopwatch.Elapsed;
            Console.WriteLine(time);
        }
    }
}
