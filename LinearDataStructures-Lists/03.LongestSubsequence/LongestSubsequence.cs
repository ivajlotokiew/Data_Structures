namespace _03.LongestSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class LongestSubsequence
    {
        public static void Main()
        {
            Console.WriteLine("Insert a bunch of numbers separated by whitespace(s):");

            var inputNums = Console.ReadLine();
            if (inputNums != null)
            {
                var nums = inputNums
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                var longestSubsequence = FindLongestSubsequence(nums);

                Console.WriteLine(string.Join(" ", longestSubsequence));
            }
        }

        public static List<int> FindLongestSubsequence(IList<int> nums)
        {
            var longestSequence = int.MinValue;
            var startIndex = int.MinValue;

            for (int i = 0; i < nums.Count; i++)
            {
                var currentNum = nums[i];
                var currentLongestCount = 1;
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[j] != currentNum)
                    {
                        break;
                    }

                    currentLongestCount++;
                }

                if (currentLongestCount > longestSequence)
                {
                    longestSequence = currentLongestCount;
                    startIndex = i;
                }
            }

            var result = new List<int>(
                nums
                    .Skip(startIndex)
                    .Take(longestSequence));

            return result;
        }
    }
}
