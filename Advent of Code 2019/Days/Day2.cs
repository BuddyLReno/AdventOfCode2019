using System;

namespace AdventOfCode2019.Days
{
    public class Day2 : Day
    {
        private const string day1FilePath = "Inputs/AOCD1.txt";

        private enum OpCode
        {
            Add = 1,
            Multiply = 2,
            Halt = 99
        };

        public static string RunPart1()
        {
            return Enum.Parse<OpCode>("99").ToString();
        }
    }
}
