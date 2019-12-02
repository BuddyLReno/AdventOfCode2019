using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Advent_of_Code_2019
{
    class AOCD1
    {
        private const string filePath = "/Users/buddy.reno/Downloads/AOCD1.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Advent of Code Day 1");
            Console.WriteLine("******************************");
            var moduleMassList = ReadFile(filePath);
            var estimatedFuel = moduleMassList.Sum(CalculateFuel);
            Console.WriteLine($"Estimated fuel: { estimatedFuel }");
        }

        private static int CalculateFuel(string input)
        {
            var mass = double.Parse(input);
            var fuel = FuelAlgorithm(mass);
            var fuelRequirement = CalculateFuelRequirement(fuel);
            return (int) fuelRequirement;
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