namespace _05.CountOfOccurrences
{
    using System;
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

            var occurences = Enumerable.Repeat(0, MaxElements + 1).ToArray();

            nums.ForEach(num => occurences[num]++);

            occurences
                .Select((num, i) => new {Num = i, Reps = num})
                .Where(num => num.Reps != 0)
                .ToList()
                .ForEach(num => Console.WriteLine($"{num.Num} -> {num.Reps}"));
        }
    }
}
