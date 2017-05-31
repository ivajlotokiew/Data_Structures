namespace _05.CountOfOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class CountOfOccurrences
    {
        private const int MaxElements = 1000;

        public static void Main()
        {
            Console.WriteLine("Input a bunch of numbers in range [0...1000] inclusive:");
            var nums = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var occurences = Enumerable.Repeat(0, MaxElements + 1)
                .ToArray();

            foreach (var num in nums)
            {
                occurences[num]++;
            }

            for (int num = 0; num <= MaxElements; num++)
            {
                if (occurences[num] > 0)
                {
                    Console.WriteLine($"{num} -> {occurences[num]} times");
                }
            }
        }
    }
}
