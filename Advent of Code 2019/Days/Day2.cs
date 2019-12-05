using System;
using System.Collections.Generic;

namespace AdventOfCode2019
{
    namespace Days
    {
        public class Day2
        {
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
}
