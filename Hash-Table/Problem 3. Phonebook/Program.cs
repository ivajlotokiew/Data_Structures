namespace Problem_3.Phonebook
{
    using System;
    using Problem_1.Dictionary;

    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new HashTable<string, string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "search")
                {
                    break;
                }

                string[] userInfo = input.Split('-');

                var key = userInfo[0];
                var value = userInfo[1];

                if (!phonebook.ContainsKey(key))
                {
                    phonebook[key] = null;
                }

                phonebook[key] = value;
            }

            while (true)
            {
                string searchName = Console.ReadLine();
                if (searchName == "exit")
                {
                    return;
                }

                if (phonebook.ContainsKey(searchName))
                {
                    Console.WriteLine("{0} -> {1}", searchName, phonebook[searchName]);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", searchName);
                }
            }
        }
    }
}
