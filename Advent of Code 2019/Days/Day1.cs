using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AdventOfCode2019
{
    namespace Days
    {
        class Day1
        {
            private const string day1FilePath = "Inputs/AOCD1.txt";

            public static string RunPart1()
            {
                var moduleMassList = ReadFile(day1FilePath);
                var estimatedFuel = moduleMassList.Sum(CalculateFuel);
                return $"Estimated fuel: { estimatedFuel }";
            }

            public static string RunPart2()
            {
                var moduleMassList = ReadFile(day1FilePath);
                var estimatedFuel = moduleMassList.Sum(CalculateFuelWithRequirement);
                return $"Estimated fuel: { estimatedFuel }";
            }

            private static int CalculateFuel(string input)
            {
                var mass = double.Parse(input);
                var fuel = FuelAlgorithm(mass);
                return (int)fuel;
            }

            private static int CalculateFuelWithRequirement(string input)
            {
                var mass = double.Parse(input);
                var fuel = FuelAlgorithm(mass);
                var fuelRequirement = CalculateFuelRequirement(fuel);
                return (int)fuelRequirement;
            }

            private static double CalculateFuelRequirement(double fuel)
            {
                var requirement = FuelAlgorithm(fuel);

                while (requirement > 0)
                {
                    fuel += requirement;
                    requirement = FuelAlgorithm(requirement);
                }

                return fuel;
            }

            private static double FuelAlgorithm(double mass)
            {
                return Math.Floor(mass / 3) - 2;
            }

            private static IEnumerable<string> ReadFile(string filePath)
            {
                return File.ReadLines(filePath).ToList();
            }
        }
    }
}