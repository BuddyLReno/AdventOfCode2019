using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2019.Days
{
    public class Day2 : Day
    {
        private const string day2FilePath = "Inputs/AOCD2.txt";

        public static string RunPart1()
        {
            var instructions = LoadInstructions();
            var partA = new List<int>(instructions)
            {
                [1] = 12,
                [2] = 2
            };

            RunProgram(partA);
            return partA[0].ToString();
        }

        public static string RunPart2()
        {
            var instructions = LoadInstructions();

            for (int noun = 0; noun < 100; noun++)
                for (int verb = 0; verb < 100; verb++)
                {
                    var partB = new List<int>(instructions);
                    partB[1] = noun;
                    partB[2] = verb;

                    RunProgram(partB);
                    if (partB[0] == 19690720)
                    {
                        return (noun * 100 + verb).ToString();
                    }
                }

            return "Could not find answer.";
        }

        private static List<Int32> LoadInstructions()
        {
            return ReadFile(day2FilePath)
                .First()
                .Split(',')
                .Select(s => Convert.ToInt32(s))
                .ToList();
        }

        private static void RunProgram(List<int> instructions)
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
