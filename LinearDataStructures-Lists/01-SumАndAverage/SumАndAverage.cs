namespace _01_SumАndAverage
{
    using System;
    using System.Linq;

    public static class SumАndAverage
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Insert a bunch of numbers separated by whitespace(s):");

                var inputNums = Console.ReadLine();
                if (inputNums != null)
                {
                    try
                    {
                        var nums = inputNums
                            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToList();

                        Console.WriteLine(
                            "Sum={0}; Average={1}",
                            nums.Count == 0 ? 0 : nums.Sum(),
                            nums.Count == 0 ? 0 : nums.Average());

                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.Error.WriteLine(ex.Message);
                    }
                    catch (OverflowException ex)
                    {
                        Console.Error.WriteLine(ex.Message);
                    }
                }
                else
                {
                    // Hit ctrl + Z if you want to check this scenario :P
                    Console.Error.WriteLine("Input cannot be null!");
                }
            }
        }
    }
}
