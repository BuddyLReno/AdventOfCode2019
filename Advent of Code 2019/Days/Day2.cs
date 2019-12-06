using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2019.Days
{
    public class Day2 : Day
    {
        private const string day2FilePath = "Inputs/AOCD2.txt";

        public static void ExecuteDay()
        {
            var instructions = ReadFile(day2FilePath)
                .First()
                .Split(',')
                .Select(s => Convert.ToInt32(s))
                .ToList();

            var partA = new List<int>(instructions);
            partA[1] = 12;
            partA[2] = 2;

            RunProgram(partA);
            Console.WriteLine(partA[0].ToString());

            for (int noun = 0; noun < 100; noun++)
                for (int verb = 0; verb < 100; verb++)
                {
                    var partB = new List<int>(instructions);
                    partB[1] = noun;
                    partB[2] = verb;

                    RunProgram(partB);
                    if (partB[0] == 19690720)
                    {
                        var partBAnswer = (noun * 100 + verb).ToString();
                        return;
                    }
                }
        }

        static void RunProgram(List<int> instructions)
        {
            var ip = 0;
            while (ip < instructions.Count && instructions[ip] != 99)
            {
                var num1 = instructions[instructions[ip + 1]];
                var num2 = instructions[instructions[ip + 2]];
                var res = instructions[ip] switch
                {
                    1 => num1 + num2,
                    2 => num1 * num2,
                    _ => 0,
                };
                instructions[instructions[ip + 3]] = res;

                ip += 4;
            }
        }
    }
}
