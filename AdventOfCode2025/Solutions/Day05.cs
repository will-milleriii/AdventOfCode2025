using AdventOfCode2025.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2025.Solutions
{
    public class Day05
    {

        public long Part1()
        {
            var filePath = @"C:\Users\willm\source\repos\AdventOfCode2025\AdventOfCode2025\Inputs\Day05.txt";

            var input = FileReader.ReadLines(filePath);

            var index = input.IndexOf("");
           
            var ingredientIds = input[..index];
            var ingredients = input[(index+1)..];
            ingredients.Sort();
            ingredientIds.Sort();

            var validIngredientRecords = new List<Range>(input.Length);
            var validFoundIngredients = new List<long>();

            foreach (var ingredientSpan in ingredientIds)
            {
                var splitIndex = ingredientSpan.IndexOf("-");
                var minInt = long.Parse(ingredientSpan[..splitIndex]);
                var maxInt = long.Parse(ingredientSpan[(splitIndex+1)..]);

                validIngredientRecords.Add(new Range(minInt, maxInt));

            }

            foreach (var possibleIngredient in ingredients)
            {
                if (IsValidIngredient(validIngredientRecords, long.Parse(possibleIngredient)))
                {
                    validFoundIngredients.Add(long.Parse(possibleIngredient));
                }

            }
            var totalValidIngredients = validFoundIngredients.Count;
            return totalValidIngredients;
        }

        public long Part2()
        {
            return 2;
        }

        private bool IsValidIngredient(List<Range> ranges, long value)
        {

            foreach (var range in ranges)
            {
                if (value >= range.Min && value <= range.Max)
                    return true;
            }
            return false;
        }
        record Range(long Min, long Max);
    }
}
