namespace Problem_6.Implement_ReversedList
{
    using System;

    class Program
    {
        static void Main()
        {
            //var reversedList = new ReversedList<int>();
            //            reversedList.Add(1);
            //            reversedList.Add(2);
            //            reversedList.Add(3);
            //            reversedList.Add(4);
            //            reversedList.Add(5);
            //
            //            reversedList[0] = 69;
            //
            //            var expectedElement = reversedList[0];


            ReversedList<int> data = new ReversedList<int>(2);
            data.Add(5);
            data.Add(4);
            data.Add(3);
            data.Add(2);
            data.Add(1);

            Console.WriteLine(data[0]);

            Console.WriteLine(String.Join(", ", data));


            ////            data.Add(5);
            ////            data.Add(6);
            ////            data.Add(7);
            ////            data.Add(8);
            //
            //            data.Remove(1);
            //            // data.Remove(1);
            //
            //            Console.WriteLine(data);
        }
    }
}
