using BasicAlgorithms.Arrays;
using BasicAlgorithms.UI;
using System;
using System.Collections.Generic;

namespace BasicAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Home:
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Home();
            } while (keyInfo.KeyChar != '1' && keyInfo.KeyChar != '2');

            if (keyInfo.KeyChar == '1')
                Sort();
            if (keyInfo.KeyChar == '2')
                Search();

            goto Home;
        }
        static ConsoleKeyInfo Home()
        {
            Console.Clear();
            Console.WriteLine("Hello! Please choose:");
            Console.WriteLine("1: Sort Algorithms");
            Console.WriteLine("2: Search Algorithms");
            return Console.ReadKey(true);
        }

        static ConsoleKeyInfo Sort()
        {
            Console.Clear();
            new ArraySortUI(
                new ArraySortFactory(10000),
                90
            ).Print();

            Console.WriteLine();
            Console.WriteLine("Press any key for home screen!");

            return Console.ReadKey(true);
        }
        static ConsoleKeyInfo Search()
        {
            Console.Clear();
            new ArraySearchUI(
                new ArraySearchFactory(1000000),
                90
            ).Print();

            Console.WriteLine();
            Console.WriteLine("Press any key for home screen!");

            return Console.ReadKey(true);
        }
    }
}
