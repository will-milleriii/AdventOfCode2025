using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2025.Helpers
{
    public class FileReader
    {

        public static string[] ReadLines(string fileData)
        {
            var lines = new string[] { };

            if (fileData is null or { Length: 0 })
            {
                Console.WriteLine("No file data founde");
                return lines;
            }
                

            lines = ParseLines(fileData);
            return lines;
        }

        public static string ReadText(string fileData)
        {
            var text = "";

            if (fileData is null or { Length:0 })
            {
                Console.WriteLine("No file data provided");
                return text;
            }

            text = ParseText(fileData);
            return text;
        }

        private static string[] ParseLines(string fileData)
        {
            return File.ReadAllLines(fileData);
        }

        private static string ParseText(string fileData)
        {
            return File.ReadAllText(fileData); 
        }
    }
}
