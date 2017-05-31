namespace _04.RemoveOddOccurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class RemoveOddOccurences
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var distinctNums = new List<int>(nums.Distinct());
            foreach (var distinctNum in distinctNums)
            {
                if (nums.Count(n => n == distinctNum) % 2 == 1)
                {
                    nums.RemoveAll(num => num == distinctNum);
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
