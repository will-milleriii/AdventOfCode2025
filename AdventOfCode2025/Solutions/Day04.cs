using AdventOfCode2025.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2025.Solutions
{
    public class Day04
    {

        public long Part1()
        {
            var filePath = @"C:\Users\willm\source\repos\AdventOfCode2025\AdventOfCode2025\Inputs\Day04.txt";

            var input = FileReader.ReadLines(filePath);

            int[] dirRow = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dirCol = { -1, 0, 1, -1, 1, -1, 0, 1 };
            const int Directions = 8;

            const char Value = '@';

            var total = 0;

            var rows = input.Length;
            var cols = input[0].Length;

            // loop through row first
            for (var i = 0; i < rows; i++)
            {
                //now loop through columns. this kind of sucks
                for (var j = 0; j < cols; j++)
                {
                    // gtfo if we don't have the char
                    if (input[i][j] != Value)
                        continue;

                    // now loop through indices
                    var matches = 0;
                    for (var k = 0; k < Directions; k++)
                    {
                        var newRowIndex = i + dirRow[k];
                        var newColIndex = j + dirCol[k];

                       if (IsIndexInbounds(newRowIndex, newColIndex, input) && input[newRowIndex][newColIndex] is Value)
                          matches++;
                    }

                    if (matches < 4)
                        total++;
                }
            }

            return total;
        }

        public bool IsIndexInbounds(int row, int col, string[] input)
        {
            return row >= 0 && row < input.Length && col >= 0 && col < input[0].Length;
        }

        public long Part2()
        {
            return 2;
        }
    }
}
