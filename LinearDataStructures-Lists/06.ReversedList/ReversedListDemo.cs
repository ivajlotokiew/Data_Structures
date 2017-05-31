namespace _06.ReversedList
{
    using System;

    public static class ReversedListDemo
    {
        public static void Main()
        {
            var reversedList = new ReversedList<int>(6);
            Console.WriteLine("Empty list: " + reversedList);
            reversedList.Add(1);
            reversedList.Add(2);
            reversedList.Add(3);
            reversedList.Add(4);
            reversedList.Add(5);
            reversedList.Add(6);
            reversedList[0] = 169;
            Console.WriteLine("Capacity: " + reversedList.Capacity);
            Console.WriteLine("Element at index 1 (Should be 6): " + reversedList[1]);

            Console.WriteLine(reversedList);
            reversedList.Remove(4);
            Console.WriteLine(reversedList);
            reversedList[3] = 69;
            Console.WriteLine(reversedList);
            Console.WriteLine("Count: " + reversedList.Count);
            Console.WriteLine("Capacity: " + reversedList.Capacity);
        }
    }
}
