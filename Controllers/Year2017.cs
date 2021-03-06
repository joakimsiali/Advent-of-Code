using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Advent_of_Code.Controllers
{
    public class Year2017 : IYear
    {
        private const string pathInputs = "./inputs/2017";

        public Year2017() { }

        #region Day 1

        public void Day1()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day1.txt"))
            {
                part1 += Day1Part1(input);
                part2 += Day1Part2(input);
            }

            Console.WriteLine($"2017 - Day 1 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 1 - Part 2 : {part2}");
        }

        public static int Day1Part1(string input)
        {
            return 0;
        }

        public static int Day1Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 2

        public void Day2()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day2.txt"))
            {
                var array = input.Split(' ').Select(s => Int32.Parse(s.ToString())).ToArray();

                part1 += Day2Part1(array);
                part2 += Day2Part2(array);
            }

            Console.WriteLine($"2017 - Day 2 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 2 - Part 2 : {part2}");
        }

        public static int Day2Part1(int[] array)
        {
            return array.Max() - array.Min();
        }

        public static int Day2Part2(int[] array)
        {
            var total = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j && array[i] % array[j] == 0)
                    {
                        total += array[i] / array[j];
                        break;
                    }
                }
            }

            return total;
        }

        #endregion

        #region Day 3

        public void Day3()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day3.txt"))
            {
                part1 += Day3Part1(input);
                part2 += Day3Part2(input);
            }

            Console.WriteLine($"2017 - Day 3 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 3 - Part 2 : {part2}");
        }

        public static int Day3Part1(string input)
        {
            return 0;
        }

        public static int Day3Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 4

        public void Day4()
        {

        }

        public static int Day4Part1(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                var integer = -1;
                StringBuilder sb = new StringBuilder();

                do
                {
                    integer++;

                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes($"{input}{integer}");
                    byte[] hashBytes = md5.ComputeHash(inputBytes);

                    sb = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        sb.Append(hashBytes[i].ToString("X2"));
                    }
                } while (!sb.ToString().StartsWith("00000"));

                return integer;
            }
        }

        public static int Day4Part2(string input, int resultPart1)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                var integer = resultPart1 - 1;
                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();

                do
                {
                    integer++;

                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes($"{input}{integer}");
                    byte[] hashBytes = md5.ComputeHash(inputBytes);

                    sb = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        sb.Append(hashBytes[i].ToString("X2"));
                    }
                } while (!sb.ToString().StartsWith("000000"));

                return integer;
            }
        }

        #endregion

        #region Day 5

        public void Day5()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day5.txt"))
            {
                part1 += Day5Part1(input);
                part2 += Day5Part2(input);
            }

            Console.WriteLine($"2017 - Day 5 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 5 - Part 2 : {part2}");
        }

        public static int Day5Part1(string input)
        {
            var bannedWords = new string[4] { "ab", "cd", "pq", "xy" };

            if (bannedWords.Any(input.Contains))
            {
                return 0;
            }

            return 1;
        }

        public static int Day5Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 6

        public void Day6()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day6.txt"))
            {
                part1 += Day6Part1(input);
                part2 += Day6Part2(input);
            }

            Console.WriteLine($"2017 - Day 6 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 6 - Part 2 : {part2}");
        }

        public static int Day6Part1(string input)
        {
            return 0;
        }

        public static int Day6Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 7

        public void Day7()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day7.txt"))
            {
                part1 += Day7Part1(input);
                part2 += Day7Part2(input);
            }

            Console.WriteLine($"2017 - Day 7 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 7 - Part 2 : {part2}");
        }

        public static int Day7Part1(string input)
        {
            return 0;
        }

        public static int Day7Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 8

        public void Day8()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day8.txt"))
            {
                part1 += Day8Part1(input);
                part2 += Day8Part2(input);
            }

            Console.WriteLine($"2017 - Day 8 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 8 - Part 2 : {part2}");
        }

        public static int Day8Part1(string input)
        {
            return 0;
        }

        public static int Day8Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 9

        public void Day9()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day9.txt"))
            {
                part1 += Day9Part1(input);
                part2 += Day9Part2(input);
            }

            Console.WriteLine($"2017 - Day 9 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 9 - Part 2 : {part2}");
        }

        public static int Day9Part1(string input)
        {
            return 0;
        }

        public static int Day9Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 10

        public void Day10()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day10.txt"))
            {
                part1 += Day10Part1(input);
                part2 += Day10Part2(input);
            }

            Console.WriteLine($"2017 - Day 10 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 10 - Part 2 : {part2}");
        }

        public static int Day10Part1(string input)
        {
            return 0;
        }

        public static int Day10Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 11

        public void Day11()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day11.txt"))
            {
                part1 += Day11Part1(input);
                part2 += Day11Part2(input);
            }

            Console.WriteLine($"2017 - Day 11 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 11 - Part 2 : {part2}");
        }

        public static int Day11Part1(string input)
        {
            return 0;
        }

        public static int Day11Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 12

        public void Day12()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day12.txt"))
            {
                part1 += Day12Part1(input);
                part2 += Day12Part2(input);
            }

            Console.WriteLine($"2017 - Day 12 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 12 - Part 2 : {part2}");
        }

        public static int Day12Part1(string input)
        {
            return 0;
        }

        public static int Day12Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 13

        public void Day13()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day13.txt"))
            {
                part1 += Day13Part1(input);
                part2 += Day13Part2(input);
            }

            Console.WriteLine($"2017 - Day 13 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 13 - Part 2 : {part2}");
        }

        public static int Day13Part1(string input)
        {
            return 0;
        }

        public static int Day13Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 14

        public void Day14()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day14.txt"))
            {
                part1 += Day14Part1(input);
                part2 += Day14Part2(input);
            }

            Console.WriteLine($"2017 - Day 14 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 14 - Part 2 : {part2}");
        }

        public static int Day14Part1(string input)
        {
            return 0;
        }

        public static int Day14Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 15

        public void Day15()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day15.txt"))
            {
                part1 += Day15Part1(input);
                part2 += Day15Part2(input);
            }

            Console.WriteLine($"2017 - Day 15 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 15 - Part 2 : {part2}");
        }

        public static int Day15Part1(string input)
        {
            return 0;
        }

        public static int Day15Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 16

        public void Day16()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day16.txt"))
            {
                part1 += Day16Part1(input);
                part2 += Day16Part2(input);
            }

            Console.WriteLine($"2017 - Day 16 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 16 - Part 2 : {part2}");
        }

        public static int Day16Part1(string input)
        {
            return 0;
        }

        public static int Day16Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 17

        public void Day17()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day17.txt"))
            {
                part1 += Day17Part1(input);
                part2 += Day17Part2(input);
            }

            Console.WriteLine($"2017 - Day 17 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 17 - Part 2 : {part2}");
        }

        public static int Day17Part1(string input)
        {
            return 0;
        }

        public static int Day17Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 18

        public void Day18()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day18.txt"))
            {
                part1 += Day18Part1(input);
                part2 += Day18Part2(input);
            }

            Console.WriteLine($"2017 - Day 18 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 18 - Part 2 : {part2}");
        }

        public static int Day18Part1(string input)
        {
            return 0;
        }

        public static int Day18Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 19

        public void Day19()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day19.txt"))
            {
                part1 += Day19Part1(input);
                part2 += Day19Part2(input);
            }

            Console.WriteLine($"2017 - Day 19 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 19 - Part 2 : {part2}");
        }

        public static int Day19Part1(string input)
        {
            return 0;
        }

        public static int Day19Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 20

        public void Day20()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day20.txt"))
            {
                part1 += Day20Part1(input);
                part2 += Day20Part2(input);
            }

            Console.WriteLine($"2017 - Day 20 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 20 - Part 2 : {part2}");
        }

        public static int Day20Part1(string input)
        {
            return 0;
        }

        public static int Day20Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 21

        public void Day21()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day21.txt"))
            {
                part1 += Day21Part1(input);
                part2 += Day21Part2(input);
            }

            Console.WriteLine($"2017 - Day 21 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 21 - Part 2 : {part2}");
        }

        public static int Day21Part1(string input)
        {
            return 0;
        }

        public static int Day21Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 22

        public void Day22()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day22.txt"))
            {
                part1 += Day22Part1(input);
                part2 += Day22Part2(input);
            }

            Console.WriteLine($"2017 - Day 22 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 22 - Part 2 : {part2}");
        }

        public static int Day22Part1(string input)
        {
            return 0;
        }

        public static int Day22Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 23

        public void Day23()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day23.txt"))
            {
                part1 += Day23Part1(input);
                part2 += Day23Part2(input);
            }

            Console.WriteLine($"2017 - Day 23 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 23 - Part 2 : {part2}");
        }

        public static int Day23Part1(string input)
        {
            return 0;
        }

        public static int Day23Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 24

        public void Day24()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day24.txt"))
            {
                part1 += Day24Part1(input);
                part2 += Day24Part2(input);
            }

            Console.WriteLine($"2017 - Day 24 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 24 - Part 2 : {part2}");
        }

        public static int Day24Part1(string input)
        {
            return 0;
        }

        public static int Day24Part2(string input)
        {
            return 0;
        }

        #endregion

        #region Day 25

        public void Day25()
        {
            var part1 = 0;
            var part2 = 0;

            foreach (var input in File.ReadLines($"{pathInputs}/day25.txt"))
            {
                part1 += Day25Part1(input);
                part2 += Day25Part2(input);
            }

            Console.WriteLine($"2017 - Day 25 - Part 1 : {part1}");
            Console.WriteLine($"2017 - Day 25 - Part 2 : {part2}");
        }

        public static int Day25Part1(string input)
        {
            return 0;
        }

        public static int Day25Part2(string input)
        {
            return 0;
        }

        #endregion
    }
}