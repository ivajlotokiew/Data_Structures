namespace _02.SortWords
{
    using System;
    using System.Linq;

    public static class SortWords
    {
        public static void Main()
        {
            Console.WriteLine("Insert a sequence of words separated by whitespace(s):");

            var inputWords = Console.ReadLine();
            if (inputWords != null)
            {
                var words = inputWords
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList()
                    .OrderBy(w => w);

                Console.WriteLine(string.Join(" ", words));
            }
        }
    }
}