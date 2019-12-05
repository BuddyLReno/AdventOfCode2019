using System;
using System.Linq;

namespace AdventOfCode2019.Days
{
    public class Day2 : Day
    {
        private const string day2FilePath = "Inputs/AOCD2.txt";

        private enum OpCode
        {
            Add = 1,
            Multiply = 2,
            Halt = 99
        };

        public static string RunPart1()
        {
            var inputs = ReadFile(day2FilePath).First().Split(",");
            int currentIndex = 0;
            OpCode currentOpCode = Enum.Parse<OpCode>(inputs[currentIndex]);

            while (currentOpCode != OpCode.Halt)
            {
                if (currentOpCode == OpCode.Add)
                {
                    var leftHand = inputs[int.Parse(inputs[currentIndex + 1])];
                    var rightHand = inputs[int.Parse(inputs[currentIndex + 2])];
                }
            }

            return "";
            
        }
    }
}
