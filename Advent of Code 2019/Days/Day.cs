using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2019.Days
{
    public class Day
    {
        protected static IEnumerable<string> ReadFile(string filePath)
        {
            return File.ReadLines(filePath).ToList();
        }
    }
}
